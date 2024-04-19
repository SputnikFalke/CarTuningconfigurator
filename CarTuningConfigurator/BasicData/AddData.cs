using CarTuningConfigurator.Contorller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTuningConfigurator.BasicData
{
    internal class AddData
    {
        AdminController adminController = new AdminController();
        public AddData() 
        {
            addCar();
            addEngines();
            addChipTunning();
            addBrake();
            addBodywork();
            addTires();
            addTransmission();
            addWeightReduction();
            addTurbo();
            addWings();
        }

        public void addEngines()
        {
            adminController.addTunningPart("V10", "Engine", 50, 0, 0, 250, 40, -0.6, 25000, 2);
            adminController.addTunningPart("V8", "Engine", 25, 0, 0, 150, 20, -0.2, 6000, 3);
            adminController.addTunningPart("W16", "Engine", 100, 0, 0, 400, 75, -1, 800000, 1);
        }
        public void addWings()
        {
            adminController.addTunningPart("little Wing", "Wing", 0, 0, 0.5, 30, 3, 0, 800, 3);
            adminController.addTunningPart("optimized Wing", "Wing", 0, 0, 1, 35, 7, 0, 3000, 2);
            adminController.addTunningPart("carbon Superwing", "Wing", 0, 0, 3, 40, 15, 0, 6000, 1);
        }
        public void addBrake()
        {
            adminController.addTunningPart("normal Brake", "Breaks", 0, 1, 0, 15, 0, 0, 3000, 3);
            adminController.addTunningPart("racing Brake", "Breaks", 0, 2.5, 0, 20, 0, 0, 8500, 2);
            adminController.addTunningPart("Formular 1 Brake", "Breaks", 0, 4, 0, 23, 0, 0, 31000, 1);
        }
        public void addTurbo()
        {
            adminController.addTunningPart("single Turbo", "Turbo", 120, 0, 0, 70, 25, -0.3, 4000, 3);
            adminController.addTunningPart("Twinturbo", "Turbo", 310, 0, 0, 120, 35, -0.6, 11000, 2);
            adminController.addTunningPart("Supercharger", "Turbo", 600, 0, 0, 300, 55, -1, 86000, 1);
        }
        public void addTransmission()
        {
            adminController.addTunningPart("6 Gang", "Transmission", 0, 0, 0, 500, 10, -0.2, 500, 3);
            adminController.addTunningPart("8 Gang", "Transmission", 0, 0, 0, 600, 20, -0.5, 2500, 2);
            adminController.addTunningPart("10 Gang", "Transmission", 0, 0, 0, 700, 30, -0.8, 12000, 1);
        }
        public void addTires()
        {
            adminController.addTunningPart("cheap Tires", "Tires", 0, 0.2, 0.2, 3, 0, 0.1, 100, 3);
            adminController.addTunningPart("racing Tires", "Tires", 0, 0.7, 0.7, 12, 0, 0.3, 700, 2);
            adminController.addTunningPart("Super Soft", "Tires", 0, 1, 1, 10, 0, 0.7, 1200, 1);
        }
        public void addWeightReduction()
        {
            adminController.addTunningPart("min.Reduction", "WeightReduction", 0, 0, 0, -45, 0, 0, 200, 3);
            adminController.addTunningPart("nor.Reduction", "WeightReduction", 0, 0, 0, -75, 0, 0, 700, 2);
            adminController.addTunningPart("max.Reduction", "WeightReduction", 0, 0, 0, -120, 0, 0, 3500, 1);
        }
        public void addChipTunning()
        {
            adminController.addTunningPart("cheap Chip", "Chiptuning", 0, 0, 0, 0, 15, -0.2, 200, 3);
            adminController.addTunningPart("normal Chip", "Chiptuning", 0, 0, 0, 0, 23, -0.4, 500, 2);
            adminController.addTunningPart("crazy Chip", "Chiptuning", 0, 0, 0, 0, 33, -0.6, 10000, 1);
        }
        public void addBodywork()
        {
            adminController.addTunningPart("min.Carbon", "Bodywork", 0, 0, 0, -20, 0, 0, 2000, 3);
            adminController.addTunningPart("nor.Carbon", "Bodywork", 0, 0, 0, -45, 0, 0, 5000, 2);
            adminController.addTunningPart("max.Carbon", "Bodywork", 0, 0, 0, -65, 0, 0, 15000, 1);
        }
        public void addCar()
        {
            adminController.addCar("GTR", "Nissan", "https://carsguide-res.cloudinary.com/image/upload/f_auto%2Cfl_lossy%2Cq_auto%2Ct_default/v1/editorial/review/hero_image/2022-Nissan-GT-R-T-Spec-Coupe-Grey-Joel-Strickland-1001x565.jpg", "https://th.bing.com/th/id/R.0d0f1ef1c4c2edefa059aee17e569b20?rik=%2fF3kC1zUwiA43w&riu=http%3a%2f%2fder-autotester.de%2fwp-content%2fuploads%2f2016%2f03%2f144062_1_5-2-e1458751145161.jpg&ehk=96XFSchCXyMtGOKxq%2bKwmUf5%2blesdybvgAjeDlVDUl0%3d&risl=&pid=ImgRaw&r=0", 300, 3, 2.5, 1800, 280, 5.4, 50000, false, null);
            adminController.addCar("R8", "Audi", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Will_Stevens_Audi_R8_LMS.jpg/440px-Will_Stevens_Audi_R8_LMS.jpg", "https://th.bing.com/th/id/R.8a23788cccd2cab9bea97015107b7753?rik=VdocXU6ztgMhoQ&pid=ImgRaw&r=0", 500, 4, 3, 1500, 330, 4.4, 300000, false, null);
            adminController.addCar("Senna", "McLaren", "https://cdn.motor1.com/images/mgl/1l48X/s1/2018-mclaren-senna-prototype.jpg", "https://img3.wallspic.com/previews/2/3/8/7/5/157832/157832-senna_vorne-mclaren_senna-car-sportwagen-mclaren-x750.jpg", 850, 6, 5, 1200, 360, 3.7, 12000000, false, null);
        }
    }
}
