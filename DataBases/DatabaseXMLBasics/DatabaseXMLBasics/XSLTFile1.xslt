<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method='html' version='1.0' encoding='UTF-8' indent='yes' />

  <xsl:template match="/">
    <xsl:text disable-output-escaping="yes">&lt;!DOCTYPE html&gt;
</xsl:text>
    <html>
      <body>
        <h2>Students</h2>
        <table border="1">
          <tr bgcolor="#CCCCCC">
            <th align="left">name</th>
            <th align="left">gender</th>
            <th align="left">birth-date</th>
            <th align="left">phone</th>
            <th align="left">email</th>
            <th align="left">course</th>
            <th align="left">specialty</th>
            <th align="left">faculty-number</th>
            <th>
              <b>exams</b>
              <td>name</td>
              <td>tutor</td>
              <td>score</td>
            </th>
          </tr>
          <xsl:for-each select="student">
            <tr>
              <td>
                <xsl:value-of select="name"/>
              </td>
              <td>
                <xsl:value-of select="gender" />
              </td>
              <td>
                <xsl:value-of select="birth-date"/>
              </td>
              <td>
                <xsl:value-of select="phone"/>
              </td>
              <td>
                <xsl:value-of select="email"/>
              </td>
              <td>
                <xsl:value-of select="course"/>
              </td>
              <td>
                <xsl:value-of select="specialty"/>
              </td>
              <td>
                <xsl:value-of select="faculty-number"/>
              </td>
              <td>
                <xsl:for-each select="exams/exam">
                  <td>
                    <xsl:value-of select="name"/>
                  </td>
                  <td>
                    <xsl:value-of select="tutor"/>
                  </td>
                  <td>
                    <xsl:value-of select="score"/>
                  </td>
                </xsl:for-each>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
