using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evaluacion_sistema
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=DESKTOP-EJTT724\\SQLEXPRESS;Database=evaluacionPrimavera;Trusted_Connection=True;";
        private List<Alumno> alumnos;

        public Form1()
        {
            InitializeComponent();
            alumnos = new List<Alumno>();
            CargarAlumnosDesdeBaseDeDatos();
        }

        private void CargarAlumnosDesdeBaseDeDatos()
        {
            alumnos.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Alumnos";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Alumno alumno = new Alumno
                    {
                        ID = reader["ID"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"])
                    };
                    alumnos.Add(alumno);
                }
            }
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (alumnos.Any(a => a.ID == txtID.Text))
                {
                    MessageBox.Show("el id que ingreso ya existe, porfavor ingrese otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Alumno nuevoAlumno = new Alumno
                    {
                        ID = txtID.Text,
                        Nombre = txtNAME.Text,
                        Apellido = txtAPELLIDO.Text,
                        FechaNacimiento = dtpFECHA.Value
                    };
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO Alumnos (ID, Nombre, Apellido, FechaNacimiento) VALUES (@ID, @Nombre, @Apellido, @FechaNacimiento)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID", nuevoAlumno.ID);
                        command.Parameters.AddWithValue("@Nombre", nuevoAlumno.Nombre);
                        command.Parameters.AddWithValue("@Apellido", nuevoAlumno.Apellido);
                        command.Parameters.AddWithValue("@FechaNacimiento", nuevoAlumno.FechaNacimiento);
                        command.ExecuteNonQuery();
                    }
                    CargarAlumnosDesdeBaseDeDatos();
                    LimpiarCampos();
                    MessageBox.Show("el alumno ha sido agregado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }           
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                var alumno = alumnos.FirstOrDefault(a => a.ID == txtID.Text);
                if (alumno != null)
                {
                    alumno.Nombre = txtNAME.Text;
                    alumno.Apellido = txtAPELLIDO.Text;
                    alumno.FechaNacimiento = dtpFECHA.Value;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Alumnos SET Nombre = @Nombre, Apellido = @Apellido, FechaNacimiento = @FechaNacimiento WHERE ID = @ID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID", alumno.ID);
                        command.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                        command.Parameters.AddWithValue("@Apellido", alumno.Apellido);
                        command.Parameters.AddWithValue("@FechaNacimiento", alumno.FechaNacimiento);
                        command.ExecuteNonQuery();

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0);
                    }
                    CargarAlumnosDesdeBaseDeDatos();
                    LimpiarCampos();
                    MessageBox.Show("el alumno ha sido actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("el id no ha sido encontrado, ingrese otro porfavor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtID.Text))
            {
                var alumno = alumnos.FirstOrDefault(a => a.ID == txtID.Text);
                if (alumno != null)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Alumnos WHERE ID = @ID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID", alumno.ID);
                        command.ExecuteNonQuery();

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0);
                    }
                    CargarAlumnosDesdeBaseDeDatos();
                    LimpiarCampos();
                    MessageBox.Show("el alumno ha sido eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("el id no ha sido encontrado, ingrese otro porfavor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("por favor, ingrese un ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNAME.Clear();
            txtAPELLIDO.Clear();
            dtpFECHA.Value = DateTime.Now;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("ingrese un id porfavor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNAME.Text))
            {
                MessageBox.Show("ingrese un nombre porfavor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAPELLIDO.Text))
            {
                MessageBox.Show("ingrese un apellido porfavor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtpFECHA.Value >= DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento debe ser anterior a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }


    public class Alumno
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}

