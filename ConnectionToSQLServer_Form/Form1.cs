using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ConnectionToSQLServer_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //primero va la clase que le agg y luego va el nombre de nuestro metodo q contiene la conexion a sql server
            Conexion.Conectar();
            MessageBox.Show("Successful Connection");

            //lamamos los datos
            dataGridView1.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            //codigo para mostrar datos de la base a c# datagriew
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "Select * from contactos3;";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            //IdPersona es Autoincrement
            Conexion.Conectar();
            string insertar = "insert into contactos3(ID,Alias,Apellidos,Nombre,Direccion,Poblacion,Telefono,Movil,Email,Observaciones,Sexo,FechaNacimiento,EstadoCivil,Hijos,Desempleado,Profesion,NivelAcademico,LenguaUsual,IngresosMensuales,Ahorros,PesoKg,Altura,Cabello,Ojos,Fumador,Salud,Afición1,Afición2,Caracteristica1,Caracteristica2,Valora1,Valora2,Fobias,Sexualidad,Disponible) values(@ID,@Alias,@Apellidos,@Nombre,@Direccion,@Poblacion,@Telefono,@Movil,@Email,@Observaciones,@Sexo,@FechaNacimiento,@EstadoCivil,@Hijos,@Desempleado,@Profesion,@NivelAcademico,@LenguaUsual,@IngresosMensuales,@Ahorros,@PesoKg,@Altura,@Cabello,@Ojos,@Fumador,@Salud,@Aficion1,@Aficion2,@Caracteristica1,@Caracteristica2,@Valora1,@Valora2,@Fobias,@Sexualidad,@Disponible)";
            SqlCommand cmd1 = new SqlCommand(insertar,Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@ID", textid.Text);
            cmd1.Parameters.AddWithValue("@Alias", textalias.Text);
            cmd1.Parameters.AddWithValue("@Apellidos", textapellido.Text);
            cmd1.Parameters.AddWithValue("@Nombre", textnombre.Text);
            cmd1.Parameters.AddWithValue("@Direccion", textdireccion.Text);
            cmd1.Parameters.AddWithValue("@Poblacion", textpoblacion.Text);
            cmd1.Parameters.AddWithValue("@Telefono", texttelefono.Text);
            cmd1.Parameters.AddWithValue("@Movil", textmovil.Text);
            cmd1.Parameters.AddWithValue("@Email", textemail.Text);
            cmd1.Parameters.AddWithValue("@Observaciones", textobservaciones.Text);
            cmd1.Parameters.AddWithValue("@Sexo", textsexo.Text);
            cmd1.Parameters.AddWithValue("@FechaNacimiento", textfechanacimiento.Text);
            cmd1.Parameters.AddWithValue("@EstadoCivil", textestadocivil.Text);
            cmd1.Parameters.AddWithValue("@Hijos", texthijos.Text);
            cmd1.Parameters.AddWithValue("@Desempleado", textdesempleado.Text);
            cmd1.Parameters.AddWithValue("@Profesion", textprofesion.Text);
            cmd1.Parameters.AddWithValue("@NivelAcademico", textnivelacademico.Text);
            cmd1.Parameters.AddWithValue("@LenguaUsual", textlenguausual.Text);
            cmd1.Parameters.AddWithValue("@IngresosMensuales", textingresosmensuales.Text);
            cmd1.Parameters.AddWithValue("@Ahorros", textahorros.Text);
            cmd1.Parameters.AddWithValue("@PesoKg", textpesokg.Text);
            cmd1.Parameters.AddWithValue("@Altura", textaltura.Text);
            cmd1.Parameters.AddWithValue("@Cabello", textcabello.Text);
            cmd1.Parameters.AddWithValue("@Ojos", textojos.Text);
            cmd1.Parameters.AddWithValue("@Fumador", textfumador.Text);
            cmd1.Parameters.AddWithValue("@Salud", txtSalud.Text);
            cmd1.Parameters.AddWithValue("@Aficion1", txtAficion.Text);
            cmd1.Parameters.AddWithValue("@Aficion2", txtAf2.Text);
            cmd1.Parameters.AddWithValue("@Caracteristica1", txtca1.Text);
            cmd1.Parameters.AddWithValue("@Caracteristica2", txtcara2.Text);
            cmd1.Parameters.AddWithValue("@Valora1", txtva1.Text);
            cmd1.Parameters.AddWithValue("@Valora2", txtva2.Text);
            cmd1.Parameters.AddWithValue("@Fobias", textfobia.Text);
            cmd1.Parameters.AddWithValue("@Sexualidad", txtSexualidad.Text);
            cmd1.Parameters.AddWithValue("@Disponible", txtDisponible.Text);


            cmd1.ExecuteNonQuery();
            MessageBox.Show("Successful Aggregation");
            dataGridView1.DataSource = llenar_grid();
        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                textid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textalias.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textapellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textnombre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textdireccion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textpoblacion.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                texttelefono.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textmovil.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textemail.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textobservaciones.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textsexo.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                textfechanacimiento.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                textestadocivil.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                texthijos.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                textdesempleado.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                textprofesion.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                textnivelacademico.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                textlenguausual.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                textingresosmensuales.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
                textahorros.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
                textpesokg.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
                textaltura.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
                textcabello.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
                textojos.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
                textfumador.Text = dataGridView1.CurrentRow.Cells[24].Value.ToString();
                txtSalud.Text = dataGridView1.CurrentRow.Cells[25].Value.ToString();
                txtAficion.Text = dataGridView1.CurrentRow.Cells[26].Value.ToString();
                txtAf2.Text = dataGridView1.CurrentRow.Cells[27].Value.ToString();
                txtca1.Text = dataGridView1.CurrentRow.Cells[28].Value.ToString();
                txtcara2.Text = dataGridView1.CurrentRow.Cells[29].Value.ToString();
                txtva1.Text = dataGridView1.CurrentRow.Cells[30].Value.ToString();
                txtva2.Text = dataGridView1.CurrentRow.Cells[31].Value.ToString();
                textfobia.Text = dataGridView1.CurrentRow.Cells[32].Value.ToString();
                txtSexualidad.Text = dataGridView1.CurrentRow.Cells[33].Value.ToString();
                txtDisponible.Text = dataGridView1.CurrentRow.Cells[34].Value.ToString();
            }

            catch 
            { 
                
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "update contactos3 set ID=@ID,Alias=@Alias,Apellidos=@Apellidos,Nombre=@Nombre,Direccion=@Direccion,Poblacion=@Poblacion,Telefono=@Telefono,Movil=@Movil,Email=@Email,Observaciones=@Observaciones,Sexo=@Sexo,FechaNacimiento=@FechaNacimiento,EstadoCivil=@EstadoCivil,Hijos=@Hijos,Desempleado=@Desempleado,Profesion=@Profesion,NivelAcademico=@NivelAcademico,LenguaUsual=@LenguaUsual,IngresosMensuales=@IngresosMensuales,Ahorros=@Ahorros,PesoKg=@PesoKg,Altura=@Altura,Cabello=@Cabello,Ojos=@Ojos,Fumador=@Fumador,Salud=@Salud,Afición1=@Aficion1,Afición2=@Aficion2,Caracteristica1=@Caracteristica1,Caracteristica2=@Caracteristica2,Valora1=@Valora1,Valora2=@Valora2,Fobias=@Fobias,Sexualidad=@Sexualidad,Disponible=@Disponible where ID=@ID";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
            cmd2.Parameters.AddWithValue("@ID", textid.Text);
            cmd2.Parameters.AddWithValue("@Alias", textalias.Text);
            cmd2.Parameters.AddWithValue("@Apellidos", textapellido.Text);
            cmd2.Parameters.AddWithValue("@Nombre", textnombre.Text);
            cmd2.Parameters.AddWithValue("@Direccion", textdireccion.Text);
            cmd2.Parameters.AddWithValue("@Poblacion", textpoblacion.Text);
            cmd2.Parameters.AddWithValue("@Telefono", texttelefono.Text);
            cmd2.Parameters.AddWithValue("@Movil", textmovil.Text);
            cmd2.Parameters.AddWithValue("@Email", textemail.Text);
            cmd2.Parameters.AddWithValue("@Observaciones", textobservaciones.Text);
            cmd2.Parameters.AddWithValue("@Sexo", textsexo.Text);
            cmd2.Parameters.AddWithValue("@FechaNacimiento", textfechanacimiento.Text);
            cmd2.Parameters.AddWithValue("@EstadoCivil", textestadocivil.Text);
            cmd2.Parameters.AddWithValue("@Hijos", texthijos.Text);
            cmd2.Parameters.AddWithValue("@Desempleado", textdesempleado.Text);
            cmd2.Parameters.AddWithValue("@Profesion", textprofesion.Text);
            cmd2.Parameters.AddWithValue("@NivelAcademico", textnivelacademico.Text);
            cmd2.Parameters.AddWithValue("@LenguaUsual", textlenguausual.Text);
            cmd2.Parameters.AddWithValue("@IngresosMensuales", textingresosmensuales.Text);
            cmd2.Parameters.AddWithValue("@Ahorros", textahorros.Text);
            cmd2.Parameters.AddWithValue("@PesoKg", textpesokg.Text);
            cmd2.Parameters.AddWithValue("@Altura", textaltura.Text);
            cmd2.Parameters.AddWithValue("@Cabello", textcabello.Text);
            cmd2.Parameters.AddWithValue("@Ojos", textojos.Text);
            cmd2.Parameters.AddWithValue("@Fumador", textfumador.Text);
            cmd2.Parameters.AddWithValue("@Salud", txtSalud.Text);
            cmd2.Parameters.AddWithValue("@Aficion1", txtAficion.Text);
            cmd2.Parameters.AddWithValue("@Aficion2", txtAf2.Text);
            cmd2.Parameters.AddWithValue("@Caracteristica1", txtca1.Text);
            cmd2.Parameters.AddWithValue("@Caracteristica2", txtcara2.Text);
            cmd2.Parameters.AddWithValue("@Valora1", txtva1.Text);
            cmd2.Parameters.AddWithValue("@Valora2", txtva2.Text);
            cmd2.Parameters.AddWithValue("@Fobias", textfobia.Text);
            cmd2.Parameters.AddWithValue("@Sexualidad", txtSexualidad.Text);
            cmd2.Parameters.AddWithValue("@Disponible", txtDisponible.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Successful modification");
            dataGridView1.DataSource = llenar_grid();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "Delete from contactos3 where ID=@ID";
            SqlCommand cmd3 = new SqlCommand(eliminar,Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@ID", textid.Text);
            cmd3.ExecuteNonQuery();
            MessageBox.Show("Successful Removal");
            dataGridView1.DataSource = llenar_grid();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            textid.Clear();
            textalias.Clear();
            textapellido.Clear();
            textnombre.Clear();
            textdireccion.Clear();
            textpoblacion.Clear();
            texttelefono.Clear();
            textmovil.Clear();
            textemail.Clear();
            textobservaciones.Clear();
            textsexo.Clear();
            textfechanacimiento.Clear();
            textestadocivil.Clear();
            texthijos.Clear();
            textdesempleado.Clear();
            textprofesion.Clear();
            textnivelacademico.Clear();
            textlenguausual.Clear();
            textingresosmensuales.Clear();
            textahorros.Clear();
            textpesokg.Clear();
            textaltura.Clear();
            textcabello.Clear();
            textojos.Clear();
            textfumador.Clear();
            txtSalud.Clear();
            txtAficion.Clear();
            txtAf2.Clear();
            txtca1.Clear();
            txtcara2.Clear();
            txtva1.Clear();
            txtva2.Clear();
            textfobia.Clear();
            txtSexualidad.Clear();
            txtDisponible.Clear();
        }
    }
}
