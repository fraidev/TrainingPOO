using System.Collections.Generic;

namespace TrainingPOO.CompositionAndAggregation.Domains
{
    public class Computer:IBroke
    {
        public MotherBoard MotherBoard {get;set;}
        public CPU Cpu {get;set;}
        public IList<RamMemory> RamMemorys {get;set;}
        public IList<HardDriver> HardDrivers {get;set;}
        public bool Works { get; set; }


        public void Broke()
        {
            Works = false;
            MotherBoard.Broke();
            Cpu.Broke();
            foreach(var ramMemory in RamMemorys){
                ramMemory.Broke();
            }
            foreach(var hardDriver in HardDrivers){
                hardDriver.Broke();
            }
        }
    }
}