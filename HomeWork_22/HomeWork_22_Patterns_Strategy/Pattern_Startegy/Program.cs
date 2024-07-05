using Pattern_Startegy;
using Pattern_Startegy.Strategies;

Hero hero = new Hero("Squidward");

hero.Attack();

hero.SetWeapon(new Broom()); // переключение оружия

hero.Attack();

hero.SetWeapon(new Plunger());

hero.Attack();