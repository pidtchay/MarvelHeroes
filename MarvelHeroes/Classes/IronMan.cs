﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelHeroes.Interfaces;
using Ninject;

namespace MarvelHeroes.Classes
{
    public class IronMan : IUltimateAvenger
    {
        private IArmor _armor;

        private IArmor Armor
        {
            get
            {
                if (_armor == null)
                {
                    _armor = Program.AppKernel.Get<IArmor>("Mark_I");
                }
                return _armor;
            }
        }

        public void UseWeapon() => Armor.UseWeapon();

        public void UseWeapon(int wType) => Armor.UseWeapon(wType);

        public void UseUltimateWeapon() => Armor.UseUltimateWeapon();

        public void UseUltimateWeapon(int wType) => Armor.UseUltimateWeapon(wType);

        public void UseGadget() => Armor.UseGadget();

        public void WearArmor() => Armor.WearArmor();

        public void RemoveArmor() => Armor.RemoveArmor();

        public void SplitArmor() => Armor.SplitArmor();

        public string GetArmorName() => Armor.ArmorName;
    }
}
