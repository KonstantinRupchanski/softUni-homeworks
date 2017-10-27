using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AMinerTask
{
    public class StartUp
    {
        public static void Main()
        {
            var input = File.ReadAllLines("input.txt")
                .ToArray();

            int index = 0;
            string resource = input[index++];
            var resources = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(input[index++]);

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }
                resources[resource] += quantity;

                resource = input[index++];
            }
            var resourcesOutput = new List<string>();

            foreach (var rsrc in resources)
            {
                resourcesOutput.Add($"{rsrc.Key} -> {rsrc.Value}");
            }

            File.WriteAllLines("output.txt", resourcesOutput);
        }
    }
}
