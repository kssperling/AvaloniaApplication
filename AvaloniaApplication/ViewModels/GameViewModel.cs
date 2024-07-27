using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaloniaApplication.Domain;

namespace AvaloniaApplication.ViewModels
{
    public class GameViewModel
    {
        private ServiceProvider _serviceProvider;
        public GameViewModel(ServiceProvider serviceProvider) 
        {
            _serviceProvider = serviceProvider;
            MemoryService service = (MemoryService)serviceProvider.GetService<MemoryService>();
            service.UpdateEntity(new AvaloinaApplication.Domain.Entity() { value = 24 });



              
        }
    }
}
