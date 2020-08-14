# PDFdecoder
This is used to decode pdfs from the embedded PDF segment in HL7.


The need for this sprang up whenever clients were complaining about the PDF lab results coming over as blank. During troubleshooting, I was trying to identify where in the result process this was happening, so I used this to decode the intercepted message right before it was sent to the client.

If you use this, you will need to make the local paths your own as well as a real PDF encoding. The one here is just the standard prefix for PDF encoding.
