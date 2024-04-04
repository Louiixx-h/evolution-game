using System;
using System.Collections.Generic;
using UnityEngine;

namespace LuisLabs.EvolutionGame.CoreDi {
    public class ServiceLocator
    {
        private ServiceLocator() { }

        private readonly Dictionary<string, object> services = new Dictionary<string, object>();

        public static ServiceLocator Current { get; private set; }

        public static void Initiailze()
        {
            Current = new ServiceLocator();
        }

        public T Get<T>() where T : class
        {
            string key = typeof(T).Name;
            if (!services.ContainsKey(key))
            {
                Debug.LogError($"{key} not registered with {GetType().Name}");
                throw new InvalidOperationException();
            }

            return (T)services[key];
        }

        public void Register<T>(T service) where T : class
        {
            string key = typeof(T).Name;
            if (services.ContainsKey(key))
            {
                Debug.LogError($"Attempted to register service of type {key} which is already registered with the {GetType().Name}.");
                return;
            }

            services.Add(key, service);
        }

        public void Unregister<T>() where T : class
        {
            string key = typeof(T).Name;
            if (!services.ContainsKey(key))
            {
                Debug.LogError($"Attempted to unregister service of type {key} which is not registered with the {GetType().Name}.");
                return;
            }

            services.Remove(key);
        }
    }
}