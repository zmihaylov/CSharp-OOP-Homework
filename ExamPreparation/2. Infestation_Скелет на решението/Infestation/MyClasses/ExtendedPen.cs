using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation.MyClasses
{
    public class ExtendedPen : HoldingPen
    {
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "AggressionCatalyst":
                    {
                        var inhibitor = new AggressionCatalyst();
                        var unit = this.GetUnit(commandWords[2]);
                        unit.AddSupplement(inhibitor);
                        break;
                    }
                case "HealthCatalyst":
                    {
                        var inhibitor = new HealthCatalyst();
                        var unit = this.GetUnit(commandWords[2]);
                        unit.AddSupplement(inhibitor);
                        break;
                    }
                case "PowerCatalyst":
                    {
                        var inhibitor = new PowerCatalyst();
                        var unit = this.GetUnit(commandWords[2]);
                        unit.AddSupplement(inhibitor);
                        break;
                    }
                case "Weapon":
                    {
                        var inhibitor = new Weapon();
                        var unit = this.GetUnit(commandWords[2]);
                        unit.AddSupplement(inhibitor);
                        break;
                    }
                default:
                    base.ExecuteAddSupplementCommand(commandWords);
                    break;
            }
            
        }

        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Tank":
                    var tank = new Tank(commandWords[2]);
                    this.InsertUnit(tank);
                    break;
                case "Marine":
                    var marine = new Marine(commandWords[2]);
                    this.InsertUnit(marine);
                    break;
                case "Parasite":
                    var parasite = new Parasite(commandWords[2]);
                    this.InsertUnit(parasite);
                    break;
                case "Queen":
                    var quenn = new Queen(commandWords[2]);
                    this.InsertUnit(quenn);
                    break;
                default:
                    base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }
            
        }

        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            switch (interaction.InteractionType)
            {
                case InteractionType.Infest:
                    var targetUnit = this.GetUnit(interaction.TargetUnit);
                    targetUnit.AddSupplement(new InfestationSpores());
                    break;
                default:
                    base.ProcessSingleInteraction(interaction);
                    break;
            }
            
        }
    }
}
