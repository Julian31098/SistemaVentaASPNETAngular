using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;// Agregamos la unica referencia

namespace SistemaVenta.DAL.Repositorios.Contrato
{
    //Escribimos todos los metodos para trabajar directamente con nuestros modelos
    //Se ecuentran en la capa model
    //Contrato 
    public interface IGenericRepository<TModel>where TModel : class
    {
        Task<TModel>Obtener(Expression<Func<TModel,bool>>filtro);
        Task<TModel> Crear(TModel modelo);
        Task<bool> Editar(TModel model);
        Task<bool> Eliminar(TModel model);
        Task<IQueryable<TModel>> consultar(Expression<Func<TModel, bool>> filtro = null);
    }
}
