using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication.Domain
{
    public class ServiceProvider
    {
        public List<IService> services = new();
        public void RegisterService(IService service)
        {
            services.Add(service); 
        }
        public IService GetService<T>() where T : IService
        {
            for (int i = 0; i < services.Count; i++) {
                if (services[i] is T service)
                {
                    return service;
                }
            }
            return null;
        }
    }
}
