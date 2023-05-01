using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using ModelBinderProvidersModelValidationsCoreMVC6.Models;

namespace ModelBinderProvidersModelValidationsCoreMVC6.CustomModelBinders
{
  public class PersonBinderProvider : IModelBinderProvider
  {
    public IModelBinder? GetBinder(ModelBinderProviderContext context)
    {
      if (context.Metadata.ModelType == typeof(Person))
      {
        return new BinderTypeModelBinder(typeof(PersonModelBinder));
      }
      return null;
    }
  }
}
