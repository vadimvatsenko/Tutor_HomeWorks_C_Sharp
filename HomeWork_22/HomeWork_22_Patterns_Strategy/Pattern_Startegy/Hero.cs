﻿using Pattern_Startegy.Strategies;



namespace Pattern_Startegy
{
    public class Hero
    {
        private readonly string _name;
        public IWeapon? _weapon;

        public Hero(string name)
        {
            _name = name;
        }

        public void SetWeapon(IWeapon weapon)  => _weapon = weapon;
        
        public void Attack()
        {
            Console.WriteLine(">>>>>");
            if (_weapon == null) 
            {
                Console.WriteLine($"{_name} can`t attack");
                return;
            }

            Console.WriteLine($"{_name} stand menacingly");
            Console.Write($"{_name}");

            _weapon.Shoot();

            Console.WriteLine($"{_name} ceases to stand menacingly");
        }
    }

    
}
