using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public abstract class IDocumentPart {
        protected IFormatter format;
        public abstract void convertFormat();
    }

    class Paragraph: IDocumentPart    {
        public override void convertFormat()        {
            format.Convert(this);
        }
    }
    class Link : IDocumentPart    {
        public override void convertFormat()        {
            format.Convert(this);
        }        
    }
    class Header : IDocumentPart    {
        public override void convertFormat()        {
            format.Convert(this);
        }
    }

    class Footer : IDocumentPart    {
        public override void convertFormat()        {
            format.Convert(this);
        }
    }

    public interface IFormatter {
        IFormatter Convert(IDocumentPart dp);
    }

    class HTMLFormatter : IFormatter
    {
        public IFormatter Convert(IDocumentPart dp){
            IFormatter ifor = new HTMLFormatter();
            return ifor;
        }
    }

    class PDFFormatter: IFormatter
    {
        public IFormatter Convert(IDocumentPart dp){
            IFormatter ifor = new PDFFormatter();
            return ifor;

        }

    }
    class RTFFormatter : IFormatter
    {
        public IFormatter Convert(IDocumentPart dp) {
            IFormatter ifor = new RTFFormatter();
            return ifor;

        }
    }

    class Document
    {
        List<IDocumentPart> listOfParts;
        IFormatter formatType;
        public void Open()
        {

        }
        public void Save()
        {

        }
        public void SaveAs()
        {
            foreach(IDocumentPart part in listOfParts)
            {
                part.convertFormat();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
