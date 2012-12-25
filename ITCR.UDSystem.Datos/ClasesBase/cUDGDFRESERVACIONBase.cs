#region Acerca de...
///////////////////////////////////////////////////////////////////////////
// Empresa:  Instituto Tecnológico de Costa Rica
// Proyecto: UDsystem
// Descripción: Clase de acceso a datos para tabla 'UDGDFRESERVACION'
// Generado por ITCR Gen v2010.0.0.0 
// Fecha: sábado, 22 de diciembre de 2012, 09:53:59 a.m.
// Dado que esta clase implementa IDispose, las clases derivadas no deben hacerlo.
///////////////////////////////////////////////////////////////////////////
#endregion


using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
//using Microsoft.SqlServer.Types;  //usarlo cuando hay tipos Geometry, Geography, HierarchiId. Está en C:\Program Files\Microsoft SQL Server\100\SDK\Assemblies\Microsoft.SqlServer.Types.dll

namespace ITCR.UDSystem.Base
{
	/// <summary>
	/// Propósito: Clase de acceso a datos para tabla 'UDGDFRESERVACION'.
	/// </summary>
	public class cUDGDFRESERVACIONBase : cBDInteraccionBase
	{
		#region Declaraciones de miembros de la clase
			private SqlDateTime		_fEC_FECHAINICIO, _fEC_FECHAFIN;
			private SqlInt32		_iD_RESERVACION;
			private SqlDateTime		_hRA_HORAFIN, _hRA_HORAINICIO;
		#endregion


		/// <summary>
		/// Propósito: Constructor de la clase.
		/// </summary>
		public cUDGDFRESERVACIONBase()
		{
			// Agregar código aquí.
		}


