// See https://aka.ms/new-console-template for more information
using GrapeCity.Documents.Pdf;
using GrapeCity.Documents.Pdf.Security;
using GrapeCity.Documents.Text;
using System.Drawing;

Console.WriteLine("PDFドキュメントにパスワードを設定して保護する");

//GcPdfDocument.SetLicenseKey("");

GcPdfDocument doc = new GcPdfDocument();
GcPdfGraphics g = doc.NewPage().Graphics;

TextFormat tf = new TextFormat();
tf.Font = StandardFonts.Times;
tf.FontSize = 14;

g.DrawString("こんにちは、DioDocs！", tf, new PointF(72, 72));

// 暗号化を追加します
StandardSecurityHandlerRev6 ssh = new StandardSecurityHandlerRev6();
ssh.UserPassword = "userpwd";
ssh.OwnerPassword = "ownpwd";

ssh.EditingPermissions = EditingPermissions.Disabled;
ssh.CopyContent = false;
ssh.CopyContentAccessibility = false;
ssh.PrintingPermissions = PrintingPermissions.Disabled;

// EncryptHandlerプロパティを設定します
doc.Security.EncryptHandler = ssh;

// ドキュメントを保存します
doc.Save("result.pdf");



//Console.WriteLine("既存のPDFドキュメントを読み込んで、パスワードを設定して保護する");

////GcPdfDocument.SetLicenseKey("");

//FileStream fs = File.OpenRead("test.pdf");
//GcPdfDocument doc = new GcPdfDocument();
//doc.Load(fs);

//// 暗号化を追加します
//StandardSecurityHandlerRev6 ssh = new StandardSecurityHandlerRev6();
//ssh.UserPassword = "userpwd";
//ssh.OwnerPassword = "ownpwd";

//ssh.EditingPermissions = EditingPermissions.Disabled;
//ssh.CopyContent = false;
//ssh.CopyContentAccessibility = false;
//ssh.PrintingPermissions = PrintingPermissions.Disabled;

//// EncryptHandlerプロパティを設定します
//doc.Security.EncryptHandler = ssh;

//// ドキュメントを保存します
//doc.Save("result-test.pdf");



//Console.WriteLine("パスワードで保護されている既存のPDFドキュメントを読み込む");

////GcPdfDocument.SetLicenseKey("");

//FileStream fs = File.OpenRead("result-test.pdf");
//GcPdfDocument doc = new GcPdfDocument();
//doc.Load(fs, "ownpwd");