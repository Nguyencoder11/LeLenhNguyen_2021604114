<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<head>
				<title>Danh mục hóa đơn</title>
			</head>
			<xsl:for-each select="DS/HoaDon">
			<body>
					<h2>PHIẾU MUA HÀNG</h2>
				<table border="0">
					<tr>
						<td>
							Mã hóa đơn:<xsl:value-of select="MaHD"/>
						</td>
						<td>
							Ngày bán:<xsl:value-of select="NgayBan"/>
						</td>
					</tr>
					<tr>
						<td>
							Loại hàng:<xsl:value-of select="LoaiHang/@TenLoai"/>
						</td>
						<td>
						</td>
					</tr>
				</table>
				<table border="2" cellpadding="3">
					<tr>
						<td>Mã hàng</td><td>Tên hàng</td><td>Số lượng</td>
						<td>Đơn giá</td><td>Thành tiền</td>
					</tr>
					<xsl:for-each select="LoaiHang/Hang">
						<tr>
							<td>
								<xsl:value-of select="@MaHang"/>
							</td>
							<td>
								<xsl:value-of select="TenHang"/>
							</td>
							<td>
								<xsl:value-of select="SoLuong"/>
							</td>
							<td>
								<xsl:value-of select="DonGia"/>
							</td>
							<td>
								<xsl:value-of select="DonGia*SoLuong"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
			</xsl:for-each>
		</html>
    </xsl:template>
</xsl:stylesheet>
