using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCriptoAnalisis;

namespace AppCriptoAnalisis
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        string[][] listIngles = new string[26][];
        string[][] listEspanol = new string[26][];
        string[][] listFrances = new string[26][];
        string[][] listAleman = new string[26][];

        string[][] listBigramaIngles = new string[31][];
        string[][] listBigramaEspanol = new string[31][];
        string[][] listBigramaFrances = new string[31][];
        string[][] listBigramaAleman = new string[31][];

        string[][] listTrigramaIngles = new string[34][];
        string[][] listTrigramaEspanol = new string[34][];
        string[][] listTrigramaFrances = new string[34][];
        string[][] listTrigramaAleman = new string[34][];

        string[][] listFrase;
        List<String> listLetras;

        string[][] listBigramaEspanolAux;

        private void Form_Load(object sender, EventArgs e)
        {
            ReadingCSV frecuencias = new ReadingCSV();
            frecuencias.LeerFrecuencia(listIngles, listEspanol, listFrances, listAleman);
            frecuencias.LeerBigramaFrecuencia(listBigramaIngles, listBigramaEspanol, listBigramaFrances, listBigramaAleman);
            frecuencias.LeerTrigramaFrecuencia(listTrigramaIngles, listTrigramaEspanol, listTrigramaFrances, listTrigramaAleman);
            //Ingles
            DGV_Ingles.Columns.Add("letra", "Letra");
            DGV_Ingles.Columns["Letra"].Width = 50;
            DGV_Ingles.Columns.Add("porcentaje", "Porcentaje");
            DGV_Ingles.Columns["Porcentaje"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Ingles.Columns["Porcentaje"].Width = 60;
            String LineaIngles = null;
            for (int i = 0; i < listIngles.Length; i++)
            {
                LineaIngles = LineaIngles + listIngles[i][0] + " - " + listIngles[i][1] + "\r\n";
                DGV_Ingles.Rows.Add(listIngles[i][0], Convert.ToDouble(listIngles[i][1]));
            }
            txt_Ingles.Text = LineaIngles;
            //Espanol
            DGV_FrecuenciaAux.Columns.Add("letra", "Letra");
            DGV_FrecuenciaAux.Columns["Letra"].Width = 50;
            DGV_FrecuenciaAux.Columns.Add("porcentaje", "Porcentaje");
            DGV_FrecuenciaAux.Columns["Porcentaje"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_FrecuenciaAux.Columns["Porcentaje"].Width = 60;

            DGV_Espanol.Columns.Add("letra", "Letra");
            DGV_Espanol.Columns["Letra"].Width = 50;
            DGV_Espanol.Columns.Add("porcentaje", "Porcentaje");
            DGV_Espanol.Columns["Porcentaje"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Espanol.Columns["Porcentaje"].Width = 60;
            String LineaEspanol = null;
            for (int i = 0; i < listEspanol.Length; i++)
            {
                LineaEspanol = LineaEspanol + listEspanol[i][0] + " - " + listEspanol[i][1] + "\r\n";
                //DGV_FrecuenciaAux.Rows.Add(listEspanol[i][0], Convert.ToDouble(listEspanol[i][1]));
                DGV_Espanol.Rows.Add(listEspanol[i][0], Convert.ToDouble(listEspanol[i][1]));
            }
            txt_Espanol.Text = LineaEspanol;
            //Frances
            DGV_Frances.Columns.Add("letra", "Letra");
            DGV_Frances.Columns["Letra"].Width = 50;
            DGV_Frances.Columns.Add("porcentaje", "Porcentaje");
            DGV_Frances.Columns["Porcentaje"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Frances.Columns["Porcentaje"].Width = 60;
            String LineaFrances = null;
            for (int i = 0; i < listFrances.Length; i++)
            {
                LineaFrances = LineaFrances + listFrances[i][0] + " - " + listFrances[i][1] + "\r\n";
                DGV_Frances.Rows.Add(listFrances[i][0], Convert.ToDouble(listFrances[i][1]));
            }
            txt_Frances.Text = LineaFrances;
            //Aleman
            DGV_Aleman.Columns.Add("letra", "Letra");
            DGV_Aleman.Columns["Letra"].Width = 50;
            DGV_Aleman.Columns.Add("porcentaje", "Porcentaje");
            DGV_Aleman.Columns["Porcentaje"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Aleman.Columns["Porcentaje"].Width = 60;
            String LineaAleman = null;
            for (int i = 0; i < listAleman.Length; i++)
            {
                LineaAleman = LineaAleman + listAleman[i][0] + " - " + listAleman[i][1] + "\r\n";
                DGV_Aleman.Rows.Add(listAleman[i][0], Convert.ToDouble(listAleman[i][1]));
            }
            txt_Aleman.Text = LineaAleman;
            //Texto
            DGV_text.Columns.Add("letra", "Letra");
            DGV_text.Columns["Letra"].Width = 50;
            DGV_text.Columns.Add("porcentaje", "Porcentaje");
            DGV_text.Columns["Porcentaje"].ValueType = typeof(double);
            DGV_text.Columns["Porcentaje"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_text.Columns["Porcentaje"].Width = 60;

            DGV_text02.Columns.Add("letra", "Letra");
            DGV_text02.Columns["Letra"].Width = 50;
            DGV_text02.Columns.Add("porcentaje", "Porcentaje");
            DGV_text02.Columns["Porcentaje"].ValueType = typeof(double);
            DGV_text02.Columns["Porcentaje"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_text02.Columns["Porcentaje"].Width = 60;
            //Texto Bigrama
            DGV_BigramaEspanol.Columns.Add("letra", "Letra");
            DGV_BigramaEspanol.Columns["Letra"].Width = 50;
            DGV_BigramaEspanol.Columns.Add("cantidad", "Cantidad");
            DGV_BigramaEspanol.Columns["Cantidad"].ValueType = typeof(double);
            DGV_BigramaEspanol.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_BigramaEspanol.Columns["Cantidad"].Width = 60;
            //Texto Trigrama
            DGV_TrigramaEspanol.Columns.Add("letra", "Letra");
            DGV_TrigramaEspanol.Columns["Letra"].Width = 50;
            DGV_TrigramaEspanol.Columns.Add("cantidad", "Cantidad");
            DGV_TrigramaEspanol.Columns["Cantidad"].ValueType = typeof(double);
            DGV_TrigramaEspanol.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_TrigramaEspanol.Columns["Cantidad"].Width = 60;
            //DGV_BigramaHipotesis
            DGV_BigramaHipotesis.Columns.Add("letra1", "Letra1");
            DGV_BigramaHipotesis.Columns["Letra1"].Width = 50;
            DGV_BigramaHipotesis.Columns.Add("letra2", "Letra2");
            DGV_BigramaHipotesis.Columns["Letra2"].Width = 50;
        }

        private void cargaIdiomaFrecuencia(string idioma) {
            
            switch (idioma)
            {
                case "Espanol":
                    for (int i = 0; i < listEspanol.Length; i++)
                    {
                        DGV_FrecuenciaAux.Rows.Add(listEspanol[i][0], Convert.ToDouble(listEspanol[i][1]));
                    }
                    label_Frecuencia.Text = "Frecuencia Espanol";
                    break;
                case "Ingles":
                    for (int i = 0; i < listIngles.Length; i++)
                    {
                        DGV_FrecuenciaAux.Rows.Add(listIngles[i][0], Convert.ToDouble(listIngles[i][1]));
                    }
                    label_Frecuencia.Text = "Frecuencia Ingles";
                    break;
                case "Frances":
                    for (int i = 0; i < listFrances.Length; i++)
                    {
                        DGV_FrecuenciaAux.Rows.Add(listFrances[i][0], Convert.ToDouble(listFrances[i][1]));
                    }
                    label_Frecuencia.Text = "Frecuencia Frances";
                    break;
                case "Aleman":
                    for (int i = 0; i < listAleman.Length; i++)
                    {
                        DGV_FrecuenciaAux.Rows.Add(listAleman[i][0], Convert.ToDouble(listAleman[i][1]));
                    }
                    label_Frecuencia.Text = "Frecuencia Aleman";
                    break;
            }
        }

        private void trigrama(string txt_Frase)
        {
            string cadena = txt_Frase;
            Boolean Buscador = false;
            int Contador = 0;
            int ContadorLetra = 0;

            //listFrase = new string[26][];
            listLetras = new List<String>();

            for (int i = 0; i < cadena.Length - 2; i++)
            {

                foreach (string letra in listLetras)
                {
                    if (letra == cadena.Substring(i, 3))
                    {
                        Buscador = true;
                        break;
                    }
                    else
                    {
                        Buscador = false;
                    }
                }

                if (Buscador == false)
                {
                    listLetras.Add(cadena.Substring(i, 3));
                    ContadorLetra++;
                }

            }
            //
            listFrase = new string[ContadorLetra][];
            Buscador = false;
            Contador = 0;
            ContadorLetra = 0;
            listLetras.Clear();
            //
            for (int i = 0; i < cadena.Length - 2; i++)
            {

                foreach (string letra in listLetras)
                {
                    if (letra == cadena.Substring(i, 3))
                    {
                        Buscador = true;
                        break;
                    }
                    else
                    {
                        Buscador = false;
                    }
                }

                if (Buscador == false)
                {
                    listLetras.Add(cadena.Substring(i, 3));
                    for (int y = 0; y < cadena.Length - 2; y++)
                    {
                        if (cadena.Substring(i, 3) == cadena.Substring(y, 3))
                        {
                            Contador++;
                        }
                    }

                    listFrase[ContadorLetra] = new string[2] { cadena.Substring(i, 3).ToUpper(), Contador.ToString() };
                    Contador = 0;
                    ContadorLetra++;
                }

            }

            string[][] listFraseAux = new string[ContadorLetra][];
            for (int z = 0; z < ContadorLetra; z++)
            {
                double ContadorAux = Convert.ToDouble(listFrase[z][1]);
                double ContadorAuxLetra = cadena.Length;
                double Porcentaje = (ContadorAux / ContadorAuxLetra) * 100;
                //listFraseAux[z] = new string[2] { listFrase[z][0], Porcentaje.ToString("0.00000") };
                listFraseAux[z] = new string[2] { listFrase[z][0], listFrase[z][1] };
            }

            //Idioma
            String LineaIdioma = null;
            for (int i = 0; i < listFraseAux.Length; i++)
            {
                LineaIdioma = LineaIdioma + listFraseAux[i][0] + " - " + listFraseAux[i][1] + "\r\n";
                DGV_TrigramaEspanol.Rows.Add(listFraseAux[i][0], Convert.ToDouble(listFraseAux[i][1]));
            }

            DGV_TrigramaEspanol.Sort(DGV_TrigramaEspanol.Columns["Cantidad"], ListSortDirection.Descending);
        }

        private void bigrama(string txt_Frase)
        {
            string cadena = txt_Frase;
            Boolean Buscador = false;
            int Contador = 0;
            int ContadorLetra = 0;

            //listFrase = new string[26][];
            listLetras = new List<String>();

            for (int i = 0; i < cadena.Length - 1; i++)
            {

                foreach (string letra in listLetras)
                {
                    if (letra == cadena.Substring(i, 2))
                    {
                        Buscador = true;
                        break;
                    }
                    else
                    {
                        Buscador = false;
                    }
                }

                if (Buscador == false)
                {
                    listLetras.Add(cadena.Substring(i, 2));
                    ContadorLetra++;
                }

            }
            //
            listFrase = new string[ContadorLetra][];
            Buscador = false;
            Contador = 0;
            ContadorLetra = 0;
            listLetras.Clear();
            //
            for (int i = 0; i < cadena.Length - 1; i++)
            {

                foreach (string letra in listLetras)
                {
                    if (letra == cadena.Substring(i, 2))
                    {
                        Buscador = true;
                        break;
                    }
                    else
                    {
                        Buscador = false;
                    }
                }

                if (Buscador == false)
                {
                    listLetras.Add(cadena.Substring(i, 2));
                    for (int y = 0; y < cadena.Length - 1; y++)
                    {
                        if (cadena.Substring(i, 2) == cadena.Substring(y, 2))
                        {
                            Contador++;
                        }
                    }

                    listFrase[ContadorLetra] = new string[2] { cadena.Substring(i, 2).ToUpper(), Contador.ToString() };
                    Contador = 0;
                    ContadorLetra++;
                }

            }

            string[][] listFraseAux = new string[ContadorLetra][];
            for (int z = 0; z < ContadorLetra; z++)
            {
                double ContadorAux = Convert.ToDouble(listFrase[z][1]);
                double ContadorAuxLetra = cadena.Length;
                double Porcentaje = (ContadorAux / ContadorAuxLetra) * 100;
                //listFraseAux[z] = new string[2] { listFrase[z][0], Porcentaje.ToString("0.00000") };
                listFraseAux[z] = new string[2] { listFrase[z][0], listFrase[z][1] };
            }

            //Idioma
            String LineaIdioma = null;
            for (int i = 0; i < listFraseAux.Length; i++)
            {
                LineaIdioma = LineaIdioma + listFraseAux[i][0] + " - " + listFraseAux[i][1] + "\r\n";
                DGV_BigramaEspanol.Rows.Add(listFraseAux[i][0], Convert.ToDouble(listFraseAux[i][1]));
            }

            DGV_BigramaEspanol.Sort(DGV_BigramaEspanol.Columns["Cantidad"], ListSortDirection.Descending);

        }

        private void frecuencia(string txt_Frase) { 
            string cadena = txt_Frase;
            Boolean Buscador = false;
            int Contador = 0;
            int ContadorLetra = 0;

            listFrase = new string[26][];
            listLetras = new List<String>();
            listLetras = new List<String>();

            for (int i = 0; i < cadena.Length; i++)
            {

                foreach (string letra in listLetras) {
                    if (letra == cadena.Substring(i, 1))
                    {
                        Buscador = true;
                        break;
                    }
                    else {
                        Buscador = false;
                    }
                }

                if (Buscador == false) { 
                    listLetras.Add(cadena.Substring(i, 1));
                    for (int y = 0; y < cadena.Length; y++) {
                        if (cadena.Substring(i, 1) == cadena.Substring(y, 1)) { 
                            Contador++;    
                        }
                    }

                    listFrase[ContadorLetra] = new string[2] { cadena.Substring(i, 1).ToUpper(), Contador.ToString() };
                    Contador = 0;
                    ContadorLetra++;
                }

            }

            string[][] listFraseAux = new string[ContadorLetra][];
            for (int z = 0; z < ContadorLetra; z++)
            {
                double ContadorAux = Convert.ToDouble(listFrase[z][1]);
                double ContadorAuxLetra = cadena.Length;
                double Porcentaje = (ContadorAux / ContadorAuxLetra) * 100;
                listFraseAux[z] = new string[2] { listFrase[z][0], Porcentaje.ToString("0.00000") };
            }

            //Idioma
            String LineaIdioma = null;
            for (int i = 0; i < listFraseAux.Length; i++)
            {
                LineaIdioma = LineaIdioma + listFraseAux[i][0] + " - " + listFraseAux[i][1] + "\r\n";
                DGV_text.Rows.Add(listFraseAux[i][0], Convert.ToDouble(listFraseAux[i][1]));
                DGV_text02.Rows.Add(listFraseAux[i][0], Convert.ToDouble(listFraseAux[i][1]));
            }

            DGV_text.Sort(DGV_text.Columns["Porcentaje"], ListSortDirection.Descending);
            DGV_text02.Sort(DGV_text02.Columns["Porcentaje"], ListSortDirection.Descending);

            txt_CantidadLetrasTotal.Text = cadena.Length.ToString();
            txt_idioma.Text = LineaIdioma;
        }

        private void btn_BuscarIdioma_Click(object sender, EventArgs e)
        {
            if (txt_Frase.Text != "")
            {
                frecuencia(txt_Frase.Text);
                bigrama(txt_Frase.Text);
                trigrama(txt_Frase.Text);
            }
        }

        private void btn_Idioma_Click(object sender, EventArgs e)
        {
            double sumaIngles = 0;
            double sumaEspanol = 0;
            double sumaFrances = 0;
            double sumaAleman = 0;
            double valor01 = 0;
            double valor02 = 0;
            for (int fila = 0; fila < DGV_Ingles.Rows.Count - 1; fila++)
            {
                valor01 = 0;
                valor02 = 0;
                valor01 = Convert.ToDouble(DGV_Ingles.Rows[fila].Cells[1].Value);
                if (DGV_text02.Rows.Count - 1 > fila)
                {
                    if (!CeldaEsNull(DGV_text02.Rows[fila].Cells[1]))
                    {
                        valor02 = Convert.ToDouble(DGV_text02.Rows[fila].Cells[1].Value);
                    }
                }
                else {
                    valor02 = 0;
                }
                sumaIngles = sumaIngles + Math.Pow(valor02 - valor01, 2);
            }
            txt_sumaIngles.Text = sumaIngles.ToString();
            //Espanol
            for (int fila = 0; fila < DGV_Espanol.Rows.Count - 1; fila++)
            {
                valor01 = 0;
                valor02 = 0;
                valor01 = Convert.ToDouble(DGV_Espanol.Rows[fila].Cells[1].Value);
                if (DGV_text02.Rows.Count - 1 > fila)
                {
                    if (!CeldaEsNull(DGV_text02.Rows[fila].Cells[1]))
                    {
                        valor02 = Convert.ToDouble(DGV_text02.Rows[fila].Cells[1].Value);
                    }
                }
                else
                {
                    valor02 = 0;
                }
                sumaEspanol = sumaEspanol + Math.Pow(valor02 - valor01, 2);
            }
            txt_sumaEspanol.Text = sumaEspanol.ToString();
            //Frances
            for (int fila = 0; fila < DGV_Frances.Rows.Count - 1; fila++)
            {
                valor01 = 0;
                valor02 = 0;
                valor01 = Convert.ToDouble(DGV_Frances.Rows[fila].Cells[1].Value);
                if (DGV_text02.Rows.Count - 1 > fila)
                {
                    if (!CeldaEsNull(DGV_text02.Rows[fila].Cells[1]))
                    {
                        valor02 = Convert.ToDouble(DGV_text02.Rows[fila].Cells[1].Value);
                    }
                }
                else
                {
                    valor02 = 0;
                }
                sumaFrances = sumaFrances + Math.Pow(valor02 - valor01, 2);
            }
            txt_sumaFrances.Text = sumaFrances.ToString();
            //Aleman
            for (int fila = 0; fila < DGV_Aleman.Rows.Count - 1; fila++)
            {
                valor01 = 0;
                valor02 = 0;
                valor01 = Convert.ToDouble(DGV_Aleman.Rows[fila].Cells[1].Value);
                if (DGV_text02.Rows.Count - 1 > fila)
                {
                    if (!CeldaEsNull(DGV_text02.Rows[fila].Cells[1]))
                    {
                        valor02 = Convert.ToDouble(DGV_text02.Rows[fila].Cells[1].Value);
                    }
                }
                else
                {
                    valor02 = 0;
                }
                sumaAleman = sumaAleman + Math.Pow(valor02 - valor01, 2);
            }
            txt_sumaAleman.Text = sumaAleman.ToString();

            if (sumaIngles < sumaEspanol && sumaIngles < sumaFrances && sumaIngles < sumaAleman) 
            {
                txt_idiomaBuscar.Text = "Ingles";
            } 
            if (sumaEspanol < sumaIngles && sumaEspanol < sumaFrances && sumaEspanol < sumaAleman)
            {
                txt_idiomaBuscar.Text = "Espanol";
            }
            if (sumaFrances < sumaIngles && sumaFrances < sumaEspanol && sumaFrances < sumaAleman)
            {
                txt_idiomaBuscar.Text = "Espanol";
            }
            if (sumaAleman < sumaIngles && sumaAleman < sumaEspanol && sumaAleman < sumaFrances)
            {
                txt_idiomaBuscar.Text = "Espanol";
            }

            cargaIdiomaFrecuencia(txt_idiomaBuscar.Text);

        }

        private bool CeldaEsNull(DataGridViewCell celda)
        {
            return celda.Value == null || celda.Value == DBNull.Value || String.IsNullOrWhiteSpace(celda.Value.ToString());
        }

        private string LetraFrecuenciaAux;
        private string LetraTextoAux;

        private void btn_Descodifica_Click(object sender, EventArgs e)
        {
            string Bigrama = null;
            listBigramaEspanolAux = new string[DGV_BigramaEspanol.Rows.Count][];
            string[] listFraseBigrama1;
            string[] listFraseBigrama2;
            string[] listFraseBigramaDecodificado;

            int contadorDescodifica1 = 0;
            int contadorDescodifica2 = 0;
            int contadorDescodificaAux = 0;

            for (int i = 0; i < listBigramaEspanol.Length; i++)
            {
                Bigrama = listBigramaEspanol[i][0];
                if (Bigrama.Substring(0, 1) == LetraFrecuenciaAux) 
                {
                    contadorDescodifica1++;
                }
                if (Bigrama.Substring(1, 1) == LetraFrecuenciaAux)
                {
                    contadorDescodifica2++;
                }
            }
            listFraseBigrama1 = new string[contadorDescodifica1];
            listFraseBigrama2 = new string[contadorDescodifica2];
            contadorDescodifica1 = 0;
            contadorDescodifica2 = 0;
            for (int i = 0; i < listBigramaEspanol.Length; i++)
            {
                Bigrama = listBigramaEspanol[i][0];
                if (Bigrama.Substring(0, 1) == LetraFrecuenciaAux)
                {
                    listFraseBigrama1[contadorDescodifica1] = Bigrama;
                    contadorDescodifica1++;
                }
                if (Bigrama.Substring(1, 1) == LetraFrecuenciaAux)
                {
                    listFraseBigrama2[contadorDescodifica2] = Bigrama;
                    contadorDescodifica2++;
                }
            }
            //
            contadorDescodificaAux = 0;
            for (int i = 0; i < DGV_BigramaEspanol.Rows.Count - 1; i++)
            {
                string Value = DGV_BigramaEspanol.Rows[i].Cells[0].Value.ToString();
                if (Value.Substring(0, 1) == LetraTextoAux)
                {
                    contadorDescodificaAux++;
                }
                if (Value.Substring(1, 1) == LetraTextoAux)
                {
                    contadorDescodificaAux++;
                }
            }
            //
            listFraseBigramaDecodificado = new string[contadorDescodificaAux];
            contadorDescodificaAux = 0;
            Boolean existeBigramaHipotesis = false;
            //Bigramas
            if (DGV_BigramaHipotesis.Rows.Count - 1 != 3 && DGV_BigramaHipotesis.Rows.Count - 1 != 6)
            {
                for (int i = 0; i < DGV_BigramaEspanol.Rows.Count - 1; i++)
                {
                    string Value = DGV_BigramaEspanol.Rows[i].Cells[0].Value.ToString();
                    if (Value.Substring(0, 1) == LetraTextoAux)
                    {

                        for (int y = 0; y < listFraseBigrama1.Length; y++)
                        {
                            for (int z = 0; z < DGV_FrecuenciaAux.Rows.Count - 1; z++)
                            {

                                string ValueAux = DGV_FrecuenciaAux.Rows[z].Cells[0].Value.ToString();
                                if ((LetraFrecuenciaAux + ValueAux) == listFraseBigrama1[y] && listFraseBigrama1[y].Substring(0, 1) != ValueAux)
                                {
                                    //MessageBox.Show(LetraTextoAux + Value.Substring(1, 1) + " es " + LetraFrecuenciaAux + ValueAux );
                                    existeBigramaHipotesis = false;
                                    if (DGV_BigramaHipotesis.Rows.Count - 1 == 0)
                                    {
                                        DGV_BigramaHipotesis.Rows.Add(LetraTextoAux, LetraFrecuenciaAux);
                                    }
                                    for (int a = 0; a < DGV_BigramaHipotesis.Rows.Count - 1; a++)
                                    {
                                        string ValueBigramaHipotesis = DGV_BigramaHipotesis.Rows[a].Cells[1].Value.ToString();
                                        if (ValueBigramaHipotesis == ValueAux)
                                        {
                                            existeBigramaHipotesis = true;
                                        }
                                    }
                                    if (existeBigramaHipotesis == false)
                                    {

                                        DGV_BigramaHipotesis.Rows.Add(Value.Substring(1, 1), ValueAux);
                                        //listFraseBigramaDecodificado[contadorDescodificaAux] = LetraFrecuenciaAux + ValueAux;
                                        goto Found;


                                    }

                                }
                            }

                        }

                    }
                }
            }
            if (DGV_BigramaHipotesis.Rows.Count - 1 > 6) {
                for (int i = 0; i < DGV_BigramaEspanol.Rows.Count - 1; i++) {
                    string ValueAntes = DGV_BigramaEspanol.Rows[i].Cells[0].Value.ToString();
                    for (int a = 0; a < DGV_BigramaHipotesis.Rows.Count - 1; a++) {
                        string ValueBigramaHipotesisAntes = DGV_BigramaHipotesis.Rows[a].Cells[0].Value.ToString();
                        string ValueBigramaHipotesisDespues = DGV_BigramaHipotesis.Rows[a].Cells[1].Value.ToString();
                        if (ValueAntes.Substring(0, 1) == ValueBigramaHipotesisAntes) {
                            for (int b = 0; b < listBigramaEspanol.Length - 1; b++) {
                                string BigramaAux = listBigramaEspanol[b][0];
                                if (BigramaAux.Substring(0, 1) == ValueBigramaHipotesisDespues)
                                {
                                    for (int c = 0; c < DGV_BigramaHipotesis.Rows.Count - 1; c++)
                                    {
                                        string ValueBigramaHipotesis = DGV_BigramaHipotesis.Rows[c].Cells[1].Value.ToString();
                                        if (ValueBigramaHipotesis == BigramaAux.Substring(0, 1))
                                        {
                                            existeBigramaHipotesis = true;
                                        }
                                    }
                                    if (existeBigramaHipotesis == false)
                                    {

                                        DGV_BigramaHipotesis.Rows.Add(ValueAntes.Substring(0, 1), BigramaAux.Substring(0, 1));
                                        //listFraseBigramaDecodificado[contadorDescodificaAux] = LetraFrecuenciaAux + ValueAux;
                                        goto Found;


                                    }
                                }
                            }
                        }
                        if (ValueAntes.Substring(1, 1) == ValueBigramaHipotesisAntes)
                        {
                            for (int b = 0; b < listBigramaEspanol.Length - 1; b++)
                            {
                                string BigramaAux = listBigramaEspanol[b][0];
                                if (BigramaAux.Substring(1, 1) == ValueBigramaHipotesisDespues)
                                {
                                    for (int c = 0; c < DGV_BigramaHipotesis.Rows.Count - 1; c++)
                                    {
                                        if (DGV_BigramaHipotesis.Rows.Count - 1 > 7)
                                        {
                                            string ValueBigramaHipotesis = DGV_BigramaHipotesis.Rows[c].Cells[1].Value.ToString();
                                            if (ValueBigramaHipotesis == BigramaAux.Substring(0, 1))
                                            {
                                                existeBigramaHipotesis = true;
                                            }
                                        }
                                        else { 
                                            DGV_BigramaHipotesis.Rows.Add(ValueAntes.Substring(0, 1), BigramaAux.Substring(0, 1));
                                            //listFraseBigramaDecodificado[contadorDescodificaAux] = LetraFrecuenciaAux + ValueAux;
                                            goto Found;                                            
                                        }

                                    }
                                    if (existeBigramaHipotesis == false)
                                    {

                                        DGV_BigramaHipotesis.Rows.Add(ValueAntes.Substring(0,1), BigramaAux.Substring(0, 1));
                                        //listFraseBigramaDecodificado[contadorDescodificaAux] = LetraFrecuenciaAux + ValueAux;
                                        goto Found;


                                    }
                                    //DGV_BigramaHipotesis.Rows.Add(ValueAntes.Substring(0,1), BigramaAux.Substring(0, 1));
                                    ////listFraseBigramaDecodificado[contadorDescodificaAux] = LetraFrecuenciaAux + ValueAux;
                                    //goto Found;
                                }
                            }
                        }
                    }
                }
            }
            //Trigramas
            Boolean posicion1 = false;
            Boolean posicion2 = false;
            Boolean posicion3 = false;
            String letra1 = null;
            String letra2 = null;
            String letra3 = null;
            string Trigrama = null;
            string[] listFraseTrigrama3;
            int contadorTriDescodifica3 = 0;
            for (int i = 0; i < DGV_TrigramaEspanol.Rows.Count - 1; i++) {
                string ValueTrigrama = DGV_TrigramaEspanol.Rows[i].Cells[0].Value.ToString();
                for (int y = 0; y < DGV_BigramaHipotesis.Rows.Count - 1; y++) {
                    string ValueBigrama = DGV_BigramaHipotesis.Rows[y].Cells[0].Value.ToString();
                    string ValueBigramaDecodificado = DGV_BigramaHipotesis.Rows[y].Cells[1].Value.ToString();
                    if (ValueTrigrama.Substring(0, 1) == ValueBigrama)  {
                        letra1 = ValueBigramaDecodificado;
                        posicion1 = true;
                    }
                    if (ValueTrigrama.Substring(1, 1) == ValueBigrama)
                    {
                        letra2 = ValueBigramaDecodificado;
                        posicion2 = true;
                    }
                    if (ValueTrigrama.Substring(2, 1) == ValueBigrama)
                    {
                        letra3 = ValueBigramaDecodificado;
                        posicion3 = true;
                    }
                }
                Boolean existeprecuenciaTrigrama = false;
                Boolean existeprecuencia = false;
                if ((posicion1 == true && posicion2 == true && posicion3 == true) == false) { 
                    if (posicion3 == true)
                    {
                        for (int z = 0; z < listTrigramaEspanol.Length; z++) {
                            Trigrama = listTrigramaEspanol[z][0];
                            if (Trigrama.Substring(2, 1) == letra3)
                            {
                                existeprecuenciaTrigrama = false;
                                for (int a = 0; a < DGV_FrecuenciaAux.Rows.Count - 1; a++) {
                                    string ValueAux = DGV_FrecuenciaAux.Rows[a].Cells[0].Value.ToString();
                                    existeprecuenciaTrigrama = false;
                                    for (int b = 0; b < DGV_BigramaHipotesis.Rows.Count - 1; b++) {
                                        string ValueBigramaHipotesis = DGV_BigramaHipotesis.Rows[b].Cells[1].Value.ToString();
                                        if (ValueAux == ValueBigramaHipotesis) {
                                            existeprecuenciaTrigrama = true;
                                            break;
                                        }
                                    }
                                    if (existeprecuenciaTrigrama == false) {
                                        if (posicion3 == true) {
                                            for (int c = 0; c < listTrigramaEspanol.Length; c++) {
                                                Trigrama = listTrigramaEspanol[c][0];
                                                if (Trigrama.Substring(1, 2) == ValueAux + letra3) {
                                                    for (int d = 0; d < DGV_text.Rows.Count - 1; d++)
                                                    {
                                                        string ValueFrecuenciaAux = DGV_text.Rows[d].Cells[0].Value.ToString();
                                                        existeprecuencia = false;
                                                        for (int b = 0; b < DGV_BigramaHipotesis.Rows.Count - 1; b++)
                                                        {
                                                            string ValueBigramaHipotesis = DGV_BigramaHipotesis.Rows[b].Cells[0].Value.ToString();
                                                            if (ValueFrecuenciaAux == ValueBigramaHipotesis)
                                                            {
                                                                existeprecuencia = true;
                                                                break;
                                                            }
                                                        }
                                                        if (existeprecuencia == false) { 
                                                            DGV_BigramaHipotesis.Rows.Add(ValueFrecuenciaAux, ValueAux);
                                                            goto Found;                                                            
                                                        }
                                                    }
                                                
                                                }
                                            }
                                        }

                                    }
                                }
                                //contadorTriDescodifica3++;
                            }
                        }
                        //listFraseTrigrama3 = new string[contadorTriDescodifica3];
                        //contadorTriDescodifica3 = 0;
                        //for (int z = 0; z < listTrigramaEspanol.Length; z++)
                        //{
                        //    Trigrama = listTrigramaEspanol[z][0];
                        //    if (Trigrama.Substring(2, 1) == letra3)
                        //    {
                        //        listFraseTrigrama3[contadorTriDescodifica3] = Trigrama;
                        //        contadorTriDescodifica3++;
                        //    }
                        //}
                        //MessageBox.Show(letra1 + letra2 + letra3);
                    }
                    if (posicion2 == true && posicion3 == true) {
                        for (int z = 0; z < listTrigramaEspanol.Length; z++)
                        {
                            Trigrama = listTrigramaEspanol[z][0];
                            if (Trigrama.Substring(1, 2) == letra2 + letra3)
                            {
                                DGV_BigramaHipotesis.Rows.Add(ValueTrigrama.Substring(0, 1), Trigrama.Substring(0, 1));
                                goto Found;
                                //existeprecuenciaTrigrama = false;
                                //for (int a = 0; a < DGV_FrecuenciaAux.Rows.Count - 1; a++)
                                //{
                                //    string ValueAux = DGV_FrecuenciaAux.Rows[a].Cells[0].Value.ToString();
                                //    existeprecuenciaTrigrama = false;
                                //    for (int b = 0; b < listTrigramaEspanol.Length - 1; b++)
                                //    {
                                //        if ((ValueAux + Trigrama.Substring(1, 2)) == listTrigramaEspanol[b][0]) {
                                //            //MessageBox.Show(listTrigramaEspanol[b][0]);
                                //        }
                                //    }
                                //}
                            }
                        }
                    }

                }

                posicion1 = false;
                posicion2 = false;
                posicion3 = false;
            }
            //
            Found:
                contadorDescodificaAux++;

        }

        private void DGV_FrecuenciaAux_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNo = e.RowIndex;
            string Value = DGV_FrecuenciaAux.Rows[RowNo].Cells[0].Value.ToString();
            LetraFrecuenciaAux = Value;
        }

        private void DGV_text_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNo = e.RowIndex;
            string Value = DGV_text.Rows[RowNo].Cells[0].Value.ToString();
            LetraTextoAux = Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGV_BigramaHipotesis.Rows.Add(LetraTextoAux,LetraFrecuenciaAux);
        }
    }
}
