using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.IO;
using System.Globalization;
using System.Windows.Forms;

namespace PlanetenSimulator
{
    class File
    {
        private static bool valid = true;

        public static void saveConfig(string file, MainWindow mw)
        {
            try
            {
                // Speichern in Form der Struktur
                /* Beispiel - Struktur
                 * <Simulator>
                 *  <Config>
                 *      <Wert>Value</Wert>
                 *  </Config>
                 * </Simulator>
                 * */

                XmlTextWriter writer = new XmlTextWriter(file, System.Text.Encoding.UTF8);
                writer.Formatting = Formatting.Indented; // Formatierung an
                writer.WriteStartDocument(); // Dateityp und Attribute schreiben

                // Programmzugehörigkeit zeigen
                writer.WriteComment("Created by PlanetenSimulator");
                writer.WriteStartElement("simulator");


                // Config schreiben
                writer.WriteStartElement("config");


                writer.WriteElementString("tick", mw.getTick().ToString(CultureInfo.InvariantCulture));
                writer.WriteElementString("intervall", mw.getPositionAbstand().ToString());

                writer.WriteElementString("deep", mw.getDeep().ToString(CultureInfo.InvariantCulture));

                writer.WriteStartElement("layouts");
                for (int i = 0; i < mw.getLayouts().Length; i++)
                {
                    writer.WriteElementString(mw.getLayouts()[i + 1], mw.getLayouts()[i]);
                    i++;
                }
                writer.WriteEndElement();

                writer.WriteEndElement();
                // Config fertig

                writer.WriteEndElement();
                // XML - Datei abschließen
                writer.Flush();
                writer.Close();
                // Puffer geleert... Geschafft

            }
            catch (XmlException xmlEx) // XML - Fehler
            {
                Console.WriteLine("{0}", xmlEx.Message);
            }
            catch (Exception ex)       // allg. Fehler
            {
                Console.WriteLine("{0}", ex.Message);
            }
        }

        // Lesen der Config-Datei, falls diese existiert
        public static void loadConfig(string file, MainWindow mw)
        {
            try
            {
                // XML-Datei öffnen...
                XmlTextReader reader = new XmlTextReader(file);

                // XML-Datei prüfen
                XmlReaderSettings xrs = new XmlReaderSettings();
                xrs.ValidationType = ValidationType.Schema;
                xrs.ValidationEventHandler += new ValidationEventHandler(ValidationHandler);

                XmlReader xr = XmlReader.Create("Resources/configXMLTest.xsd", xrs);

                valid = true;

                while (xr.Read()) { }

                // XML-Datei lesen
                while (reader.Read())
                {
                    if (reader.Name == "config")
                    {

                        XmlReader planR = reader.ReadSubtree();
                        while (planR.Read())
                        {
                            if (planR.Name == "tick")
                                mw.setTick(planR.ReadElementContentAsFloat());
                            else if (planR.Name == "intervall")
                                mw.setPositionAbstand(planR.ReadElementContentAsInt());
                            else if (planR.Name == "deep")
                                mw.setDeep(planR.ReadElementContentAsFloat());
                            else if (planR.Name == "layouts")
                            {
                                List<string> layouts = new List<string>();
                                XmlReader planSR = planR.ReadSubtree();
                                while (planSR.Read())
                                {
                                    if (planSR.Name != "layouts" && planSR.Name.Length > 0)
                                    {
                                        string color = (string)planSR.Name.Clone();
                                        layouts.Add(planSR.ReadElementContentAsString());
                                        layouts.Add(color);
                                    }
                                }
                                mw.setLayouts(layouts.ToArray());
                            }
                        }
                    }
                }
            }
            catch (XmlException xmlEx) // XML - Fehler
            {
                Console.WriteLine("{0}", xmlEx.Message);
            }
            catch (Exception ex)       // allg. Dateifehler
            {
                Console.WriteLine("{0}", ex.Message);
            }
        }

