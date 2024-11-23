﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();

            lblSumCapatiy.Text = db.Location.Sum(x => x.Capacity).ToString();

            lblGuideCount.Text = db.Guide.Count().ToString();
            
            lblAvgCapacity.Text = db.Location.Average(x => x.Capacity).ToString();
            
            lblAvgLocationPrice.Text = string.Format("{0:0.00} ₺", db.Location.Average(x => x.Price));
            
            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountrName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();
            
            lblCapadociaLocationCapaticty.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            
            lblTurkiyeCapatictyAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();
            
            var romeGuideId = db.Location.Where(x => x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();
            
            var maxCapaticty = db.Location.Max(x => x.Capacity);
            lblMaxCapatictyLocation.Text = db.Location.Where(x => x.Capacity == maxCapaticty).Select(y => y.City).FirstOrDefault().ToString();
            
            var maxPrice = db.Location.Max(x => x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();
            
            var guideIdByNameAysegulCinar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblAysegulCinarLocationCount.Text = db.Location.Where(x => x.GuideId == guideIdByNameAysegulCinar).Count().ToString();
        }
    }
}