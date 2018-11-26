using AllersGroup;
using AllersGroup.modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Controlador
{
    public String reporte = "";

    public const String rutaArticulos = "/Articulos.csv";
    public const String rutaClientes = "/Clientes.csv";
    public const String rutaVentas = "/Ventas.csv";

    public const String rutaArticulosPrueba = "../../DatosPrueba/Articulos.csv";
    public const String rutaClientesPrueba = "../../DatosPrueba/Clientes.csv";
    public const String rutaVentasPrueba = "../../DatosPrueba/Ventas.csv";


    private List<List<int>> izq;
    private List<List<int>> der;
    private List<Articulo> articulos;
    private List<Cliente> clientes;
    private List<Venta> ventas;
    private List<String> asociaciones;
    private List<String> productosGenerados;
    private int numArticulos;
    private int tamanhoAgrupaciones;
    private int[,] matrizDeSimilitud;
    public double minSuport = 0;
    public double minCon = 0;
    public double inicial;
    public double adicion;
    public double aumento;
    private String rutaFolder;

    List<List<Articulo>> combinaciones;

    private BruteForce brute;
    private Apriori apriori;
    private FkMinus fkmin;
    private FP algoritmoFP;

    public List<Articulo> Articulos { get => articulos; set => articulos = value; }
    public List<Cliente> Clientes { get => clientes; set => clientes = value; }
    public List<Venta> Ventas { get => ventas; set => ventas = value; }
    public int NumArticulos { get => numArticulos; set => numArticulos = value; }
    public int TamanhoAgrupaciones { get => tamanhoAgrupaciones; set => tamanhoAgrupaciones = value; }

    public Controlador(double minConf, double minSup, string ruta)
    {
        rutaFolder = ruta;
        izq = new List<List<int>>();
        der = new List<List<int>>();
        articulos = new List<Articulo>();
        clientes = new List<Cliente>();
        ventas = new List<Venta>();
        combinaciones = new List<List<Articulo>>();
        asociaciones = new List<String>();
        brute = new BruteForce();
        apriori = new Apriori(minConf,minSup);
        fkmin = new FkMinus(minSup, minConf);
        minCon = minConf;
        minSuport = minSup;
        inicial = 0;
        adicion = 0;
        aumento = 0;

        productosGenerados = new List<String>();
        
    }

    public void CargarDatos()
    {
        CargarArticulos();
        CargarClientes();
        CargarVentas(rutaVentas);
        CargarItemsClientes();
        CargarMatrizDeSimilitud(0.8);
        AsignarSimilares();
    }

    public void CargarDatosPrueba()
    {
        CargarArticulos();
        CargarClientes();
        CargarVentas(rutaVentasPrueba);
    }
    public int getNumVentas()
    {
        return ventas.GroupBy(a => a.DocNum).Count();
    }
    public int getNumArticulos()
    {
        return articulos.Count();
    }
    public String ImprimirMatrizSimilitud(int i)
    {
        String mensaje = "";
            for (int j = 0; j < matrizDeSimilitud.GetLength(1); j++)
            {
                if (j == matrizDeSimilitud.Length - 1) mensaje += matrizDeSimilitud[i, j] + "\n";
                else mensaje +="Numero: " + j + " " + matrizDeSimilitud[i, j] + " ";
            }

        return mensaje;
    }
    public void CargarArticulos()
    {
        String line;
        try
        {
            StreamReader sr = new StreamReader(rutaFolder+rutaArticulos);
            line = sr.ReadLine();
            while ((line = sr.ReadLine()) != null)
            {
                String[] todo = line.Split(';');
                if (todo.Length == 3 && !todo.ToList().Any(r => r.Equals("")))
                {
                    int itemCode = Int16.Parse(todo[0]);
                    String itemName = todo[1];
                    String itemClasification = todo[2];
                    articulos.Add(new Articulo(itemCode, itemName, itemClasification));
                }

            }
            sr.Close();
        }
        catch (Exception e)
        {
            throw new Exception("Error al cargar los articulos");
        }
    }

    public List<string> darProductos()
    {

        var noRepetidos = new List<string>();
        foreach (var x in productosGenerados)
        {
            if (!noRepetidos.Contains(x))
            {
                noRepetidos.Add(x);
            }
        }

            
        return noRepetidos;
    }


    public void CargarClientes()
    {
        String line;
        try
        {
            int index = 0;
            StreamReader sr = new StreamReader(rutaFolder + rutaClientes);
            line = sr.ReadLine();
            while ((line = sr.ReadLine()) != null)
            {
                String[] todo = line.Split(';');
                if (todo.Length == 5 && !todo.ToList().Any(r => r.Equals("")))
                {
                    String cardCode = todo[0];
                    String groupName = todo[1];
                    String city = todo[2];
                    String department = todo[3];
                    String paymentGroup = todo[4];
                    clientes.Add(new Cliente(cardCode, groupName, city, department, paymentGroup, index));
                    index++;
                }
            }
            matrizDeSimilitud = new int[clientes.Count(), clientes.Count()];
            sr.Close();
        }
        catch
        {
            throw new Exception("Error al cargar los Clientes");
        }
    }
    public void CargarVentas(String ruta)
    {
        String line;
        string uno = "";
        string dos = "";
        string tres = "";
        try
        {

            StreamReader sr = new StreamReader(rutaFolder + ruta);
            line = sr.ReadLine();
            while ((line = sr.ReadLine()) != null)
            {
                String[] todo = line.Split(';');
                if (todo.Length == 8 && !todo.ToList().Any(r => r.Equals("")))
                {
                    String cardCode = todo[0];
                    String docNum = todo[1];
                    String[] tiempo = todo[2].Split('/');
                    int ano = Convert.ToInt32(tiempo[2]);
                    int mes = Convert.ToInt32(tiempo[1]);
                    int dia = Convert.ToInt32(tiempo[0]);
                    DateTime docDate = new DateTime(ano, mes, dia);

                    String docTotal = todo[3];
                    String itemCode = todo[4];
                    uno = todo[5];
                    dos = todo[6];
                    tres = todo[7];
                    int cantidad = Convert.ToInt32(todo[5]);
                    int precio = Convert.ToInt32(todo[6]);
                    double totalVenta = Convert.ToInt64(todo[7]);
                    ventas.Add(new Venta(cardCode, docNum, docDate, docTotal, itemCode, cantidad, precio, totalVenta));
                }
            }
            sr.Close();
        }
        catch (Exception e)
        {
            throw new Exception("Error al cargar las Ventas");
        }
    }
    public Cliente buscarClienteEnLista(String cardCode)
    {
        Cliente buscado = null;
        foreach (var x in clientes)
        {
            if (x.esCliente(cardCode))
            {
                buscado = x;
                break;
            }
        }
        return buscado;
    }
    public Articulo buscarArticuloEnLista(int itemCode)
    {
        Articulo buscado = null;
        foreach (var x in articulos)
        {
            if (x.esItemCode(itemCode))
            {
                buscado = x;
                break;
            }
        }
        return buscado;
    }
    

    public void CargarItemsClientes()
    {
        foreach(var x in ventas)
        {
            Cliente buscado = buscarClienteEnLista(x.CardCode);
            int itemCode = Convert.ToInt32(x.ItemCode);
            if (!buscado.ArticuloRepetido(itemCode))
                {
                    buscado.Comprados.Add(itemCode);
                }     
        }
    }

    public void CargarMatrizDeSimilitud(double porcentaje)
    {
        Cliente[] temp = clientes.ToArray();
        for(int i = 0; i < temp.Length; i++)
        {
            Cliente actual = temp[i];
            for (int j = 0; j < temp.Length; j++)
            {
                if(i == j)
                {
                    matrizDeSimilitud[i, j] = 0;
                }
                else
                {
                    Cliente actual2 = temp[j];
                    matrizDeSimilitud[i, j] = actual.RelacionConCliente(porcentaje, actual2);
                }
            }
        }
    }
    public void AsignarSimilares()
    {
        foreach(var x in clientes)
        {
            AsignarSimilaresDiv(x);
        }
    }
    public void AsignarSimilaresDiv(Cliente x)
    {
        int index = x.Pos;
        for (int i = 0; i < matrizDeSimilitud.GetLength(1); i++)
        {
            if(matrizDeSimilitud[index,i]== 1)
            {
                x.Similares.Add(clientes.ElementAt(i));
            }
        }
    }


    public List<int> mostrarProductosImplicados(String codProducto)
    {
        int itemBuscado = Convert.ToInt32(codProducto);
        //Como solo es 1
        int index = BuscarIndexImplicante(itemBuscado);
        return der.ElementAt(index);
        
    }


    public int mostrarValorInicial(string codProducto)
    {
        return int.Parse(inicial + "");
        
    }

    public int mostrarValorFinal(string codProducto)
    {

        double op = inicial + adicion;
        return int.Parse(op + "");
    }
    public int mostrarAumento(string codProducto)
    {
        double op = adicion * 100;
        return int.Parse(op + "");
    }





    public int BuscarIndexImplicante(int itemBuscado)
    {
        int index = 0;
        foreach(var x in izq)
        {
            if(x.Count() == 1)
            {
                if (x.Contains(itemBuscado))
                {
                    break;
                }
            }
            index++;
        }
        return index;
    }


    
    public String ReporteSimiliares(String cardCodeBuscado)
    {
        Cliente buscado = buscarClienteEnLista(cardCodeBuscado);
        return buscado.ImprimirClientesSimilares();
    }
    public int[] masFrecuentesMetodo(int num)
    {
        int[] respuesta = new int[num];
        Dictionary<string, int> apariciones = new Dictionary<string, int>();
        foreach (var a in ventas)
        {
            if (!apariciones.ContainsKey(a.ItemCode))
            {
                apariciones.Add(a.ItemCode, 0);
            }
            else
            {
                apariciones[a.ItemCode] = apariciones[a.ItemCode] + 1;
            }

        }
        int[] respuestas = apariciones.Values.ToArray();
        Organizar(respuestas);
        for (int i = 0; i < num; i++)
        {
            String Key = apariciones.FirstOrDefault(x => x.Value == respuestas[i]).Key;
            respuesta[i] = Convert.ToInt32(Key);
            apariciones[Key] = -1;
        }
        return respuesta;
    }
    public int apariciones(int codigo)
    {
        int contador = 0;
        foreach (var a in ventas)
        {
            if (a.ItemCode.Equals(codigo + "")) contador++;
        }
        return contador;
    }
    public string[] masFrecuentesMetodo2(int num,String cat)
    {
        int[] respuesta = new int[num];
        Dictionary<string, int> apariciones = new Dictionary<string, int>();
        List<Venta> ventass = agruparLista(cat);
        foreach (var a in ventass)
        {
            if (!apariciones.ContainsKey(a.ItemCode))
            {
                apariciones.Add(a.ItemCode, 0);
            }
            else
            {
                apariciones[a.ItemCode] = apariciones[a.ItemCode] + 1;
            }

        }
        int[] respuestas = apariciones.Values.ToArray();
        Organizar(respuestas);
        for (int i = 0; i < num; i++)
        {
            String Key = apariciones.FirstOrDefault(x => x.Value == respuestas[i]).Key;
            respuesta[i] = Convert.ToInt32(Key);
            apariciones[Key] = -1;
        }
        string[] respuesta2 = new string[num];
        for (int i = 0; i < respuesta.Count(); i++)
        {
            
            respuesta2[i] = busquedaNombreItem(respuesta[i]+"");
        }
        return respuesta2;
    }
    public void Organizar(int[] A)
    {
        QuickSort(A, 0, A.Length - 1);
    }

    public void QuickSort(int[] A, int p, int r)
    {
        if (p < r)
        {
            int q = Partition(A, p, r);
            QuickSort(A, p, q - 1);
            QuickSort(A, q + 1, r);
        }
    }

    private int Partition(int[] A, int p, int r)
    {
        int x = A[r];
        int temp;

        int i = p;
        for (int j = p; j < r; j++)
        {
            if (A[j] >= x)
            {
                temp = A[j];
                A[j] = A[i];
                A[i] = temp;
                i++;
            }
        }

        A[r] = A[i];
        A[i] = x;
        return i;
    }
    public String Promociones()
    {
        String mensaje = "\n";
        foreach(var n in asociaciones)
        {
            mensaje += n;
        }
        return mensaje;
    }
   
    //APLICACIÓN DE ESTRATEGIA DE FUERZA BRUTA***************


    public void BruteForceMethod(int tamanho, int numArti)
    {

        int[] darItemCode = masFrecuentesMetodo(numArti);
        brute.generarAsociaciones(tamanho, darItemCode, Ventas,minSuport,minCon);
        reporte += brute.Reporte;

    }
    //FIN APLICACION ESTRATEGIA DE FUERZA BRUTA *************

    // APLICACIÓN ESTRATEGIA A-PRIORI *****************
    public void AprioriMethod(int tamanho, int numArti)
    {
        TamanhoAgrupaciones = tamanho;
        NumArticulos = numArticulos;
        int[] darItemCode = masFrecuentesMetodo(numArti);
        apriori.Generar(tamanho, ventas, darItemCode);
        izq = apriori.Implicantes;
        der = apriori.Implicados;
        List<List<int>> completas = apriori.Completas;
        int reglas = izq.Count;
        for(int i = 0; i < reglas; i++)
        {
            ConvertirAsociaciones(izq.ElementAt(i), der.ElementAt(i));
        }
        foreach (var n in completas)
        {
            ConvertirAsociacionesCompletas(n);
        }

        reporte += apriori.Reporte;
    }

    // FIN APLICACIÓN ESTRATEGIA A-PRIORI *******************

    // APLICACIÓN ESTRATEGIA F(k-1)XF1   *****************

    public void FkMinus1XF1Method(int tamanho, int numArticulos)
    {
        int[] F1 = masFrecuentesMetodo(numArticulos);
        fkmin.FkMinus1XF1(tamanho, F1, Ventas);
        reporte += fkmin.Reporte;
    }

    // FIN APLIACION ESTRATEGIA F(k-1)XF1   *****************

    // APLICACIÓN ESTRATEGIA FP   *****************
    public FP AlgoritmoFP { get => algoritmoFP; set => algoritmoFP = value; }
    public string RutaFolder { get => rutaFolder; set => rutaFolder = value; }

    public List<string> estrategiaFP(List<Venta> ventas)
    {
        List<string> retorno = new List<string>();
        String mensaje = "";
        int supCount = (int)(minSuport * ventas.GroupBy(a => a.DocNum).Count());
        algoritmoFP = new FP(supCount);
        List<List<Object>> listaRepeticiones= new List<List<Object>>();


        List<List<Object>> poda = new List<List<Object>>();

        listaRepeticiones = algoritmoFP.repeticionesUnitarias(ventas);
        poda = algoritmoFP.objetosCumplen(listaRepeticiones);
        algoritmoFP.ordenarMayorMenor(poda);

        Arbol tree = new Arbol((supCount/2));

        List<string> listaEncontrada = new List<string>();

        var x = ventas.GroupBy(n => n.DocNum);
        foreach (var m in x)
        {
            String[] trans = new String[m.Count()];
            int contador = 0;
            foreach (var s in m)
            {
                
                trans[contador] = s.ItemCode;
                contador++;
            }

            for (int i = 0; i < poda.Count; i++)
            {

                if (trans.Contains(poda[i][0].ToString()))
                {
                    listaEncontrada.Add(poda[i][0].ToString());
                }
            }
            tree.crearArbol(listaEncontrada);
            listaEncontrada.Clear();
        }
        List<string> itemsFrecuentes = new List<string>();
        itemsFrecuentes = tree.generarItemsSetsFrecuentes(tree.raiz, itemsFrecuentes);
        mensaje += "El mayor item set es \n";
        foreach (string item in itemsFrecuentes)
        {
            // string nombre = busquedaNombreItem(item);
            retorno.Add(item);
            string nombre = item;
            mensaje +=nombre+ "\n";
        }
        return retorno;
    }
    public Cliente busquedaCliente(String cardcode)
    {
        var cliente = clientes.FirstOrDefault(n => n.CardCode.Equals(cardcode));
        return cliente;
    }
  
    public List<Venta> agruparLista(string cat)
    {
       
        List<Venta> ventas2 = ventas.Where(t => busquedaCliente(t.CardCode) != null&&busquedaCliente(t.CardCode).GroupName.Equals(cat)).ToList();
        return ventas2;
    }

    // FIN APLIACION ESTRATEGIA FP----------------------------------------------------------------------------------------------------------------

    public void ConvertirAsociaciones(List<int> izq, List<int> der)
    {
        if (izq.Count() != 0)
        {
            double [] precios = BuscarPrecioEnLista(izq, der);
            inicial = precios[0];
            adicion = precios[1];
            aumento = precios[2];
            String asociacion = " \nAl comprar los siguientes Items\n";
            Articulo temporal = null;
            foreach (var n in izq)
            {
                temporal = this.BuscarItem(n);
                asociacion += "- " + temporal.ItemName + " ItemCode: " + n + "\n";
            }
            asociacion += "\n Implica que su cliente puede comprar estos productos adicionales:\n";

           
            foreach (var x in der)
            {
                temporal = this.BuscarItem(x);
                
                asociacion += "- " + temporal.ItemName + " ItemCode: " + x + "\n";
                productosGenerados.Add(x+"");

            }
            asociacion += "Esto significa que en una compra unitaria de estos artículos, ocurría esto:\nValor Inicial (sin los productos adicionales): " + inicial + "$\nValor Final (con los productos adicionales): " + (adicion + inicial) + "$\nAumentando el valor de la compra en un " + (aumento * 100) + "%\n";
            asociacion += "-------------------------------------------------------------------------------------------------\n";
            //asociaciones.Add(asociacion);
        }
    }

    

    public void ConvertirAsociacionesCompletas(List<int> com)
    {
        String asociacion = "";

        foreach(var n in com)
        {
            asociacion +="- " + BuscarItem(n).ItemName + "\n";
            productosGenerados.Add(n+"");

        }
        asociacion += "\n________________________________\n";;
        asociaciones.Add(asociacion);
    }
    
    public String busquedaNombreItem(string item)
    {
        string nombre = "";
        int item1 = Int16.Parse(item);
        var x = articulos.First(n => n.ItemCode == item1);
        nombre = x.ItemName;
        return nombre;
    }
    public Articulo BuscarItem(int itemCode)
    {
        Articulo buscado = null;
        foreach (var n in articulos)
        {
            if (n.esItemCode(itemCode))
            {
                buscado = n;
                break;
            }
        }
        return buscado;
    }
    public double[] BuscarPrecioEnLista(List<int> inicial, List<int> adicionales)
    {
        // Uno: Precio total inicial de la venta
        // Dos: Precio total de los articulos que se desean adicionar.
        // Aumento: Decimal que representa el porcentaje de lo que aumenta al comprar estos articulos adicionales.
        List<double> resultados = new List<double>();
        
        if(inicial.Count != 0)
        {
            double uno = 0;
            double dos = 0;
            foreach (var n in inicial)
            {
                uno += this.BuscarPrecio(n);
            }
            foreach (var x in adicionales)
            {

                dos += this.BuscarPrecio(x);
            }
            double aumento = 0;
            if (dos != 0)
            {
                aumento = ((uno + dos) / uno)-1;
                aumento = Math.Round(aumento, 2);
            }
            resultados.Add(uno);
            resultados.Add(dos);
            resultados.Add(aumento);
        }
            return resultados.ToArray();
    }
    public int BuscarPrecio(int itemCode)
    {
        int precio = 0;
        foreach (var n in ventas)
        {
            if (n.ItemCode.Equals(""+itemCode))
            {
                precio = n.Precio;
                break;
            }
        }
        return precio;
    }

    public List<String> darClientesRecuperar(int dias)
    {
        List<String> retorno= new List<String>();
        var a = ventas.GroupBy(e => e.CardCode);
        DateTime mayorFecha = this.mayorFecha();
        foreach (var cliente in a)
        {
            DateTime mayorFechaCliente = cliente.Max(e => e.DocDate);
            TimeSpan diferencia = mayorFecha - mayorFechaCliente;
            if(diferencia.Days>dias)
            {
                retorno.Add(cliente.FirstOrDefault().CardCode);
            }
        }
        return retorno;
    }
    public DateTime mayorFecha()
    {
        return ventas.Max(a=>a.DocDate);
    }
    public List<String> ItemsRecuperar(String cliente)
    {
        List<String> retorno = new List<string>();
        Cliente buscado = buscarClienteEnLista(cliente);
        List<Cliente> similares = buscado.Similares;
        List<Venta> ventasSimilares = new List<Venta>();
        String mensaje = "";
        mensaje += buscado.CardCode;
        if (similares.Count == 0) mensaje = "No hay similares";
        else
        {

        foreach (var a in similares)
        {
            foreach (var e in ventas)
            {
                if (e.CardCode.Equals(a.CardCode)) ventasSimilares.Add(e);
            }
        }
        if (ventasSimilares.Count > 20)
        {
            mensaje = "Los items para recuperar dicho cliente con mayor probabilidad a partir de los similares son: " + "\n";
            //mensaje += estrategiaFP(ventasSimilares);
            retorno = estrategiaFP(ventasSimilares);

        }
        else mensaje += "No hay suficientes ventas para predecir un cliente";
        }


        return retorno;
    }

    //---------------------------------------------------------------------------------------------------------------------------------------------
    //Método para UnitTest
    public int[] refrescarItemCodes(List<List<int>> combinaciones)
    {
        List<int> codigo = new List<int>();
        foreach (var n in combinaciones)
        {
            foreach (var x in n)
            {
                if (!codigo.Contains(x))
                {
                    codigo.Add(x);
                }
            }

        }
        return codigo.OrderBy(n => n).ToArray();
    }

    public int RepeticionEnVentasP(List<int> combinaciones)
    {
        int tamanho = combinaciones.Count();
        int count = 0;
        int count2 = 0;
        String mensaje = "";
        for (int i = 0; i < tamanho; i++)
        {
            mensaje += combinaciones.ElementAt(i) + " ";
        }
        var x = ventas.GroupBy(n => n.CardCode);
        foreach (var m in x)
        {
            if (m.Count() >= 7)
            {
                count2 = 0;
                foreach (var s in m)
                {
                    if (combinaciones.Contains(Convert.ToInt32(s.ItemCode)))
                    {
                        count2++;
                    }
                }
                if (count2 == 7)
                {
                    count++;

                }

            }
        }
        Console.WriteLine(mensaje + "\n" + count);
        return count;
    }

    public List<List<int>> AprioriP(int tamanho, int numArti)
    {
        Console.WriteLine("Tamaño =  " + tamanho);
        int supCount = (int)(minSuport * getNumVentas());
        Console.WriteLine("Num Ventas = " + getNumVentas());
        Console.WriteLine("SupCount = " + supCount + "\n");
        int i = 1;
        List<List<int>> temp = new List<List<int>>();

        int[] darItemCode = masFrecuentesMetodo(numArti);
        int[] poda = darItemCode;
        while (i <= tamanho)
        {
            List<List<int>> combinacion = CombinacionHasta7(i, poda);
            List<int> repeticiones = RepeticionEnVentas(combinacion);
            int temp2 = repeticiones.Count();
            for (int x = 0; x < temp2; x++)
            {
                if (repeticiones.ElementAt(x) >= supCount)
                {
                    temp.Add(combinacion.ElementAt(x));
                }
            }
            if (tamanho == i)
            {
                break;
            }
            else
            {
                poda = refrescarItemCodes(temp);
                temp = new List<List<int>>();
                i++;

            }
        }
        Console.WriteLine("Utilizando el método apriori \nLas combinaciones de " + tamanho + " elementos que cumplen con el Support Count definido son: \n ");
        temp.ForEach(n => ImprimirCombinaciones(n));
        return temp;
    }
    public String ImprimirCombinaciones(List<int> n)
    {
        String mensaje = "";
        String temp = "";
        int tamanho = n.Count();
        for (int i = 0; i < tamanho; i++)
        {

            int x = n.ElementAt(i);
            //if (x == 1) temp = "Bread";
            //else if (x == 2) temp = "Milk";
            //else if (x == 3) temp = "Diapers";
            //else if (x == 4) temp = "Beer";
            //else if (x == 5) temp = "Eggs";
            //else if (x == 6) temp = "Cola";
            temp += x;
            mensaje += (i + 1) + ". " + temp + "\n";
            temp = "";
            if (i == tamanho - 1)
            {
                mensaje += "\n";
            }
        }
        return mensaje;

    }
    //Método supremamente extenso.
    public List<List<int>> CombinacionHasta7(int tamanhoGrupo, int[] code)
    {
        List<List<int>> resultado = new List<List<int>>();
        if (tamanhoGrupo <= 0 || code.Length < tamanhoGrupo)
        {
            reporte += "No se puede realizar esta operación";
        }
        else
        {
            bool c2 = false;
            bool c3 = false;
            bool c4 = false;
            bool c5 = false;
            bool c6 = false;
            bool c7 = false;
            if (tamanhoGrupo == 2)
            {
                c2 = true;
            }
            else if (tamanhoGrupo == 3)
            {
                c2 = true;
                c3 = true;
            }
            else if (tamanhoGrupo == 4)
            {
                c2 = true;
                c3 = true;
                c4 = true;
            }
            else if (tamanhoGrupo == 5)
            {
                c2 = true;
                c3 = true;
                c4 = true;
                c5 = true;
            }
            else if (tamanhoGrupo == 6)
            {
                c2 = true;
                c3 = true;
                c4 = true;
                c5 = true;
                c6 = true;
            }
            else if (tamanhoGrupo == 7)
            {
                c2 = true;
                c3 = true;
                c4 = true;
                c5 = true;
                c6 = true;
                c7 = true;

            }
            for (int i = 0; i < code.Length; i++)
            {
                if (c2 == false)
                {
                    List<int> combinacion = new List<int>();
                    combinacion.Add(code[i]);
                    resultado.Add(combinacion);
                }
                for (int j = i + 1; j < code.Length && c2; j++)
                {
                    if (c3 == false)
                    {
                        List<int> combinacion = new List<int>();
                        combinacion.Add(code[i]);
                        combinacion.Add(code[j]);
                        resultado.Add(combinacion);
                    }
                    for (int k = j + 1; k < code.Length && c3; k++)
                    {
                        if (c4 == false)
                        {
                            List<int> combinacion = new List<int>();
                            combinacion.Add(code[i]);
                            combinacion.Add(code[j]);
                            combinacion.Add(code[k]);
                            resultado.Add(combinacion);
                        }
                        for (int l = k + 1; l < code.Length && c4; l++)
                        {
                            if (c5 == false)
                            {
                                List<int> combinacion = new List<int>();
                                combinacion.Add(code[i]);
                                combinacion.Add(code[j]);
                                combinacion.Add(code[k]);
                                combinacion.Add(code[l]);
                                resultado.Add(combinacion);
                            }
                            for (int m = l + 1; m < code.Length && c5; m++)
                            {
                                if (c6 == false)
                                {
                                    List<int> combinacion = new List<int>();
                                    combinacion.Add(code[i]);
                                    combinacion.Add(code[j]);
                                    combinacion.Add(code[k]);
                                    combinacion.Add(code[l]);
                                    combinacion.Add(code[m]);
                                    resultado.Add(combinacion);
                                }
                                for (int n = m + 1; n < code.Length && c6; n++)
                                {
                                    if (c7 == false)
                                    {
                                        List<int> combinacion = new List<int>();
                                        combinacion.Add(code[i]);
                                        combinacion.Add(code[j]);
                                        combinacion.Add(code[k]);
                                        combinacion.Add(code[l]);
                                        combinacion.Add(code[m]);
                                        combinacion.Add(code[n]);
                                        resultado.Add(combinacion);
                                    }
                                    for (int o = n + 1; o < code.Length && c7; o++)
                                    {
                                        List<int> combinacion = new List<int>();
                                        combinacion.Add(code[i]);
                                        combinacion.Add(code[j]);
                                        combinacion.Add(code[k]);
                                        combinacion.Add(code[l]);
                                        combinacion.Add(code[m]);
                                        combinacion.Add(code[n]);
                                        combinacion.Add(code[o]);
                                        resultado.Add(combinacion);
                                    }

                                }

                            }

                        }

                    }

                }
            }

        }

        return resultado;
    }
    public List<int> RepeticionEnVentas(List<List<int>> todo)
    {
        List<int> resultados = new List<int>();
        foreach (var combinaciones in todo)
        {
            resultados.Add(RepeticionEnVentasUnitario(combinaciones));
        }
        return resultados;
    }
    public int RepeticionEnVentasUnitario(List<int> todo)
    {
        int countaux = 0;
        int count = 0;
        int tamanho = todo.Count();
        var x = ventas.GroupBy(n => n.DocNum);

        foreach (var m in x)
        {
            if (m.Count() >= tamanho)
            {
                countaux = 0;
                foreach (var k in m)
                {
                    if (todo.Contains(Convert.ToInt32(k.ItemCode)))
                    {
                        countaux++;
                    }
                }
                if (countaux == tamanho)
                {
                    count++;
                }
            }
        }
        return count;
    }

    //------------------------------------------------------------------------------------------------------------------------------------------


}
