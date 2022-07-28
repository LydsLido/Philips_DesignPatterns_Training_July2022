using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public abstract class IDocumentPart {
        //protected IFormatter format;
        public abstract void convertFormat(IFormatter formatter);
    }

    public class Paragraph: IDocumentPart    {
        public override void convertFormat(IFormatter formatter)        {
            Console.WriteLine("In Paragraph, will call formatter.convert(this)");
            formatter.Convert(this);
        }
    }
    public class Link : IDocumentPart    {
        public override void convertFormat(IFormatter formatter)        {
            formatter.Convert(this);
            Console.WriteLine("In Link, will call formatter.convert(this)");

        }
    }
    public class Header : IDocumentPart    {
        public override void convertFormat(IFormatter formatter)        {
            Console.WriteLine("In Header, will call formatter.convert(this)");

            formatter.Convert(this);
        }
    }

    public class Footer : IDocumentPart    {
        public override void convertFormat(IFormatter formatter)        {
            Console.WriteLine("In Footer, will call formatter.convert(this)");

            formatter.Convert(this);
        }
    }

    public interface IFormatter {
        void Convert(Paragraph dp);
        void Convert(Link dp);
        void Convert(Header dp);
        void Convert(Footer dp);

    }

    public class HTMLFormatter : IFormatter
    {
        public void Convert(Paragraph dp)
        {
            Console.WriteLine("********** In HTMLFormatter, will convert Paragraph to HTML Format ");

        }
        public void Convert(Link dp)
        {
            Console.WriteLine("********** In HTMLFormatter, will convert Link to HTML Format ");

        }
        public void Convert(Header dp)
        {
            Console.WriteLine("********** In HTMLFormatter, will convert Header to HTML Format ");

        }
        public void Convert(Footer dp)
        {
            Console.WriteLine("********** In HTMLFormatter, will convert Footer to HTML Format ");

        }
    }

    public class PDFFormatter : IFormatter
    {
        public void Convert(Paragraph dp)
        {
            Console.WriteLine("#################### In PDFFormatter, will convert Paragraph to PDF Format ");

        }
        public void Convert(Link dp)
        {
            Console.WriteLine("#################### In PDFFormatter, will convert Link to PDF Format ");

        }
        public void Convert(Header dp)
        {
            Console.WriteLine("#################### In PDFFormatter, will convert Header to PDF Format ");

        }
        public void Convert(Footer dp)
        {
            Console.WriteLine("#################### In PDFFormatter, will convert Footer to PDF Format ");

        }
    }

    public class RTFFormatter : IFormatter
    {
        public void Convert(Paragraph dp)
        {
            Console.WriteLine(" &&&&&&&&&&&&&&&&&&& In RTFFormatter, will convert Paragraph to RTF Format ");
        }
        public void Convert(Link dp)
        {
            Console.WriteLine(" &&&&&&&&&&&&&&&&&&& In RTFFormatter, will convert Link to RTF Format ");

        }
        public void Convert(Header dp)
        {
            Console.WriteLine(" &&&&&&&&&&&&&&&&&&& In RTFFormatter, will convert Header to RTF Format ");

        }
        public void Convert(Footer dp)
        {
            Console.WriteLine(" &&&&&&&&&&&&&&&&&&& In RTFFormatter, will convert Footer to RTF Format ");

        }
    }
    public class Document
    {
        List<IDocumentPart> listOfParts;
        IFormatter formatType;
        public Document()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine("=======================================================================");
            Console.WriteLine(" ---------------------- Creating 1 Header----------------------");
            Console.WriteLine(" ---------------------- Creating 1 Paragraph----------------------");
            Console.WriteLine(" ---------------------- Creating 1 Link----------------------");
            Console.WriteLine(" ---------------------- Creating 1 Paragraph----------------------");
            Console.WriteLine(" ---------------------- Creating 1 Link----------------------");
            Console.WriteLine(" ---------------------- Creating 1 Paragraph----------------------");
            Console.WriteLine(" ---------------------- Creating 1 Footer----------------------");

            Console.WriteLine("=======================================================================");
            Console.WriteLine("=======================================================================");

            listOfParts = new List<IDocumentPart>();
            listOfParts.Add(new Header());
            listOfParts.Add(new Paragraph());
            listOfParts.Add(new Link());
            listOfParts.Add(new Paragraph());
            listOfParts.Add(new Link());
            listOfParts.Add(new Paragraph());
            listOfParts.Add(new Footer());
        }
        public void Open()
        {

        }
        public void Save()
        {

        }
        public void SaveAs() // Ideally this will come from UI or as some other input from user
        {

            Console.WriteLine("=======================================================================");
            IFormatter hFormatter = new HTMLFormatter();
            Console.WriteLine("In Going to call HTML formatter, simulating customer choice as HTML");
            foreach (IDocumentPart part in listOfParts)            {
                part.convertFormat(hFormatter);
            }
            Console.WriteLine("=======================================================================");

            IFormatter pFormatter = new PDFFormatter();
            Console.WriteLine("In Going to call PDF formatter, simulating customer choice as PDF");
            foreach (IDocumentPart part in listOfParts)
            {
                part.convertFormat(pFormatter);
            }
            Console.WriteLine("=======================================================================");

            IFormatter rFormatter = new RTFFormatter();
            Console.WriteLine("In Going to call RTF formatter, simulating customer choice as RTF");
            foreach (IDocumentPart part in listOfParts)
            {
                part.convertFormat(rFormatter);
            }
            Console.WriteLine("=======================================================================");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document();
            d.SaveAs();
        }
    }
}
