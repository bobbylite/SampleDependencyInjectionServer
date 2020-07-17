using DependencyInjectionApp.Model;
using DependencyInjectionApp.Common;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace DependencyInjectionApp.Services
{
    public class SortingService : IAutoStart
    {
        private readonly ILogger<SortingService> _logger;
        private readonly List<SortableObject> _sortableList;
        private readonly SortableObject _sortableObject1;
        private readonly SortableObject _sortableObject2;
        private readonly SortableObject _sortableObject3;
        private readonly SortableObject _sortableObject4;
        private readonly SortableObject _sortableObject5;

        public SortingService(ILogger<SortingService> logger)
        {
            _logger = logger; 

            _sortableObject1 = new SortableObject
            {
                Name = "Rob's Object",
                Value = 12
            };

            _sortableObject2 = new SortableObject
            {
                Name = "Steve's Object",
                Value = 1
            };

            _sortableObject3 = new SortableObject
            {
                Name = "Maria's Object",
                Value = 4
            };

            _sortableObject4 = new SortableObject
            {
                Name = "Robert Senior's Object",
                Value = 8
            };

            _sortableObject5 = new SortableObject
            {
                Name = "Nikki's Object",
                Value = 5
            };

            _sortableList = new List<SortableObject>
            {
                _sortableObject1,
                _sortableObject2,
                _sortableObject3,
                _sortableObject4,
                _sortableObject5
            };
        }

        public void Start()
        {
            foreach(SortableObject item in _sortableList)
            {
                _logger.LogInformation($"Name: {item.Name} - Value: {item.Value}");
            }

            _logger.LogInformation("Sorting.......");
            _sortableList.Sort();

            foreach(SortableObject item in _sortableList)
            {
                _logger.LogInformation($"Name: {item.Name} - Value: {item.Value}");
            }
        }

        public void Stop()
        {
            _logger.LogInformation("Sorting Service Stopped.");
        }
    }
}