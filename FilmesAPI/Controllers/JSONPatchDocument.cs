using FilmesAPI.Data.Dtos;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FilmesAPI.Controllers
{
    public class JSONPatchDocument<T>
    {
        internal void ApplyTo(UpdateFilmeDto filmeParaAtualizar, ModelStateDictionary modelState)
        {
            throw new NotImplementedException();
        }
    }
}