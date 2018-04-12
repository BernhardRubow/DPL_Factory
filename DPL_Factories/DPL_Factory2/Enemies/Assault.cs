using System;

namespace DPL_Factory2.Enemies
{
    public class Assault : IEnemy
    {
        private string _name;

        public string Name => _name;

        public Assault(string name)
        {
            _name = name;
        }

        public void SetName(string name)
        {
            if(name == "") throw new ArgumentException("Name is required");
            _name = name;
        }

        public void Attack()
        {
            Console.WriteLine($"The {_name} fires his deadly tachyon twin lasers");
        }

        public void Die()
        {
            Console.WriteLine($"The {_name} explodes.");
        }
    }
}