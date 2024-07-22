using AvaloinaApplication.Domain;
using AvaloniaApplication.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication.ViewModels
{
    public class ComponentsViewModel : ViewModelBase
    {
        private ServiceProvider _serviceProvider;
        private int myvalue = 10;
        public string Value { get => myvalue.ToString(); set { myvalue = int.Parse(value); OnEntityUpdated(nameof(Value)); } }
        public ComponentsViewModel(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            MemoryService memoryService = (MemoryService)serviceProvider.GetService<MemoryService>();
            //memoryService.EntityUpdated += OnEntityUpdated;
        }

        private void OnEntityUpdated(string propertyName)
        {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
