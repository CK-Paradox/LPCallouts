using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Rage;

namespace LPCallouts.Externals
{
    public class ModelDef
    {
        public class ModelStrings
        {
            public int Location;
            public string Ped1 { get; set; }
            public string Ped2 { get; set; }
            public string Ped3 { get; set; }
            public string Ped4 { get; set; }
            public string Ped5 { get; set; }
            public string Vehicle1 { get; set; }
            public string Vehicle2 { get; set; }
            public string Vehicle3 { get; set; }
            public string Vehicle4 { get; set; }
            public string Vehicle5 { get; set; }
            public ModelStrings()
            {

            }
            public ModelStrings(int _Location, string _Ped1, string _Ped2, string _Ped3, string _Ped4, string _Ped5, string _Vehicle1, string _Vehicle2, string _Vehicle3, string _Vehicle4, string _Vehicle5)
            {
                Location = _Location;
                Ped1 = _Ped1;
                Ped2 = _Ped2;
                Ped3 = _Ped3;
                Ped4 = _Ped4;
                Ped5 = _Ped5;
                Vehicle1 = _Vehicle1;
                Vehicle2 = _Vehicle2;
                Vehicle3 = _Vehicle3;
                Vehicle4 = _Vehicle4;
                Vehicle5 = _Vehicle5;
            }
        }

        [Serializable]
        public class ModelDefinition
        {
            public ModelDefinition()
            {

            }

            public List<ModelStrings> CyclistScene = new List<ModelStrings>();
            public List<ModelStrings> DrifterScene = new List<ModelStrings>();
            public List<ModelStrings> TruckCrash = new List<ModelStrings>();
            public List<ModelStrings> CornerCut = new List<ModelStrings>();
            public List<ModelStrings> Freeway = new List<ModelStrings>();
            public List<ModelStrings> BeachScene = new List<ModelStrings>();
            public List<ModelStrings> RunOver = new List<ModelStrings>();
            public List<ModelStrings> MissingPerson = new List<ModelStrings>();
        }

        public static void LoadModelStrings()
        {
            try
            {
                XmlSerializer _xml_serializer = new XmlSerializer(typeof(ModelDefinition), new XmlRootAttribute("LPCModels"));
                string _gtapath = Environment.CurrentDirectory;
                string _filename = "LPCModelDef.xml";
                string _location = Path.Combine(_gtapath, "plugins", "LSPDFR", _filename);

                using (FileStream _in = File.Open(_location, System.IO.FileMode.Open))
                {
                    Main.model_def = (ModelDefinition)_xml_serializer.Deserialize(_in);
                }
            }
            catch(Exception ex)
            {
                Game.DisplayNotification("~r~LPCallouts~w~ xml file error: ~y~ModelDefintions~w~ could not be loaded from XML File");
                Game.LogTrivial(ex.ToString());
            }
        }

