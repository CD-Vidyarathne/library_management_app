using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_App
{
    internal class Book
    {
        private string title;
        private string bookCode;
        private string classification;
        private string identifier;
        private string copyCount;
        private string totalCount;
        public Book()
        {
            this.title = string.Empty;
            this.bookCode = string.Empty; 
            this.classification = string.Empty; 
            this.identifier = string.Empty;
            this.copyCount = string.Empty;
            this.totalCount = string.Empty;
        }

        public Book(string title,string classification, string identifier, string copyCount,string totalCount)
        {
            this.title = title;
            this.classification = classification;
            this.identifier = identifier;   
            this.copyCount = copyCount; 
            this.totalCount = totalCount;
            this.bookCode = classification + ' ' + identifier + copyCount;
        }

        public string BookCode { get { return bookCode; } set { bookCode = value; } }
        public string CopyCount {  get { return copyCount; } set { copyCount = value; } }
        public string Identifier { get { return identifier; } set { identifier = value; } }
        public string Title { get { return title; } set { title = value; } }
        public string Classification { get {  return classification; } set {  classification = value; } }

        public string TotalCount {  get { return totalCount; } set {  totalCount = value; } }
    }
}
