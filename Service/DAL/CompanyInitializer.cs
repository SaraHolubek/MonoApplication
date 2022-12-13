using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Service.Models;
using System.Diagnostics;

namespace Service.DAL
{
    public class CompanyInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            var vehicles = new List<VehicleMake>
            {
            new VehicleMake {VehicleName="Audi",VehicleAbrv=("Aud")},
            new VehicleMake {VehicleName="BMW",VehicleAbrv=("Bmw")},
            new VehicleMake {VehicleName="Renault",VehicleAbrv=("Ren")},
            new VehicleMake {VehicleName="Citroen",VehicleAbrv=("Cit")},
            new VehicleMake {VehicleName="Mazda",VehicleAbrv=("Maz")},
            new VehicleMake {VehicleName="Mercedes",VehicleAbrv=("Mer")},
            new VehicleMake {VehicleName="Honda",VehicleAbrv=("Hon")},
            new VehicleMake {VehicleName="Fiat",VehicleAbrv=("Fia")},
            new VehicleMake {VehicleName="Toyota",VehicleAbrv=("Toy")},
            new VehicleMake {VehicleName="Hyundai",VehicleAbrv=("Hyu")}

            };

            vehicles.ForEach(s => context.VehicleMakes.Add(s));
            context.SaveChanges();
            var courses = new List<VehicleModel>
            {
            new VehicleModel{ModelID=1050,ModelName="A5"},
            new VehicleModel{ModelID=1050,ModelName="A6"},
            new VehicleModel{ModelID=1050,ModelName="A3"},
            new VehicleModel{ModelID=1050,ModelName="A2"},
            new VehicleModel{ModelID=1051,ModelName="X5"},
            new VehicleModel{ModelID=1051,ModelName="X6"},
            new VehicleModel{ModelID=1051,ModelName="M4"},
            new VehicleModel{ModelID=1051,ModelName="i3"},
            new VehicleModel{ModelID=1051,ModelName="X1"},
            new VehicleModel{ModelID=1051,ModelName="X7"},
            new VehicleModel{ModelID=1051,ModelName="Z3"},
            new VehicleModel{ModelID=1052,ModelName="X7"},
            new VehicleModel{ModelID=1052,ModelName="Talisman"},
            new VehicleModel{ModelID=1052,ModelName="Laguna"},
            new VehicleModel{ModelID=1052,ModelName="Clio"},
            new VehicleModel{ModelID=1052,ModelName="Master"},
            new VehicleModel{ModelID=1052,ModelName="Thalia"},
            new VehicleModel{ModelID=1052,ModelName="Twingo"},
            new VehicleModel{ModelID=1053,ModelName="Berlingo"},
            new VehicleModel{ModelID=1053,ModelName="Picasso"},
            new VehicleModel{ModelID=1053,ModelName="Nemo"},
            new VehicleModel{ModelID=1053,ModelName="Xsara"},
            new VehicleModel{ModelID=1053,ModelName="C5"},
            new VehicleModel{ModelID=1053,ModelName="C3"},
            new VehicleModel{ModelID=1054,ModelName="2"},
            new VehicleModel{ModelID=1054,ModelName="3"},
            new VehicleModel{ModelID=1054,ModelName="5"},
            new VehicleModel{ModelID=1054,ModelName="6"},
            new VehicleModel{ModelID=1054,ModelName="626"},
            new VehicleModel{ModelID=1055,ModelName="Citan"},
            new VehicleModel{ModelID=1055,ModelName="CLC"},
            new VehicleModel{ModelID=1055,ModelName="123"},
            new VehicleModel{ModelID=1055,ModelName="124"},
            new VehicleModel{ModelID=1055,ModelName="180"},
            new VehicleModel{ModelID=1056,ModelName="Accord"},
            new VehicleModel{ModelID=1056,ModelName="Civic"},
            new VehicleModel{ModelID=1056,ModelName="Jazz"},
            new VehicleModel{ModelID=1056,ModelName="Prelude"},
            new VehicleModel{ModelID=1056,ModelName="Insight"},
            new VehicleModel{ModelID=1057,ModelName="Croma"},
            new VehicleModel{ModelID=1057,ModelName="Brava"},
            new VehicleModel{ModelID=1057,ModelName="Doblo"},
            new VehicleModel{ModelID=1057,ModelName="Ducato"},
            new VehicleModel{ModelID=1057,ModelName="Uno"},
            new VehicleModel{ModelID=1057,ModelName="Sedici"},
            new VehicleModel{ModelID=1058,ModelName="Auris"},
            new VehicleModel{ModelID=1058,ModelName="Aygo"},
            new VehicleModel{ModelID=1058,ModelName="Corolla"},
            new VehicleModel{ModelID=1058,ModelName="Prius"},
            new VehicleModel{ModelID=1058,ModelName="Verso"},
            new VehicleModel{ModelID=1058,ModelName="Yaris"},
            new VehicleModel{ModelID=1059,ModelName="Accent"},
            new VehicleModel{ModelID=1059,ModelName="Equus"},
            new VehicleModel{ModelID=1059,ModelName="Matrix"},
            new VehicleModel{ModelID=1059,ModelName="Trajet"},
            new VehicleModel{ModelID=1059,ModelName="Tucson"},


            };
            courses.ForEach(s => context.VehicleModels.Add(s));
            context.SaveChanges();
            var enrollments = new List<Registration>
            {
            new Registration{RegID=1,VehicleID=1050},
            new Registration{RegID=2,VehicleID=1051},
            new Registration{RegID=3,VehicleID=1052},
            new Registration{RegID=4,VehicleID=1053},
            new Registration{RegID=5,VehicleID=1054},
            new Registration{RegID=6,VehicleID=1055},
            new Registration{RegID=1,VehicleID=1056},
            new Registration{RegID=1,VehicleID=1057},
            new Registration{RegID=1,VehicleID=1058},
            new Registration{RegID=1,VehicleID=1059},

            };
            enrollments.ForEach(s => context.Registrations.Add(s));
            context.SaveChanges();
        }
    }
}