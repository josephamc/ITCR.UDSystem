#region Acerca de...
///////////////////////////////////////////////////////////////////////////
// Empresa:  Instituto Tecnológico de Costa Rica
// Proyecto: UDsystem
// Descripción: Clase de acceso a datos para tabla 'UDGDFINSTALACION'
// Generado por ITCR Gen v2010.0.0.0 
// Fecha: Tuesday, December 25, 2012, 4:20:01 PM
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
	/// Propósito: Clase de acceso a datos para tabla 'UDGDFINSTALACION'.
	/// </summary>
	public class cUDGDFINSTALACIONBase : cBDInteraccionBase
	{
		#region Declaraciones de miembros de la clase
			private SqlInt32		_iD_INSTALACION;
			private SqlString		_nOM_INSTALACION, _dSC_INSTALACION, _dSC_MEDIDAS, _tXT_COMENTARIO, _tXT_REGLAMENTO, _tXT_COSTOALQUILER;
		#endregion


		/// <summary>
		/// Propósito: Constructor de la clase.
		/// </summary>
		public cUDGDFINSTALACIONBase()
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
		///		 <LI>NOM_INSTALACION</LI>
		///		 <LI>DSC_INSTALACION</LI>
		///		 <LI>DSC_MEDIDAS</LI>
		///		 <LI>TXT_COMENTARIO. May be SqlString.Null</LI>
		///		 <LI>TXT_REGLAMENTO</LI>
		///		 <LI>TXT_COSTOALQUILER</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>ID_INSTALACION</LI>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Insertar()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFINSTALACION_Insertar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sNOM_INSTALACION", SqlDbType.VarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nOM_INSTALACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sDSC_INSTALACION", SqlDbType.VarChar, 700, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dSC_INSTALACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sDSC_MEDIDAS", SqlDbType.VarChar, 300, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dSC_MEDIDAS));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_COMENTARIO", SqlDbType.VarChar, 100, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _tXT_COMENTARIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_REGLAMENTO", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tXT_REGLAMENTO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_COSTOALQUILER", SqlDbType.VarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tXT_COSTOALQUILER));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_INSTALACION", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _iD_INSTALACION));
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
				_iD_INSTALACION = Int32.Parse(cmdAEjecutar.Parameters["@iID_INSTALACION"].Value.ToString());
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFINSTALACION_Insertar' reportó el error Codigo: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFINSTALACIONBase::Insertar::Ocurrió un error." + ex.Message, ex);
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
		///		 <LI>ID_INSTALACION</LI>
		///		 <LI>NOM_INSTALACION</LI>
		///		 <LI>DSC_INSTALACION</LI>
		///		 <LI>DSC_MEDIDAS</LI>
		///		 <LI>TXT_COMENTARIO. May be SqlString.Null</LI>
		///		 <LI>TXT_REGLAMENTO</LI>
		///		 <LI>TXT_COSTOALQUILER</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Actualizar()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFINSTALACION_Actualizar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_INSTALACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_INSTALACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sNOM_INSTALACION", SqlDbType.VarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nOM_INSTALACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sDSC_INSTALACION", SqlDbType.VarChar, 700, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dSC_INSTALACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sDSC_MEDIDAS", SqlDbType.VarChar, 300, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dSC_MEDIDAS));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_COMENTARIO", SqlDbType.VarChar, 100, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _tXT_COMENTARIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_REGLAMENTO", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tXT_REGLAMENTO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_COSTOALQUILER", SqlDbType.VarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tXT_COSTOALQUILER));
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
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFINSTALACION_Actualizar' reportó el error Codigo: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFINSTALACIONBase::Actualizar::Ocurrió un error." + ex.Message, ex);
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
		///		 <LI>ID_INSTALACION</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Eliminar()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFINSTALACION_Eliminar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_INSTALACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_INSTALACION));
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
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFINSTALACION_Eliminar' reportó el error Codigo: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFINSTALACIONBase::Eliminar::Ocurrió un error." + ex.Message, ex);
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
		///		 <LI>ID_INSTALACION</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		///		 <LI>ID_INSTALACION</LI>
		///		 <LI>NOM_INSTALACION</LI>
		///		 <LI>DSC_INSTALACION</LI>
		///		 <LI>DSC_MEDIDAS</LI>
		///		 <LI>TXT_COMENTARIO</LI>
		///		 <LI>TXT_REGLAMENTO</LI>
		///		 <LI>TXT_COSTOALQUILER</LI>
		/// </UL>
		/// Llena todas las propiedades que corresponden al campo en tabla con el valor de la fila seleccionada.
		/// </remarks>
		public override DataTable SeleccionarUno()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFINSTALACION_SeleccionarUno]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFINSTALACION");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_INSTALACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_INSTALACION));
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
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFINSTALACION_SeleccionarUno' reportó el error Código: " + _codError);
				}

				if(toReturn.Rows.Count > 0)
				{
					_iD_INSTALACION = (Int32)toReturn.Rows[0]["ID_INSTALACION"];
					_nOM_INSTALACION = (string)toReturn.Rows[0]["NOM_INSTALACION"];
					_dSC_INSTALACION = (string)toReturn.Rows[0]["DSC_INSTALACION"];
					_dSC_MEDIDAS = (string)toReturn.Rows[0]["DSC_MEDIDAS"];
					_tXT_COMENTARIO = toReturn.Rows[0]["TXT_COMENTARIO"] == System.DBNull.Value ? SqlString.Null : (string)toReturn.Rows[0]["TXT_COMENTARIO"];
					_tXT_REGLAMENTO = (string)toReturn.Rows[0]["TXT_REGLAMENTO"];
					_tXT_COSTOALQUILER = (string)toReturn.Rows[0]["TXT_COSTOALQUILER"];
				}
				return toReturn;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFINSTALACIONBase::SeleccionarUno::Ocurrió un error." + ex.Message, ex);
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
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFINSTALACION_SeleccionarTodos]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFINSTALACION");
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
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFINSTALACION_SeleccionarTodos' reportó el error Código: " + _codError);
				}

				return toReturn;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFINSTALACIONBase::SeleccionarTodos::Ocurrió un error." + ex.Message, ex);
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
		///		 <LI>ID_INSTALACION</LI>
		///		 <LI>NOM_INSTALACION</LI>
		///		 <LI>DSC_INSTALACION</LI>
		///		 <LI>DSC_MEDIDAS</LI>
		///		 <LI>TXT_COMENTARIO. May be SqlString.Null</LI>
		///		 <LI>TXT_REGLAMENTO</LI>
		///		 <LI>TXT_COSTOALQUILER</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override DataTable Buscar()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFINSTALACION_Buscar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFINSTALACION");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_INSTALACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_INSTALACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sNOM_INSTALACION", SqlDbType.VarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nOM_INSTALACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sDSC_INSTALACION", SqlDbType.VarChar, 700, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dSC_INSTALACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sDSC_MEDIDAS", SqlDbType.VarChar, 300, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dSC_MEDIDAS));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_COMENTARIO", SqlDbType.VarChar, 100, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _tXT_COMENTARIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_REGLAMENTO", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tXT_REGLAMENTO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_COSTOALQUILER", SqlDbType.VarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tXT_COSTOALQUILER));
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
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFINSTALACION_Buscar' reportó el error Código: " + _codError);
				}

				return toReturn;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFINSTALACIONBase::Buscar::Ocurrió un error." + ex.Message, ex);
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
		public SqlInt32 ID_INSTALACION
		{
			get
			{
				return _iD_INSTALACION;
			}
			set
			{
				SqlInt32 iD_INSTALACIONTmp = (SqlInt32)value;
				if(iD_INSTALACIONTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_INSTALACION", "ID_INSTALACION can't be NULL");
				}
				_iD_INSTALACION = value;
			}
		}


		public SqlString NOM_INSTALACION
		{
			get
			{
				return _nOM_INSTALACION;
			}
			set
			{
				SqlString nOM_INSTALACIONTmp = (SqlString)value;
				if(nOM_INSTALACIONTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("NOM_INSTALACION", "NOM_INSTALACION can't be NULL");
				}
				_nOM_INSTALACION = value;
			}
		}


		public SqlString DSC_INSTALACION
		{
			get
			{
				return _dSC_INSTALACION;
			}
			set
			{
				SqlString dSC_INSTALACIONTmp = (SqlString)value;
				if(dSC_INSTALACIONTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("DSC_INSTALACION", "DSC_INSTALACION can't be NULL");
				}
				_dSC_INSTALACION = value;
			}
		}


		public SqlString DSC_MEDIDAS
		{
			get
			{
				return _dSC_MEDIDAS;
			}
			set
			{
				SqlString dSC_MEDIDASTmp = (SqlString)value;
				if(dSC_MEDIDASTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("DSC_MEDIDAS", "DSC_MEDIDAS can't be NULL");
				}
				_dSC_MEDIDAS = value;
			}
		}


		public SqlString TXT_COMENTARIO
		{
			get
			{
				return _tXT_COMENTARIO;
			}
			set
			{
				_tXT_COMENTARIO = value;
			}
		}


		public SqlString TXT_REGLAMENTO
		{
			get
			{
				return _tXT_REGLAMENTO;
			}
			set
			{
				SqlString tXT_REGLAMENTOTmp = (SqlString)value;
				if(tXT_REGLAMENTOTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("TXT_REGLAMENTO", "TXT_REGLAMENTO can't be NULL");
				}
				_tXT_REGLAMENTO = value;
			}
		}


		public SqlString TXT_COSTOALQUILER
		{
			get
			{
				return _tXT_COSTOALQUILER;
			}
			set
			{
				SqlString tXT_COSTOALQUILERTmp = (SqlString)value;
				if(tXT_COSTOALQUILERTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("TXT_COSTOALQUILER", "TXT_COSTOALQUILER can't be NULL");
				}
				_tXT_COSTOALQUILER = value;
			}
		}
		#endregion
	}
}
