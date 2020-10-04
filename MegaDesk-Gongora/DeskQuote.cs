using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Gongora
{
    class DeskQuote
    {
       private Desk desk;
        public String customerName {get; set; }
        public String quoteDate { get; set; }
       private int productionDays;
        private double deskBasePrice = 200;
        private double drawersCost = 50;
        private double drawersTotalCost;
        private double desktopSurfaceArea;
        private double surfaceAreaAdditionalCost = 0;
        private double surfaceAdditionalCostPerInch = 1;
        private double surfaceMaterialCost;
        private double desktopTotalCost;
        private const double SURFACE_AREA_LIMIT = 1000;
        private const double DESK_SIZE_LIMIT_ONE = 1000;
        private const double DESK_SIZE_LIMIT_TWO = 2000;
        private int normalProductionTime = 14;
        private double rushOrderCost = 0;
        private double[,] rushOrderAdditionalCosts = new double[3, 4] {
            {3, 60, 70, 80},
            {5, 40, 50, 60},
            {7, 30, 35, 40}
        };
       public DeskQuote(int width, int depth, int numberOfDrawers, String surfaceMaterial, int productionDays, String customerName, String quoteDate)
        {
            desk = new Desk(width, depth, numberOfDrawers, surfaceMaterial);
            this.productionDays = productionDays;
            this.customerName = customerName;
            this.quoteDate = quoteDate;
        }
        
        public double calcTotalCost()
        {
            desktopSurfaceArea = desk.width * desk.depth;
            drawersTotalCost = drawersCost * desk.numberOfDrawers;

            if (desktopSurfaceArea > SURFACE_AREA_LIMIT)
            {
                surfaceAreaAdditionalCost = (desktopSurfaceArea % SURFACE_AREA_LIMIT) * surfaceAdditionalCostPerInch;
            }

            switch (desk.surfaceMaterial)
            {
                case "Oak":
                    surfaceMaterialCost = (double)DesktopMaterial.Oak;
                    
                    break;

                case "Laminate":
                    surfaceMaterialCost = (double)DesktopMaterial.Laminate;
                    break;

                case "Pine":
                    surfaceMaterialCost = (double)DesktopMaterial.Pine;
                    break;

                case "Rosewood":
                    surfaceMaterialCost = (double)DesktopMaterial.Rosewood;
                    break;

                case "Veneer":
                    surfaceMaterialCost = (double)DesktopMaterial.Veneer;
                    break;
            }

            if (productionDays < normalProductionTime)
            {
                switch (productionDays)
                {
                    case 3:
                        if (desktopSurfaceArea < DESK_SIZE_LIMIT_ONE)
                        {
                            rushOrderCost = rushOrderAdditionalCosts[0, 2];
                        }
                        else if (desktopSurfaceArea >= DESK_SIZE_LIMIT_ONE && desktopSurfaceArea <= DESK_SIZE_LIMIT_TWO)
                        {
                            rushOrderCost = rushOrderAdditionalCosts[0, 3];
                        }
                        else if (desktopSurfaceArea > DESK_SIZE_LIMIT_TWO)
                        {
                            rushOrderCost = rushOrderAdditionalCosts[0, 4];
                        }
                        break;

                    case 5:
                        if (desktopSurfaceArea < DESK_SIZE_LIMIT_ONE)
                        {
                            rushOrderCost = rushOrderAdditionalCosts[1, 2];
                        }
                        else if (desktopSurfaceArea >= DESK_SIZE_LIMIT_ONE && desktopSurfaceArea <= DESK_SIZE_LIMIT_TWO)
                        {
                            rushOrderCost = rushOrderAdditionalCosts[1, 3];
                        }
                        else if (desktopSurfaceArea > DESK_SIZE_LIMIT_TWO)
                        {
                            rushOrderCost = rushOrderAdditionalCosts[1, 4];
                        }
                        break;

                    case 7:
                        if (desktopSurfaceArea < DESK_SIZE_LIMIT_ONE)
                        {
                            rushOrderCost = rushOrderAdditionalCosts[2, 2];
                        }
                        else if (desktopSurfaceArea >= DESK_SIZE_LIMIT_ONE && desktopSurfaceArea <= DESK_SIZE_LIMIT_TWO)
                        {
                            rushOrderCost = rushOrderAdditionalCosts[2, 3];
                        }
                        else if (desktopSurfaceArea > DESK_SIZE_LIMIT_TWO)
                        {
                            rushOrderCost = rushOrderAdditionalCosts[2, 4];
                        }
                        break;
                }
            }
            desktopTotalCost = deskBasePrice + surfaceMaterialCost + drawersTotalCost + surfaceAreaAdditionalCost + rushOrderCost;
            return desktopTotalCost;
         }

        public int getNoOfDrawers()
        {
            return desk.numberOfDrawers;
        }

        public double getSurfaceArea()
        {
            return desktopSurfaceArea = desk.width * desk.depth;
        }

        public double getDrawersCost()
        {
            return drawersTotalCost = drawersCost * desk.numberOfDrawers;
        }

        public double getRushOrderAdditionalCost()
        {
            if (desktopSurfaceArea > SURFACE_AREA_LIMIT)
            {
                return surfaceAreaAdditionalCost = (desktopSurfaceArea % SURFACE_AREA_LIMIT) * surfaceAdditionalCostPerInch;
            }
            return surfaceAreaAdditionalCost;
        }

        public int getProductionDays()
        {
            return productionDays;
        }

        public String getSurfaceMaterial()
        {
            return desk.surfaceMaterial;
        }

    }

}
