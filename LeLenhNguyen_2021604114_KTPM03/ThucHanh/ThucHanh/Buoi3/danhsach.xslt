<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

	<!-- Cách 1: dùng for-each -->
    <!--<xsl:template match="DS">
		<html>
			<head>
				<style>
					.tbl {
						background-color: yellow;
					}
					.so {
						color: red;
						font-size: 24px; 
					}
				</style>
			</head>
			<body>
				<h1>BẢNG LƯƠNG THÁNG</h1>
				
				<xsl:for-each select="congty">
					<h2>Tên công ty: <xsl:value-of select="@TenCT"/></h2>
					<xsl:for-each select="donvi">
						<h2>Tên phòng: <xsl:value-of select="tendv"/></h2>

						<table width="100%" cellspacing="0" border="2" class="tbl">
							<tr>
								<th>STT</th>
								<th>Họ tên</th>
								<th>Ngày sinh</th>
								<th>Ngày công</th>
								<th>Lương</th>
							</tr>
							
							<xsl:for-each select="nhanvien">
								<tr>
									<td class="so">
										<xsl:value-of select="position()"/>
									</td>
									<td>
										<xsl:value-of select="hoten"/>
									</td>
									<td>
										<xsl:value-of select="ngaysinh"/>
									</td>
									<td>
										<xsl:value-of select="ngaycong"/>
									</td>
									<td class="so">
										<xsl:choose>
											<xsl:when test="ngaycong &lt;= 20">
												<xsl:value-of select="ngaycong*150000"/>
											</xsl:when>
											<xsl:when test="ngaycong &lt;= 25">
												<xsl:value-of select="20*150000 + ngaycong*200000"/>
											</xsl:when>
											<xsl:otherwise>
												<xsl:value-of select="ngaycong*250000"/>
											</xsl:otherwise>
										</xsl:choose>
									</td>
								</tr>

							</xsl:for-each>
						</table>
						
					</xsl:for-each>
				</xsl:for-each>
			</body>
		</html>
    </xsl:template>-->
	
	
	<!-- Cách 2: dùng apply-templates -->
	<xsl:template match="DS">
		<html>
			<head>
				<style>
					.tbl {
					background-color: yellow;
					}
					.so {
					color: red;
					font-size: 24px;
					}
				</style>
			</head>
			<body>
				<h1>BẢNG LƯƠNG THÁNG</h1>

				<xsl:apply-templates select="congty"></xsl:apply-templates>
			
		</body>
		</html>
	</xsl:template>

	<xsl:template match="congty">
		<h2>
			Tên công ty: <xsl:value-of select="@TenCT"/>
		</h2>
		<xsl:apply-templates select="donvi"></xsl:apply-templates>
	</xsl:template>
	<xsl:template match="donvi">
		<h2>
			Tên phòng: <xsl:value-of select="tendv"/>
		</h2>

		<table width="100%" cellspacing="0" border="2" class="tbl">
			<tr>
				<th>STT</th>
				<th>Họ tên</th>
				<th>Ngày sinh</th>
				<th>Ngày công</th>
				<th>Lương</th>
			</tr>

			<xsl:apply-templates select="nhanvien"></xsl:apply-templates>
		</table>
	</xsl:template>
	<xsl:template match="nhanvien">
		<tr>
			<td class="so">
				<xsl:value-of select="position()"/>
			</td>
			<td>
				<xsl:value-of select="hoten"/>
			</td>
			<td>
				<xsl:value-of select="ngaysinh"/>
			</td>
			<td>
				<xsl:value-of select="ngaycong"/>
			</td>
			<td class="so">
				<xsl:choose>
					<xsl:when test="ngaycong &lt;= 20">
						<xsl:value-of select="ngaycong*150000"/>
					</xsl:when>
					<xsl:when test="ngaycong &lt;= 25">
						<xsl:value-of select="20*150000 + ngaycong*200000"/>
					</xsl:when>
					<xsl:otherwise>
						<xsl:value-of select="ngaycong*250000"/>
					</xsl:otherwise>
				</xsl:choose>
			</td>
		</tr>
	</xsl:template>
</xsl:stylesheet>
