<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:output method="html"/>
    <xsl:template match="/">
        <html>
            <head>
                <title>newss.xsl</title>
            </head>
            <body>
                <xsl:value-of select="/tong/songuyen1"/> 
                <xsl:text>+</xsl:text>
                <xsl:value-of select="/tong/songuyen2"/>
                <xsl:text>=</xsl:text>
                <xsl:value-of select="/tong/ketqua"/>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>
