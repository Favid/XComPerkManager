﻿using OfficeOpenXml;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XcomPerkManager
{
    public class XComAbilityListReader
    {
        private ExcelPackage package;

        private const int ROW_START = 2;

        private const int COLUMN_INTERNAL_NAME = 1;
        private const int COLUMN_DISPLAY_NAME = 2;
        private const int COLUMN_DESCRIPTION = 3;
        private const int COLUMN_WEAPON_SLOT = 4;
        private const int COLUMN_REQUIRED_MOD = 5;

        public XComAbilityListReader()
        {
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(currentDir);
            DirectoryInfo root = directory.Parent.Parent; // TODO make this read same file as tool instead of a copy
            FileInfo excelFile = new FileInfo(Path.Combine(root.FullName, "XComAbilityList.xlsx"));

            package = new ExcelPackage(excelFile);
        }

        public List<Ability> read()
        {
            List<Ability> abilities = new List<Ability>();
            List<string> duplicateAbilityInternalNames = new List<string>();

            ExcelWorksheet workSheet = package.Workbook.Worksheets.First();
            
            for (int row = ROW_START; row <= workSheet.Dimension.End.Row; row++)
            {
                Ability ability = new Ability();
                ability.internalName = workSheet.Cells[row, COLUMN_INTERNAL_NAME].Value.ToString();
                ability.displayName = workSheet.Cells[row, COLUMN_DISPLAY_NAME].Value.ToString();
                ability.description = workSheet.Cells[row, COLUMN_DESCRIPTION].Value.ToString();
                ability.weaponSlot = getWeaponSlotFromExcel(workSheet.Cells[row, COLUMN_WEAPON_SLOT].Value.ToString());
                ability.requiredMod = workSheet.Cells[row, COLUMN_REQUIRED_MOD].Value.ToString();

                if(abilities.Where(x => x.internalName.Equals(ability.internalName)).Count() > 0)
                {
                    duplicateAbilityInternalNames.Add(ability.internalName);
                }

                abilities.Add(ability);
            }

            if(duplicateAbilityInternalNames.Count() > 0)
            {
                Console.WriteLine("Duplicate ability names found:");

                foreach(string name in duplicateAbilityInternalNames)
                {
                    Console.WriteLine(name);
                }
            }
            
            return abilities.OrderBy(x => x.internalName).ToList();
        }

        public void addAbility(Ability ability)
        {
            List<Ability> singletonList = new List<Ability>();
            singletonList.Add(ability);
            addAbilities(singletonList);
        }

        public void addAbilities(List<Ability> abilities)
        {
            ExcelWorksheet workSheet = package.Workbook.Worksheets.First();
            
            int insertionRow = workSheet.Dimension.End.Row + 1;
            foreach (Ability ability in abilities)
            {
                workSheet.Cells[insertionRow, COLUMN_INTERNAL_NAME].Value = ability.internalName;
                workSheet.Cells[insertionRow, COLUMN_DISPLAY_NAME].Value = ability.displayName;
                workSheet.Cells[insertionRow, COLUMN_DESCRIPTION].Value = ability.description;
                workSheet.Cells[insertionRow, COLUMN_WEAPON_SLOT].Value = ability.weaponSlot.ToString();
                workSheet.Cells[insertionRow, COLUMN_REQUIRED_MOD].Value = ability.requiredMod;
                
                insertionRow++;
            }

            package.Save();
        }
        
        private WeaponSlot getWeaponSlotFromExcel(string excelValue)
        {
            switch(excelValue)
            {
                case "None":
                    return WeaponSlot.None;

                case "Unknown":
                    return WeaponSlot.Unknown;

                case "Primary":
                    return WeaponSlot.Primary;

                case "Secondary":
                    return WeaponSlot.Secondary;
            }

            return WeaponSlot.None;
        }
    }
}