using iTextSharp.text.pdf;

string inputFilePath = args[0];
string outputFilePath = args[1];


if (!File.Exists(inputFilePath)) { 
    Console.WriteLine($"File nt found {inputFilePath}");
    return;
}


// Combined using statements with var
PdfReader.unethicalreading = true;


using (var reader = new PdfReader(inputFilePath))
using (var fs = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
using (var stamper = new PdfStamper(reader, fs))
{
    // Set encryption to null, effectively removing all protections
    stamper.Writer.SetEncryption(null, null, PdfWriter.ALLOW_PRINTING | PdfWriter.ALLOW_MODIFY_CONTENTS | PdfWriter.ALLOW_COPY | PdfWriter.ALLOW_MODIFY_ANNOTATIONS | PdfWriter.ALLOW_FILL_IN | PdfWriter.ALLOW_SCREENREADERS | PdfWriter.ALLOW_ASSEMBLY | PdfWriter.ALLOW_DEGRADED_PRINTING, PdfWriter.ENCRYPTION_AES_128);
}
