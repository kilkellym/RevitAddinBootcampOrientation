﻿namespace RevitAddinBootcampOrientation
{
    [Transaction(TransactionMode.Manual)]
    public class cmdSkills01 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // Revit application and document variables
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            string myVar = "this is my first variable";
            TaskDialog.Show("Test", "This is a new message from me.");

            TaskDialog.Show("Test", "This is another dialog to test");


            // Your Module 01 Skills code goes here
            // Delete the TaskDialog below and add your code
            //TaskDialog.Show("Module 01 Skills", "Got Here!");


            return Result.Succeeded;
        }
    }

}
