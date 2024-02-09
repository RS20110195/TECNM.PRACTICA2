using System.ComponentModel;
using TecNM.Practica2.Core.Entities;
//using TecNM.Practica2.Core.Enums;
using TecNM.Practica2.Core.Services.Interfaces;

namespace TecNM.Practica2.Core.Services;

public class BmiService : IBmiService{

    public Bmi ProcessBmi(Person person){
            var bmi = new Bmi();
            double GT = 9.81;
            double GM = 3.711;

            bmi.Index = ((person.Weight / Convert.ToSingle(GT)) * Convert.ToSingle(GM));

            
            return bmi;
    }

}