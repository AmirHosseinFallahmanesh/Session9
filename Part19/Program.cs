using System;
using System.Collections.ObjectModel;

namespace Part19
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> obs = new ObservableCollection<string>();
            obs.CollectionChanged += Obs_CollectionChanged;
            while (true)
            {
                obs.Add(Console.ReadLine());
            }
        }

        private static void Obs_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("List Changed");
        }
    }
}
