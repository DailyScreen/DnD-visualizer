using System;
using System.Net;
using System.IO;
using System.Xml;

namespace DnDVisualizer
{
    class Passerelle
    {
        // méthode protégée statique pour obtenir un document XML à partir d'un flux de données en lecture
        // paramètre unFluxEnLecture : un flux de données en lecture (System.IO.StreamReader)
        // retourne : un document XML (System.Xml.Document)
        protected static XmlReader getDocumentXML(StreamReader unFluxEnLecture)
        {
            try
            {
                XmlReader leDocument = XmlReader.Create(unFluxEnLecture);
                return leDocument;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }    
}