		/// <summary>
		/// Propósito: Método Insertar. Este método inserta una fila nueva en la base de datos.
		/// </summary>
		/// <returns>True si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>FEC_FECHAINICIO</LI>
		///		 <LI>FEC_FECHAFIN</LI>
		///		 <LI>HRA_HORAINICIO</LI>
		///		 <LI>HRA_HORAFIN</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>ID_RESERVACION</LI>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Insertar()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESERVACION_Insertar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@daFEC_FECHAINICIO", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _fEC_FECHAINICIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@daFEC_FECHAFIN", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _fEC_FECHAFIN));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@tiHRA_HORAINICIO", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _hRA_HORAINICIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@tiHRA_HORAFIN", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _hRA_HORAFIN));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_RESERVACION", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _iD_RESERVACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				_filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
				_iD_RESERVACION = Int32.Parse(cmdAEjecutar.Parameters["@iID_RESERVACION"].Value.ToString());
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFRESERVACION_Insertar' reportó el error Codigo: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESERVACIONBase::Insertar::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
			}
		}


		/// <summary>
		/// Propósito: Método Update. Actualiza una fila existente en la base de datos.
		/// </summary>
		/// <returns>True si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>ID_RESERVACION</LI>
		///		 <LI>FEC_FECHAINICIO</LI>
		///		 <LI>FEC_FECHAFIN</LI>
		///		 <LI>HRA_HORAINICIO</LI>
		///		 <LI>HRA_HORAFIN</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Actualizar()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESERVACION_Actualizar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_RESERVACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_RESERVACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@daFEC_FECHAINICIO", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _fEC_FECHAINICIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@daFEC_FECHAFIN", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _fEC_FECHAFIN));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@tiHRA_HORAINICIO", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _hRA_HORAINICIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@tiHRA_HORAFIN", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _hRA_HORAFIN));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				_filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFRESERVACION_Actualizar' reportó el error Codigo: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESERVACIONBase::Actualizar::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
			}
		}


		/// <summary>
		/// Propósito: Método Eliminar. Borra una fila en la base de datos, basado en la llave primaria.
		/// </summary>
		/// <returns>True si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>ID_RESERVACION</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Eliminar()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESERVACION_Eliminar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_RESERVACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_RESERVACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				_filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFRESERVACION_Eliminar' reportó el error Codigo: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESERVACIONBase::Eliminar::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
			}
		}


		/// <summary>
		/// Propósito: Método SELECT. Este método hace Select de una fila existente en la base de datos, basado en la llave primaria.
		/// </summary>
		/// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>ID_RESERVACION</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		///		 <LI>ID_RESERVACION</LI>
		///		 <LI>FEC_FECHAINICIO</LI>
		///		 <LI>FEC_FECHAFIN</LI>
		///		 <LI>HRA_HORAINICIO</LI>
		///		 <LI>HRA_HORAFIN</LI>
		/// </UL>
		/// Llena todas las propiedades que corresponden al campo en tabla con el valor de la fila seleccionada.
		/// </remarks>
		public override DataTable SeleccionarUno()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESERVACION_SeleccionarUno]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFRESERVACION");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_RESERVACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_RESERVACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				adapter.Fill(toReturn);
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFRESERVACION_SeleccionarUno' reportó el error Código: " + _codError);
				}

				if(toReturn.Rows.Count > 0)
				{
					_iD_RESERVACION = (Int32)toReturn.Rows[0]["ID_RESERVACION"];
					_fEC_FECHAINICIO = (DateTime)toReturn.Rows[0]["FEC_FECHAINICIO"];
					_fEC_FECHAFIN = (DateTime)toReturn.Rows[0]["FEC_FECHAFIN"];
					_hRA_HORAINICIO = (DateTime)toReturn.Rows[0]["HRA_HORAINICIO"];
					_hRA_HORAFIN = (DateTime)toReturn.Rows[0]["HRA_HORAFIN"];
				}
				return toReturn;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESERVACIONBase::SeleccionarUno::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
				adapter.Dispose();
			}
		}


		/// <summary>
		/// Propósito: Método SeleccionarTodos. Este método va a Hacer un SELECT All de tabla.
		/// </summary>
		/// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override DataTable SeleccionarTodos()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESERVACION_SeleccionarTodos]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFRESERVACION");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				adapter.Fill(toReturn);
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFRESERVACION_SeleccionarTodos' reportó el error Código: " + _codError);
				}

				return toReturn;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESERVACIONBase::SeleccionarTodos::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
				adapter.Dispose();
			}
		}


		/// <summary>
		/// Propósito: Método Buscar. Este método hace una busqueda de acuerdo con todos los campos de la tabla.
		/// </summary>
		/// <returns>DataTable si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>ID_RESERVACION</LI>
		///		 <LI>FEC_FECHAINICIO</LI>
		///		 <LI>FEC_FECHAFIN</LI>
		///		 <LI>HRA_HORAINICIO</LI>
		///		 <LI>HRA_HORAFIN</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override DataTable Buscar()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESERVACION_Buscar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFRESERVACION");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_RESERVACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_RESERVACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@daFEC_FECHAINICIO", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _fEC_FECHAINICIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@daFEC_FECHAFIN", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _fEC_FECHAFIN));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@tiHRA_HORAINICIO", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _hRA_HORAINICIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@tiHRA_HORAFIN", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _hRA_HORAFIN));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				adapter.Fill(toReturn);
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFRESERVACION_Buscar' reportó el error Código: " + _codError);
				}

				return toReturn;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESERVACIONBase::Buscar::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
				adapter.Dispose();
			}
		}


		#region Declaraciones de propiedades de la clase
		public SqlInt32 ID_RESERVACION
		{
			get
			{
				return _iD_RESERVACION;
			}
			set
			{
				SqlInt32 iD_RESERVACIONTmp = (SqlInt32)value;
				if(iD_RESERVACIONTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_RESERVACION", "ID_RESERVACION can't be NULL");
				}
				_iD_RESERVACION = value;
			}
		}


		public SqlDateTime FEC_FECHAINICIO
		{
			get
			{
				return _fEC_FECHAINICIO;
			}
			set
			{
				SqlDateTime fEC_FECHAINICIOTmp = (SqlDateTime)value;
				if(fEC_FECHAINICIOTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("FEC_FECHAINICIO", "FEC_FECHAINICIO can't be NULL");
				}
				_fEC_FECHAINICIO = value;
			}
		}


		public SqlDateTime FEC_FECHAFIN
		{
			get
			{
				return _fEC_FECHAFIN;
			}
			set
			{
				SqlDateTime fEC_FECHAFINTmp = (SqlDateTime)value;
				if(fEC_FECHAFINTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("FEC_FECHAFIN", "FEC_FECHAFIN can't be NULL");
				}
				_fEC_FECHAFIN = value;
			}
		}


		public SqlDateTime HRA_HORAINICIO
		{
			get
			{
				return _hRA_HORAINICIO;
			}
			set
			{
				SqlDateTime hRA_HORAINICIOTmp = (SqlDateTime)value;
				if(hRA_HORAINICIOTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("HRA_HORAINICIO", "HRA_HORAINICIO can't be NULL");
				}
				_hRA_HORAINICIO = value;
			}
		}


		public SqlDateTime HRA_HORAFIN
		{
			get
			{
				return _hRA_HORAFIN;
			}
			set
			{
				SqlDateTime hRA_HORAFINTmp = (SqlDateTime)value;
				if(hRA_HORAFINTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("HRA_HORAFIN", "HRA_HORAFIN can't be NULL");
				}
				_hRA_HORAFIN = value;
			}
		}
		#endregion
	}
}
