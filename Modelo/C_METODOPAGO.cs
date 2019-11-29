
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por la herramienta Generador de clases SQL.
//     Versión de runtime:4.0.30319.34209
//
//     Desarrollado por Ismael Almaraz Armeaga
//     ismaelalmaraz@live.com.mx
// </auto-generated>
//------------------------------------------------------------------------------
                            
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using AccesoDatos;
namespace Modelo
{
	public class C_METODOPAGO
	{
		String		CMETODOPAGO;
		String		DESCRIPCION;

		public String c_metodopago
		{
            get { return this.CMETODOPAGO; }
            set { this.CMETODOPAGO = value; }
		}

		public String descripcion
		{
			get { return this.DESCRIPCION; }
			set { this.DESCRIPCION = value;}
		}

	}

	public static class metodos_C_METODOPAGO
	{

        public static void insertarC_METODOPAGO(String c_metodopago, String descripcion)
		{
			String Qry =@"INSERT INTO C_METODOPAGO(c_metodopago,descripcion)
values(
@c_metodopago,@descripci )";
			BaseDatos d = new BaseDatos();
			d.Conectar();
			d.CrearComando(Qry);
			d.AsignarParametroCadena("@c_metodopago",c_metodopago);
			d.AsignarParametroCadena("@descripcion",descripcion);

			d.EjecutarComando();
            d.Desconectar();

        }

        public static void actualizarC_METODOPAGO(String c_metodopago, String descripcion)
		{
			String Qry ="UPDATE C_METODOPAGO SET c_metodopago = @c_metodopago, descripcion = @descripci WHERE ID=@ID";
			BaseDatos d = new BaseDatos();
			d.Conectar();
			d.CrearComando(Qry);
			d.AsignarParametroCadena("@c_metodopago",c_metodopago);
			d.AsignarParametroCadena("@descripcion",descripcion);

			d.EjecutarComando();
            d.Desconectar();

        }

        public  static List<C_METODOPAGO>  seleccionarC_METODOPAGO()
		{
			List<C_METODOPAGO> listC_METODOPAGO = new List<C_METODOPAGO>();
            String Qry = @"SELECT c_metodopago, descripcion  FROM c_metodopago  order by c_metodopago";
			BaseDatos d = new BaseDatos();
			d.Conectar();
			d.CrearComando(Qry);
			DbDataReader datosItems = d.EjecutarConsulta();
			while(datosItems.Read())
			{
				C_METODOPAGO objC_METODOPAGO = new C_METODOPAGO();
				objC_METODOPAGO.c_metodopago = datosItems["c_metodopago"].ToString();
				objC_METODOPAGO.descripcion = datosItems["c_metodopago"].ToString() + "-" +datosItems["descripcion"].ToString();
				listC_METODOPAGO.Add( objC_METODOPAGO);
			}
            datosItems.Close();
            d.Desconectar();
            return listC_METODOPAGO; 
		}
	}
}