        public static void save(string file, List<Orb> orbs)
        {
            try
            {
                // Speichern in Form der Struktur
                /* Beispiel - Struktur
                 * <simulator>
                 *  <orb>
                 *      <gravitaion>
                 *          <name>Blubba</name>
                 *          <mass>5.0</mass>
                 *          <radius>5.0</radius>
                 *          <position>
                 *              <x>1354,547</x>
                 *              <y>1166,218</y>
                 *              <z>0</z>
                 *          </position>
                 *          <speed>
                 *              <x>-0,1026675</x>
                 *              <y>0,1622077</y>
                 *              <z>0</z>
                 *          </speed>
                 *      </gravitation>
                 *  </orb>
                 * </simulator>
                 * */

                XmlTextWriter writer = new XmlTextWriter(file, System.Text.Encoding.UTF8);
                writer.Formatting = Formatting.Indented; // Formatierung an
                writer.WriteStartDocument(); // Dateityp und Attribute schreiben

                // Programmzugehörigkeit zeigen
                writer.WriteComment("Created by PlanetenSimulator");
                writer.WriteStartElement("simulator");


                // Und Planeten speichern
                List<Orb>.Enumerator i = orbs.GetEnumerator();
                while (i.MoveNext())
                {
                    Orb orb = (Orb)i.Current;

                    // Himmelskörper start
                    writer.WriteStartElement("orb");

                    // Methode setzten
                    if (i.Current is Orb_Ellipse)
                        writer.WriteStartElement("ellipse");
                    else if (i.Current is Orb_OneSun)
                        writer.WriteStartElement("onesun");
                    else
                        writer.WriteStartElement("gravitation");

                    // Gleiche Eigenschaften
                    writer.WriteElementString("name", orb.getName());
                    writer.WriteElementString("radius", orb.getRadius().ToString(CultureInfo.InvariantCulture));
                    writer.WriteElementString("layout", orb.getLayout());
                    writer.WriteElementString("methode", orb.getMethode());

                    // Position
                    writer.WriteStartElement("position");
                    writer.WriteElementString("x", orb.getPosition()[0].ToString(CultureInfo.InvariantCulture));
                    writer.WriteElementString("y", orb.getPosition()[1].ToString(CultureInfo.InvariantCulture));
                    writer.WriteElementString("z", orb.getPosition()[2].ToString(CultureInfo.InvariantCulture));
                    writer.WriteEndElement();

                    // Unterschiedliche Eigenschaften
                    if (i.Current is Orb_Ellipse)
                    {
                        Orb_Ellipse sorb = (Orb_Ellipse)i.Current;
                        writer.WriteElementString("speed", sorb.getV().ToString(CultureInfo.InvariantCulture));

                        writer.WriteStartElement("axis");
                        writer.WriteElementString("great", sorb.getAxis()[0].ToString(CultureInfo.InvariantCulture));
                        writer.WriteElementString("little", sorb.getAxis()[1].ToString(CultureInfo.InvariantCulture));
                        writer.WriteEndElement();

                    }
                    else if (i.Current is Orb_OneSun)
                    {
                        Orb_OneSun sorb = (Orb_OneSun)i.Current;

                        writer.WriteElementString("center", sorb.getCenter().ToString());
                        writer.WriteElementString("mass", sorb.getMasse().ToString(CultureInfo.InvariantCulture));

                        writer.WriteStartElement("speed");
                        writer.WriteElementString("x", sorb.getV()[0].ToString(CultureInfo.InvariantCulture));
                        writer.WriteElementString("y", sorb.getV()[1].ToString(CultureInfo.InvariantCulture));
                        writer.WriteElementString("z", sorb.getV()[2].ToString(CultureInfo.InvariantCulture));
                        writer.WriteEndElement();
                    }
                    else
                    {
                        Orb_Gravitation sorb = (Orb_Gravitation)i.Current;

                        writer.WriteElementString("mass", sorb.getMasse().ToString(CultureInfo.InvariantCulture));

                        writer.WriteStartElement("speed");
                        writer.WriteElementString("x", sorb.getV()[0].ToString(CultureInfo.InvariantCulture));
                        writer.WriteElementString("y", sorb.getV()[1].ToString(CultureInfo.InvariantCulture));
                        writer.WriteElementString("z", sorb.getV()[2].ToString(CultureInfo.InvariantCulture));
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();

                    // Himmelskörper abschließen
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                // XML - Datei abschließen
                writer.Flush();
                writer.Close();
                // Puffer geleert... Geschafft

            }
            catch (XmlException xmlEx) // XML - Fehler
            {
                Console.WriteLine("{0}", xmlEx.Message);
            }
            catch (Exception ex)       // allg. Fehler
            {
                Console.WriteLine("{0}", ex.Message);
            }
            Console.WriteLine(orbs.Count + " Körper gespeichert!");
        }

        public static void load(string file, MainWindow mw)
        {
            try
            {
                List<Orb> orbs = new List<Orb>(); // TempOrbs

                // XML-Datei öffnen...
                XmlTextReader reader = new XmlTextReader(file);

                // XML-Datei prüfen



                XmlReaderSettings xrs = new XmlReaderSettings();
                xrs.ValidationType = ValidationType.Schema;
                xrs.ValidationEventHandler += new ValidationEventHandler(ValidationHandler);

                XmlReader xr = XmlReader.Create("Resources/orbXMLTest.xsd", xrs);

                valid = true;

                while (xr.Read()) { }

                if (valid)
                {

                    // XML-Datei lesen
                    while (reader.Read())
                    {

                        // Element Körper?
                        if (reader.Name == "orb")
                        {
                            // Methode & Eigenschaften des Himmelskörpers lesen
                            XmlReader planR = reader.ReadSubtree();
                            while (planR.Read())
                            {
                                // Methode: Ellipse
                                if (planR.Name == "ellipse")
                                {
                                    string name = "", layout = "", methode = "";
                                    float radius = 0;
                                    double speed = 0;
                                    double[] position = new double[3], axis = new double[2];

                                    // Eigenschaften des Himmelskörpers lesen
                                    XmlReader planSR = reader.ReadSubtree();
                                    while (planSR.Read())
                                    {
                                        // Name lesen
                                        if (planSR.Name == "name")
                                            name = planSR.ReadElementContentAsString();
                                        // Radius lesen
                                        else if (planSR.Name == "radius")
                                            radius = planSR.ReadElementContentAsFloat();
                                        // Layout lesen
                                        else if (planSR.Name == "layout")
                                            layout = planSR.ReadElementContentAsString();
                                        // Methode lesen
                                        else if (planSR.Name == "methode")
                                            methode = planSR.ReadElementContentAsString();
                                        // Geschwindigkeit lesen
                                        else if (planSR.Name == "speed")
                                            speed = planSR.ReadElementContentAsDouble();
                                        // Position mit (x, y, z) lesen
                                        else if (planSR.Name == "position")
                                        {
                                            XmlReader planSSR = planSR.ReadSubtree();
                                            while (planSSR.Read())
                                            {
                                                if (planSSR.Name == "x")
                                                    position[0] = planSSR.ReadElementContentAsDouble();
                                                else if (planSSR.Name == "y")
                                                    position[1] = planSSR.ReadElementContentAsDouble();
                                                else if (planSSR.Name == "z")
                                                    position[2] = planSSR.ReadElementContentAsDouble();
                                            }
                                        }
                                        // Achsen lesen
                                        else if (planSR.Name == "axis")
                                        {
                                            XmlReader planSSR = planSR.ReadSubtree();
                                            while (planSSR.Read())
                                            {
                                                if (planSSR.Name == "great")
                                                    axis[0] = planSSR.ReadElementContentAsDouble();
                                                else if (planSSR.Name == "little")
                                                    axis[1] = planSSR.ReadElementContentAsDouble();
                                            }
                                        }
                                    }
                                    // Himmelskörper der Liste hinzufügen
                                    orbs.Add(new Orb_Ellipse(name, radius, position, speed, layout, axis, mw));
                                }
                                // Methode: Gravitation
                                else if (planR.Name == "gravitation")
                                {
                                    string name = "", layout = "", methode = "";
                                    float radius = 0;
                                    double mass = 0;
                                    double[] position = new double[3], speed = new double[3];

                                    // Eigenschaften des Himmelskörpers lesen
                                    XmlReader planSR = reader.ReadSubtree();
                                    while (planSR.Read())
                                    {
                                        // Name lesen
                                        if (planSR.Name == "name")
                                            name = planSR.ReadElementContentAsString();
                                        // Radius lesen
                                        else if (planSR.Name == "radius")
                                            radius = planSR.ReadElementContentAsFloat();
                                        // Layout lesen
                                        else if (planSR.Name == "layout")
                                            layout = planSR.ReadElementContentAsString();
                                        // Methode lesen
                                        else if (planSR.Name == "methode")
                                            methode = planSR.ReadElementContentAsString();
                                        // Masse lesen
                                        else if (planSR.Name == "mass")
                                            mass = planSR.ReadElementContentAsDouble();
                                        // Position mit (x, y, z) lesen
                                        else if (planSR.Name == "position")
                                        {
                                            XmlReader planSSR = planSR.ReadSubtree();
                                            while (planSSR.Read())
                                            {
                                                if (planSSR.Name == "x")
                                                    position[0] = planSSR.ReadElementContentAsDouble();
                                                else if (planSSR.Name == "y")
                                                    position[1] = planSSR.ReadElementContentAsDouble();
                                                else if (planSSR.Name == "z")
                                                    position[2] = planSSR.ReadElementContentAsDouble();
                                            }
                                        }
                                        // Achsen lesen
                                        else if (planSR.Name == "speed")
                                        {
                                            XmlReader planSSR = planSR.ReadSubtree();
                                            while (planSSR.Read())
                                            {
                                                if (planSSR.Name == "x")
                                                    speed[0] = planSSR.ReadElementContentAsDouble();
                                                else if (planSSR.Name == "y")
                                                    speed[1] = planSSR.ReadElementContentAsDouble();
                                                else if (planSSR.Name == "z")
                                                    speed[2] = planSSR.ReadElementContentAsDouble();
                                            }
                                        }
                                    }
                                    // Himmelskörper der Liste hinzufügen
                                    orbs.Add(new Orb_Gravitation(name, radius, mass, position, speed, layout, mw));
                                }
                                // Methode: OneSun
                                else if (planR.Name == "onesun")
                                {
                                    string name = "", layout = "", methode = "";
                                    int center = 0;
                                    float radius = 0;
                                    double mass = 0;
                                    double[] position = new double[3], speed = new double[3];

                                    // Eigenschaften des Himmelskörpers lesen
                                    XmlReader planSR = reader.ReadSubtree();
                                    while (planSR.Read())
                                    {
                                        // Name lesen
                                        if (planSR.Name == "name")
                                            name = planSR.ReadElementContentAsString();
                                        // Radius lesen
                                        else if (planSR.Name == "radius")
                                            radius = planSR.ReadElementContentAsFloat();
                                        // Layout lesen
                                        else if (planSR.Name == "layout")
                                            layout = planSR.ReadElementContentAsString();
                                        // Methode lesen
                                        else if (planSR.Name == "methode")
                                            methode = planSR.ReadElementContentAsString();
                                        // Masse lesen
                                        else if (planSR.Name == "mass")
                                            mass = planSR.ReadElementContentAsDouble();
                                        // Gravitationszentrum lesen
                                        else if (planSR.Name == "center")
                                            center = planSR.ReadElementContentAsInt();
                                        // Position mit (x, y, z) lesen
                                        else if (planSR.Name == "position")
                                        {
                                            XmlReader planSSR = planSR.ReadSubtree();
                                            while (planSSR.Read())
                                            {
                                                if (planSSR.Name == "x")
                                                    position[0] = planSSR.ReadElementContentAsDouble();
                                                else if (planSSR.Name == "y")
                                                    position[1] = planSSR.ReadElementContentAsDouble();
                                                else if (planSSR.Name == "z")
                                                    position[2] = planSSR.ReadElementContentAsDouble();
                                            }
                                        }
                                        // Achsen lesen
                                        else if (planSR.Name == "speed")
                                        {
                                            XmlReader planSSR = planSR.ReadSubtree();
                                            while (planSSR.Read())
                                            {
                                                if (planSSR.Name == "x")
                                                    speed[0] = planSSR.ReadElementContentAsDouble();
                                                else if (planSSR.Name == "y")
                                                    speed[1] = planSSR.ReadElementContentAsDouble();
                                                else if (planSSR.Name == "z")
                                                    speed[2] = planSSR.ReadElementContentAsDouble();
                                            }
                                        }
                                    }
                                    // Gültiger Planet ausgelesen? => Himmelskörper der Liste hinzufügen
                                    orbs.Add(new Orb_OneSun(name, radius, mass, position, speed, layout, center, mw));
                                }
                            }
                        }
                    }
                    // Min. 1 Körper exisitert? => Daten aus den Zwischenspeichern ins Projekt laden
                    if (orbs.Count > 0)
                    {
                        Console.WriteLine("Lade " + orbs.Count + " Körper...");
                        mw.setOrbs(orbs);
                    }
                }
                else
                {
                    DialogResult box = MessageBox.Show("Kein gültiges XML-Dokument", "Fehler", 
                                                       MessageBoxButtons.RetryCancel);
                    if (box == DialogResult.Retry)
                        mw.load();
                }
            }
            catch (XmlException xmlEx) // XML - Fehler
            {
                Console.WriteLine("{0}", xmlEx.Message);
            }
            catch (Exception ex)       // allg. Dateifehler
            {
                Console.WriteLine("{0}", ex.Message);
            }
        }
        public static void ValidationHandler(object sender, ValidationEventArgs args)
        {
            valid = false;
        }
    }
}
