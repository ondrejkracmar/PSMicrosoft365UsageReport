$UsageReportCode = @'
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text.RegularExpressions;

namespace UsageReport
{
    public class Parameters
    {
        public Parameters()
        {

        }

         public string[] Days;
         public string Date;

    }

    public class ResponseProperty
    {   
        public ResponseProperty()
        {

        }

        public string Name;
        public string Expression;
    }
    
    public class Definition
    {   
        public Definition()
        {

        }

        public string Function;
        public Parameters Parameters;
        public ResponseProperty[] ResponseProperty;
    }

    public class Microsoft365UsageReport
    {   
        public Microsoft365UsageReport()
        {

        }

        public string Name;
        public string Description;
        public string Utility;
        public string Service;
        public string Type;
        public string Version;
        public string[] Format;
        public Definition Definition;
    }
}
'@
# compile c# code
Try {
    if ( [UsageReport.Microsoft365UsageReport] -as [type]) {

    }
}
catch {
    Add-Type -TypeDefinition $UsageReportCode
}