        public static void InitList()
        {
            #region List Assist Drifter
            Main.model_def.DrifterScene.AddRange(new List<ModelStrings>
            {
                    new ModelStrings
                    (
                        1,
                        "s_m_y_cop_01",
                        "s_m_y_cop_01",
                        "s_m_m_paramedic_01",
                        "Not used",
                        "Not used",
                        "POLICE2",
                        "AMBULANCE",
                        "Not used",
                        "Not used",
                        "Not used"
                        ),
                    new ModelStrings
                    (
                        2,
                        "s_m_y_sheriff_01",
                        "s_f_y_sheriff_01",
                        "s_m_m_paramedic_01",
                        "Not used",
                        "Not used",
                        "SHERIFF2",
                        "AMBULANCE",
                        "Not used",
                        "Not used",
                        "Not used"
                        ),
                       new ModelStrings
                    (
                        3,
                        "s_f_y_cop_01",
                        "s_m_y_cop_01",
                        "s_m_m_paramedic_01",
                        "Not used",
                        "Not used",
                        "SHERIFF2",
                        "AMBULANCE",
                        "Not used",
                        "Not used",
                        "Not used"
                        )
            });
            #endregion

            #region List Assist Cyclist
            Main.model_def.CyclistScene.AddRange(new List<ModelStrings>
            {
                    new ModelStrings
                    (
                        4,
                        "s_f_y_sheriff_01",
                        "s_m_y_sheriff_01",
                        "s_m_m_paramedic_01",
                        "s_m_y_pilot_01",
                        "Not used",
                        "SHERIFF",
                        "AMBULANCE",
                        "POLMAV",
                        "Not used",
                        "Not used"
                        ),
                    new ModelStrings
                    (
                        5,
                        "s_f_y_sheriff_01",
                        "s_m_y_sheriff_01",
                        "s_m_m_paramedic_01",
                        "s_m_y_pilot_01",
                          "Not used",
                        "SHERIFF2",
                        "AMBULANCE",
                        "POLMAV",
                        "Not used",
                        "Not used"
                        ),
                       new ModelStrings
                    (
                        6,
                        "s_f_y_ranger_01",
                        "s_m_y_ranger_01",
                        "s_m_m_paramedic_01",
                        "s_m_y_pilot_01",
                        "Not used",
                        "PRANGER",
                        "AMBULANCE",
                        "POLMAV",
                        "Not used",
                        "Not used"
                        )
            });
            #endregion

            #region List Assist Corner Cut
            Main.model_def.CornerCut.AddRange(new List<ModelStrings>
        {
            new ModelStrings
            (
                7,
                "s_m_y_sheriff_01",
                "s_f_y_sheriff_01",
                "s_m_m_paramedic_01",
                "s_m_y_fireman_01",
                "Not used",
                "SHERIFF2",
                "AMBULANCE",
                "FIRETRUK",
                "Not used",
                "Not used"
                ),
            new ModelStrings
            (
                8,
                "s_f_y_sheriff_01",
                "s_m_y_sheriff_01",
                "s_m_m_paramedic_01",
                "s_m_y_fireman_01",
                "Not used",
                "SHERIFF",
                "AMBULANCE",
                "FIRETRUK",
                "Not used",
                "Not used"
                ),
               new ModelStrings
            (
                9,
                "s_f_y_sheriff_01",
                "s_m_y_sheriff_01",
                "s_m_m_paramedic_01",
                "s_m_y_fireman_01",
                "Not used",
                "SHERIFF",
                "AMBULANCE",
                "FIRETRUK",
                "Not used",
                "Not used"
                )
        });
            #endregion

            #region List Assist TruckCrash
            Main.model_def.TruckCrash.AddRange(new List<ModelStrings>
        {
            new ModelStrings
            (
                10,
                "s_m_y_cop_01",
                "s_f_y_cop_01",
                "s_m_m_paramedic_01",
                "s_m_y_fireman_01",
                "Not used",
                "POLICE3",
                "POLICE2",
                "AMBULANCE",
                "FIRETRUK",
                "Not used"
                ),
            new ModelStrings
            (
                11,
                "s_m_y_sheriff_01",
                "s_f_y_sheriff_01",
                "s_m_m_paramedic_01",
                "s_m_y_fireman_01",
                "Not used",
                "SHERIFF",
                "POLICE2",
                "AMBULANCE",
                "FIRETRUK",
                "Not used"
                ),
               new ModelStrings
            (
                12,
               "s_m_y_ranger_01",
                "s_m_y_sheriff_01",
                "s_m_m_paramedic_01",
                "s_m_y_fireman_01",
                "Not used",
                "SHERIFF2",
                "PRANGER",
                "AMBULANCE",
                "FIRETRUK",
                "Not used"
                )
        });
            #endregion

            #region List Assist Freeway
            Main.model_def.Freeway.AddRange(new List<ModelStrings>
        {
            new ModelStrings
            (
                13,
                "s_m_y_cop_01",
                "s_f_y_cop_01",
                "s_m_y_hwaycop_01",
                "s_m_m_paramedic_01",
                "s_m_y_fireman_01",
                "POLICE4",
                "POLICEB",
                "AMBULANCE",
                "POLMAV",
                "FIRETRUK"
                ),
            new ModelStrings
            (
                14,
                "s_f_y_sheriff_01",
                "s_m_y_hwaycop_01",
                "s_m_y_sheriff_01",
                "s_m_m_paramedic_01",
                "s_m_y_fireman_01",
                "POLICE4",
                "SHERIFF",
                "AMBULANCE",
                "POLMAV",
                "FIRETRUK"
                ),
               new ModelStrings
            (
                15,
                "s_f_y_cop_01",
                "s_m_y_cop_01",
                "s_m_y_cop_01",
                "s_m_m_paramedic_01",
                "s_m_y_fireman_01",
                "POLICE3",
                "POLICE",
                "AMBULANCE",
                "POLMAV",
                "FIRETRUK"
                ),
                    new ModelStrings
            (
                16,
                "s_m_y_sheriff_01",
                "s_m_y_sheriff_01",
                "s_f_y_sheriff_01",
                "s_m_m_paramedic_01",
                "s_m_y_fireman_01",
                "SHERIFF",
                "SHERIFF2",
                "AMBULANCE",
                "POLMAV",
                "FIRETRUK"
                )
        });
            #endregion

            #region List Beach
            Main.model_def.BeachScene.AddRange(new List<ModelStrings>
        {
            new ModelStrings
            (
                17,
                "s_m_y_cop_01",
                "s_f_y_cop_01",
                "s_m_m_paramedic_01",
                "s_m_y_baywatch_01",
                "s_f_y_baywatch_01",
                "POLICE3",
                "POLICE",
                "AMBULANCE",
                "LGUARD",
                "BLAZER2"
                ),
            new ModelStrings
            (
                18,
                "s_m_y_cop_01",
                "s_f_y_cop_01",
                "s_m_m_paramedic_01",
                "s_m_y_baywatch_01",
                "s_f_y_baywatch_01",
                "POLICE4",
                "POLICE2",
                "AMBULANCE",
                "LGUARD",
                "BLAZER2"
                )
        });
            #endregion

            #region List Assist RunOver
            Main.model_def.RunOver.AddRange(new List<ModelStrings>
        {
            new ModelStrings
            (
                19,
                "s_m_y_cop_01",
                "s_m_m_paramedic_01",
                "Not used",
                "Not used",
                "Not used",
                "POLICE3",
                "AMBULANCE",
                "Not used",
                "Not used",
                "Not used"
                ),
            new ModelStrings
            (
                20,
                "s_f_y_cop_01",
                "s_m_m_paramedic_01",
                "Not used",
                "Not used",
                "Not used",
                "POLICE",
                "AMBULANCE",
                "Not used",
                "Not used",
                "Not used"
                ),
            new ModelStrings
            (
                21,
                "s_m_y_cop_01",
                "s_m_m_paramedic_01",
                "Not used",
                "Not used",
                "Not used",
                "POLICE2",
                "AMBULANCE",
                "Not used",
                "Not used",
                "Not used"
                ),
            new ModelStrings
            (
                22,
                "s_m_y_cop_01",
                "s_m_m_paramedic_01",
                "Not used",
                "Not used",
                "Not used",
                "POLICE4",
                "AMBULANCE",
                "Not used",
                "Not used",
                "Not used"
                ),
           new ModelStrings
            (
                23,
                "s_f_y_sheriff_01",
                "s_m_m_paramedic_01",
                "Not used",
                "Not used",
                "Not used",
                "SHERIFF2",
                "AMBULANCE",
                "Not used",
                "Not used",
                "Not used"
                ),
              new ModelStrings
            (
                24,
                "s_m_y_sheriff_01",
                "s_m_m_paramedic_01",
                "Not used",
                "Not used",
                "Not used",
                "SHERIFF",
                "AMBULANCE",
                "Not used",
                "Not used",
                "Not used"
                ),
                 new ModelStrings
            (
                25,
                "s_m_y_sheriff_01",
                "s_m_m_paramedic_01",
                "Not used",
                "Not used",
                "Not used",
                "SHERIFF2",
                "AMBULANCE",
                "Not used",
                "Not used",
                "Not used"
                ),
                    new ModelStrings
            (
                26,
                "s_f_y_sheriff_01",
                "s_m_m_paramedic_01",
                "Not used",
                "Not used",
                "Not used",
                "SHERIFF",
                "AMBULANCE",
                "Not used",
                "Not used",
                "Not used"
                ),
                       new ModelStrings
            (
                27,
                "s_f_y_sheriff_01",
                "s_m_m_paramedic_01",
                "Not used",
                "Not used",
                "Not used",
                "SHERIFF2",
                "AMBULANCE",
                "Not used",
                "Not used",
                "Not used"
                ),
                          new ModelStrings
            (
                28,
                "s_m_y_sheriff_01",
                "s_m_m_paramedic_01",
                "Not used",
                "Not used",
                "Not used",
                "SHERIFF",
                "AMBULANCE",
                "Not used",
                "Not used",
                "Not used"
                ),
                             new ModelStrings
            (
                29,
                "s_m_y_sheriff_01",
                "s_m_m_paramedic_01",
                "Not used",
                "Not used",
                "Not used",
                "SHERIFF2",
                "AMBULANCE",
                "Not used",
                "Not used",
                "Not used"
                ),
                                new ModelStrings
            (
                30,
                "s_f_y_sheriff_01",
                "s_m_m_paramedic_01",
                "Not used",
                "Not used",
                "Not used",
                "SHERIFF",
                "AMBULANCE",
                "Not used",
                "Not used",
                "Not used"
                )
        });
            #endregion
        }
    }
}
