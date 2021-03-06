//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace GetBookmarksFromPDFExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //create PdfBookmarkEditor
        PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
        //open PDF file
        bookmarkEditor.BindPdf(dataDir+ "input.PDF");
        //extract bookmarks
        Aspose.Pdf.Facades.Bookmarks bookmarks = bookmarkEditor.ExtractBookmarks();
        foreach (Aspose.Pdf.Facades.Bookmark bookmark in bookmarks)
        {
            // get the title information of bookmark item
            Console.WriteLine("Title: {0}", bookmark.Title);
            // get the destination page for bookmark
            Console.WriteLine("Page Number: {0}", bookmark.PageNumber);
            // get the information related to associated action with bookmark
            Console.WriteLine("Bookmark Action: " + bookmark.Action);
        }

            
            
        }
    }
}