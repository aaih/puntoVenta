
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
	public class DETALLEVENTA
	{
		Int32		ID_DETALLEVENTA;
		Int32		ID_VENTA_FK;
		String		ID_PRODUCTO_FK;
		Decimal		PRECIO;
		Decimal		CANTIDAD;
		Decimal		SUBTOTAL;
		String		TOTAL;
		String		CLAVEUNIDAD;
		String		CLAVESERVICIO;
        String      CLAVE;
        String      DESCRIPCION;


        public String descripcion
        {
            get { return this.DESCRIPCION; }
            set { this.DESCRIPCION = value; }
        }
        public String clave
        {
            get { return this.CLAVE; }
            set { this.CLAVE = value; }
        }

		public Int32 id_detalleventa
		{
			get { return this.ID_DETALLEVENTA; }
			set { this.ID_DETALLEVENTA = value;}
		}

		public Int32 id_venta_fk
		{
			get { return this.ID_VENTA_FK; }
			set { this.ID_VENTA_FK = value;}
		}

		public String id_producto_fk
		{
			get { return this.ID_PRODUCTO_FK; }
			set { this.ID_PRODUCTO_FK = value;}
		}

		public Decimal precio
		{
			get { return this.PRECIO; }
			set { this.PRECIO = value;}
		}

		public Decimal cantidad
		{
			get { return this.CANTIDAD; }
			set { this.CANTIDAD = value;}
		}

		public Decimal subtotal
		{
			get { return this.SUBTOTAL; }
			set { this.SUBTOTAL = value;}
		}

		public String total
		{
			get { return this.TOTAL; }
			set { this.TOTAL = value;}
		}

		public String claveunidad
		{
			get { return this.CLAVEUNIDAD; }
			set { this.CLAVEUNIDAD = value;}
		}

		public String claveservicio
		{
			get { return this.CLAVESERVICIO; }
			set { this.CLAVESERVICIO = value;}
		}

	}

	public static class metodos_DETALLEVENTA
	{
        public static void eliminarVENTA(Int32 id_venta)
        {
            String Qry = "DELETE FROM detalleventa WHERE id_detalleVenta=@id_venta";
            BaseDatos d = new BaseDatos();
            d.Conectar();
            d.CrearComando(Qry);
            d.AsignarParametroEntero("@id_venta", id_venta);

            d.EjecutarComando();
            d.Desconectar();
        }

        public static void insertarDETALLEVENTA(Int32 id_detalleventa, Int32 id_venta_fk, String id_producto_fk, Decimal precio, Decimal cantidad, Decimal subtotal, Decimal total, String claveunidad, String claveservicio, String clave, String descripcion, Decimal descuento)
		{
			String Qry = @"INSERT INTO detalleventa(id_detalleVenta,id_Venta_fk,id_producto_fk,precio,cantidad,subtotal,total,claveUnidad,claveServicio,clave,descripcion,descuento)
values(@id_detalleventa,@id_venta_fk,@id_producto_fk,@precio,@cantidad,@subtotal,@total,@claveunidad,@claveservicio,@clave,@descripcion,@descuento )";
			BaseDatos d = new BaseDatos();
			d.Conectar();
			d.CrearComando(Qry);
			d.AsignarParametroEntero("@id_detalleventa",id_detalleventa);
			d.AsignarParametroEntero("@id_venta_fk",id_venta_fk);
			d.AsignarParametroCadena("@id_producto_fk",id_producto_fk);
			d.AsignarParametroDecimal("@precio",precio);
			d.AsignarParametroDecimal("@cantidad",cantidad);
			d.AsignarParametroDecimal("@subtotal",subtotal);
            d.AsignarParametroDecimal("@total", total);
            d.AsignarParametroDecimal("@descuento", descuento);
            d.AsignarParametroCadena("@claveunidad",claveunidad);
			d.AsignarParametroCadena("@claveservicio",claveservicio);
            d.AsignarParametroCadena("@clave", clave);
            d.AsignarParametroCadena("@descripcion", descripcion);
			d.EjecutarComando();
            d.Desconectar();

        }

        public static void actualizarDETALLEVENTA(Int32 id_detalleventa, Int32 id_venta_fk, String id_producto_fk, Decimal precio, Decimal cantidad, Decimal subtotal, String total, String claveunidad, String claveservicio)
		{
			String Qry = "UPDATE detalleventa SET id_detalleVenta = @id_detalleVenta, id_Venta_fk = @id_Venta_fk, id_producto_fk = @id_producto_fk, precio = @precio, cantidad = @cantidad, subtotal = @subtotal, total = @total, claveUnidad = @claveUnidad, claveServicio = @claveServic WHERE ID=@ID";
			BaseDatos d = new BaseDatos();
			d.Conectar();
			d.CrearComando(Qry);
			d.AsignarParametroEntero("@id_detalleventa",id_detalleventa);
			d.AsignarParametroEntero("@id_venta_fk",id_venta_fk);
			d.AsignarParametroCadena("@id_producto_fk",id_producto_fk);
			d.AsignarParametroDecimal("@precio",precio);
			d.AsignarParametroDecimal("@cantidad",cantidad);
			d.AsignarParametroDecimal("@subtotal",subtotal);
			d.AsignarParametroCadena("@total",total);
			d.AsignarParametroCadena("@claveunidad",claveunidad);
			d.AsignarParametroCadena("@claveservicio",claveservicio);

			d.EjecutarComando();
            d.Desconectar();

        }

        public  static List<DETALLEVENTA>  seleccionarDETALLEVENTA(Int32 idVenta)
		{
			List<DETALLEVENTA> listDETALLEVENTA = new List<DETALLEVENTA>();
            String Qry = @"SELECT id_detalleVenta, id_Venta_fk, id_producto_fk, precio, cantidad, subtotal, total, claveUnidad, claveServicio,clave,descripcion  FROM detalleventa WHERE id_Venta_fk=@ID";
			BaseDatos d = new BaseDatos();
			d.Conectar();
			d.CrearComando(Qry);
            d.AsignarParametroEntero("@ID", idVenta);
			DbDataReader datosItems = d.EjecutarConsulta();
			while(datosItems.Read())
			{
				DETALLEVENTA objDETALLEVENTA = new DETALLEVENTA();
				objDETALLEVENTA.id_detalleventa = Convert.ToInt32(datosItems["id_detalleventa"].ToString());
				objDETALLEVENTA.id_venta_fk = Convert.ToInt32(datosItems["id_venta_fk"].ToString());
				objDETALLEVENTA.id_producto_fk = datosItems["id_producto_fk"].ToString();
				objDETALLEVENTA.precio = Convert.ToDecimal(datosItems["precio"].ToString());
				objDETALLEVENTA.cantidad = Convert.ToDecimal(datosItems["cantidad"].ToString());
				objDETALLEVENTA.subtotal = Convert.ToDecimal(datosItems["subtotal"].ToString());
				objDETALLEVENTA.total = datosItems["total"].ToString();
				objDETALLEVENTA.claveunidad = datosItems["claveunidad"].ToString();
				objDETALLEVENTA.claveservicio = datosItems["claveservicio"].ToString();

                objDETALLEVENTA.clave = datosItems["clave"].ToString();
                objDETALLEVENTA.descripcion = datosItems["descripcion"].ToString();
				listDETALLEVENTA.Add( objDETALLEVENTA);
			}
            datosItems.Close();
            d.Desconectar();

            return listDETALLEVENTA; 
		}
	}
}