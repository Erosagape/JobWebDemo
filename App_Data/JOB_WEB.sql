IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vKPI_Summary', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI_Summary'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vKPI_Summary', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI_Summary'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vKPI_Advance', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI_Advance'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vKPI_Advance', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI_Advance'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vKPI', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'vKPI', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vKPI', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_VolumeByCust', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_VolumeByCust'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_VolumeByCust', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_VolumeByCust'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_Volume', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Volume'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_Volume', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Volume'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_TrackingOper', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_TrackingOper'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_TrackingOper', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_TrackingOper'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_TrackingOper', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_TrackingOper'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_Summary', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Summary'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_Summary', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Summary'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_Profit', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Profit'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_Profit', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Profit'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_Profit', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Profit'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_NoInvoice', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_NoInvoice'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_NoInvoice', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_NoInvoice'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_Invoice', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Invoice'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_Invoice', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Invoice'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_Count', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Count'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_Count', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Count'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_CodeSum', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_CodeSum'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vJob_CodeSum', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_CodeSum'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'View_RefClr', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_RefClr'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'View_RefClr', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_RefClr'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vChequeHeader', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vChequeHeader'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vChequeHeader', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vChequeHeader'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vCheque', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vCheque'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vCheque', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vCheque'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qrpt_TaxInvThirdStep', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvThirdStep'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'qrpt_TaxInvThirdStep', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvThirdStep'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qrpt_TaxInvThirdStep', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvThirdStep'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qrpt_TaxInvSecondStep', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvSecondStep'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qrpt_TaxInvSecondStep', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvSecondStep'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qrpt_TaxInvFristStep', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvFristStep'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qrpt_TaxInvFristStep', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvFristStep'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qrpt_SalseState', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_SalseState'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qrpt_SalseState', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_SalseState'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qrpt_ksat_Biggg', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_ksat_Biggg'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qrpt_ksat_Biggg', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_ksat_Biggg'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qrpt_CostState', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_CostState'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qrpt_CostState', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_CostState'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_TaxInvDetail', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_TaxInvDetail'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_TaxInvDetail', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_TaxInvDetail'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_RSlip', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_RSlip'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_RSlip', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_RSlip'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_Quotation', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Quotation'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_Quotation', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Quotation'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_Quotation', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Quotation'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_PayHeader', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayHeader'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_PayHeader', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayHeader'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_PayHeader', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayHeader'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_PayDetail', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayDetail'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_PayDetail', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayDetail'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_PayDetail', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayDetail'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_Order', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Order'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_Order', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Order'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_Order', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Order'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_Detail', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Detail'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_Detail', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Detail'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_Detail', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Detail'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_DebitNoteSub', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_DebitNoteSub'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_DebitNoteSub', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_DebitNoteSub'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_DebitNoteSub', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_DebitNoteSub'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_CustAdvance', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_CustAdvance'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_CustAdvance', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_CustAdvance'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_CustAdvance', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_CustAdvance'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_BillHeader', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillHeader'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_BillHeader', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillHeader'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_BillHeader', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillHeader'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_BillDetail', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillDetail'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_BillDetail', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillDetail'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_BillDetail', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillDetail'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_AdvHeader', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_AdvHeader'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'qJob_AdvHeader', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_AdvHeader'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'QE_UnionCashJob', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_UnionCashJob'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'QE_UnionCashJob', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_UnionCashJob'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'QE_QuotationHeader', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QuotationHeader'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'QE_QuotationHeader', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QuotationHeader'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'QE_QuoDetailItem', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QuoDetailItem'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'QE_QuoDetailItem', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QuoDetailItem'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'QE_QoutationDetail', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QoutationDetail'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'QE_QoutationDetail', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QoutationDetail'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'QE_ListSelectJob', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_ListSelectJob'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'QE_ListSelectJob', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_ListSelectJob'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'QE_InvoiceAPDetail', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_InvoiceAPDetail'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'QE_InvoiceAPDetail', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_InvoiceAPDetail'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'QE_CustAdvanceCheqHeader', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CustAdvanceCheqHeader'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'QE_CustAdvanceCheqHeader', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CustAdvanceCheqHeader'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'QE_Clearing', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_Clearing'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'QE_Clearing', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_Clearing'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'QE_CashControlSub', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlSub'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'QE_CashControlSub', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlSub'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'QE_CashControlRefJob', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlRefJob'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'QE_CashControlRefJob', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlRefJob'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'QE_CashControlHeder', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlHeder'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'QE_CashControlHeder', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlHeder'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'QE_CashControlDoc', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlDoc'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'QE_CashControlDoc', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlDoc'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'QE_Advance', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_Advance'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'QE_Advance', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_Advance'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'Q_VouherStateTwo', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_VouherStateTwo'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'Q_VouherStateTwo', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_VouherStateTwo'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'Q_VouherStateOne', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_VouherStateOne'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'Q_VouherStateOne', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_VouherStateOne'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'Q_TaxExport', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_TaxExport'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'Q_TaxExport', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_TaxExport'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'Q_TaxExport', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_TaxExport'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'Q_StatementAccount', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_StatementAccount'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'Q_StatementAccount', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_StatementAccount'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'Q_StatementAccount', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_StatementAccount'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'Q_ReportCostAndProfit', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ReportCostAndProfit'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'Q_ReportCostAndProfit', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ReportCostAndProfit'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'Q_ReportCostAndProfit', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ReportCostAndProfit'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'Q_ProfitSales', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitSales'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'Q_ProfitSales', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitSales'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'Q_ProfitCost', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitCost'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'Q_ProfitCost', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitCost'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'Q_ProfitCalculate', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitCalculate'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'Q_ProfitCalculate', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitCalculate'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'Q_PaymentRef', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_PaymentRef'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'Q_PaymentRef', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_PaymentRef'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'Q_FinancialSalesReport', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialSalesReport'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'Q_FinancialSalesReport', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialSalesReport'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'Q_FinancialSalesReport', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialSalesReport'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'Q_FinancialCostReport', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialCostReport'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'Q_FinancialCostReport', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialCostReport'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'Q_FinancialCostReport', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialCostReport'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'Q_CostJoinProfit', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_CostJoinProfit'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'Q_CostJoinProfit', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_CostJoinProfit'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'Q_ClearEarness', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ClearEarness'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'Q_ClearEarness', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ClearEarness'
GO
IF  EXISTS (SELECT * FROM sys.fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'Q_ClearEarness', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ClearEarness'
GO
/****** Object:  StoredProcedure [dbo].[RefreshStatusAll]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RefreshStatusAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[RefreshStatusAll]
GO
/****** Object:  StoredProcedure [dbo].[RefreshJobStatus]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RefreshJobStatus]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[RefreshJobStatus]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_MAS_GLACCOUNT_ShipBy]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MAS_GLACCOUNT] DROP CONSTRAINT [DF_MAS_GLACCOUNT_ShipBy]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_MAS_GLACCOUNT_JobType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MAS_GLACCOUNT] DROP CONSTRAINT [DF_MAS_GLACCOUNT_JobType]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_MAS_GLACCOUNT_BranchCode]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MAS_GLACCOUNT] DROP CONSTRAINT [DF_MAS_GLACCOUNT_BranchCode]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Mas_Company_IsShippingCannotSign]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Mas_Company] DROP CONSTRAINT [DF_Mas_Company_IsShippingCannotSign]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Mas_Company_ISCustomerSignECon]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Mas_Company] DROP CONSTRAINT [DF_Mas_Company_ISCustomerSignECon]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Mas_Company_ISCustomerSignDec]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Mas_Company] DROP CONSTRAINT [DF_Mas_Company_ISCustomerSignDec]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Mas_Company_ISCustomerSignInv]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Mas_Company] DROP CONSTRAINT [DF_Mas_Company_ISCustomerSignInv]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Mas_Company_ISCustomerSign]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Mas_Company] DROP CONSTRAINT [DF_Mas_Company_ISCustomerSign]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Mas_Company_CustomsBrokerSeq]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Mas_Company] DROP CONSTRAINT [DF_Mas_Company_CustomsBrokerSeq]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Mas_Company_GoldCardNO]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Mas_Company] DROP CONSTRAINT [DF_Mas_Company_GoldCardNO]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Mas_Company_CommRate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Mas_Company] DROP CONSTRAINT [DF_Mas_Company_CommRate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Mas_Company_DutyLimit]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Mas_Company] DROP CONSTRAINT [DF_Mas_Company_DutyLimit]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Mas_Company_LevelNoImp]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Mas_Company] DROP CONSTRAINT [DF_Mas_Company_LevelNoImp]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Mas_Company_LevelNoExp]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Mas_Company] DROP CONSTRAINT [DF_Mas_Company_LevelNoExp]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Mas_Company_MgrSeq]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Mas_Company] DROP CONSTRAINT [DF_Mas_Company_MgrSeq]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Mas_Company_Is19bis]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Mas_Company] DROP CONSTRAINT [DF_Mas_Company_Is19bis]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Mas_Company_CustType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Mas_Company] DROP CONSTRAINT [DF_Mas_Company_CustType]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Mas_BookAccount_IsLocal]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Mas_BookAccount] DROP CONSTRAINT [DF_Mas_BookAccount_IsLocal]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_TaxInvoiceDetail_BranchCode]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_TaxInvoiceDetail] DROP CONSTRAINT [DF_Job_TaxInvoiceDetail_BranchCode]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_SrvSingle_IsUsedCoSlip]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_SrvSingle] DROP CONSTRAINT [DF_Job_SrvSingle_IsUsedCoSlip]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_SrvSingle_IsLtdAdv50Tavi]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_SrvSingle] DROP CONSTRAINT [DF_Job_SrvSingle_IsLtdAdv50Tavi]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_SrvSingle_IsPay50TaviTo]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_SrvSingle] DROP CONSTRAINT [DF_Job_SrvSingle_IsPay50TaviTo]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_SrvSingle_IsHaveSlip]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_SrvSingle] DROP CONSTRAINT [DF_Job_SrvSingle_IsHaveSlip]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_SrvSingle_IsShowPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_SrvSingle] DROP CONSTRAINT [DF_Job_SrvSingle_IsShowPrice]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_SrvSingle_IsExpense]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_SrvSingle] DROP CONSTRAINT [DF_Job_SrvSingle_IsExpense]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_SrvSingle_IsCredit]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_SrvSingle] DROP CONSTRAINT [DF_Job_SrvSingle_IsCredit]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_SrvSingle_Rate50Tavi]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_SrvSingle] DROP CONSTRAINT [DF_Job_SrvSingle_Rate50Tavi]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_SrvSingle_Is50Tavi]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_SrvSingle] DROP CONSTRAINT [DF_Job_SrvSingle_Is50Tavi]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_SrvSingle_IsTaxCharge]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_SrvSingle] DROP CONSTRAINT [DF_Job_SrvSingle_IsTaxCharge]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_QuoHeader_ExchageRate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_QuoHeader] DROP CONSTRAINT [DF_Job_QuoHeader_ExchageRate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_QuoDetailItem_UnitDiscntAmt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_QuoDetailItem] DROP CONSTRAINT [DF_Job_QuoDetailItem_UnitDiscntAmt]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_QuoDetailItem_UnitDiscntPerc]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_QuoDetailItem] DROP CONSTRAINT [DF_Job_QuoDetailItem_UnitDiscntPerc]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_QuoDetailItem_ForeignAmt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_QuoDetailItem] DROP CONSTRAINT [DF_Job_QuoDetailItem_ForeignAmt]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_QuoDetailItem_TotalAmt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_QuoDetailItem] DROP CONSTRAINT [DF_Job_QuoDetailItem_TotalAmt]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_QuoDetailItem_TaxAmt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_QuoDetailItem] DROP CONSTRAINT [DF_Job_QuoDetailItem_TaxAmt]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_QuoDetailItem_TaxRate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_QuoDetailItem] DROP CONSTRAINT [DF_Job_QuoDetailItem_TaxRate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_QuoDetailItem_IsTax]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_QuoDetailItem] DROP CONSTRAINT [DF_Job_QuoDetailItem_IsTax]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_QuoDetailItem_VatAmt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_QuoDetailItem] DROP CONSTRAINT [DF_Job_QuoDetailItem_VatAmt]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_QuoDetailItem_VatRate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_QuoDetailItem] DROP CONSTRAINT [DF_Job_QuoDetailItem_VatRate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_QuoDetailItem_Isvat]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_QuoDetailItem] DROP CONSTRAINT [DF_Job_QuoDetailItem_Isvat]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_QuoDetailItem_CurrencyRate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_QuoDetailItem] DROP CONSTRAINT [DF_Job_QuoDetailItem_CurrencyRate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_QuoDetailItem_UnitQTY]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_QuoDetailItem] DROP CONSTRAINT [DF_Job_QuoDetailItem_UnitQTY]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_QuoDetailItem_UnitCost]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_QuoDetailItem] DROP CONSTRAINT [DF_Job_QuoDetailItem_UnitCost]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_Revise]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_Revise]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_ForeignAmt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_ForeignAmt]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_ExchangeRate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_ExchangeRate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_PaidFlag]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_PaidFlag]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_TotalNet]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_TotalNet]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_TotalCustAdv]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_TotalCustAdv]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_Total50Tavi2]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_Total50Tavi2]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_Total50Tavi1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_Total50Tavi1]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_TotalVAT]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_TotalVAT]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_TotalIs50Tavi2]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_TotalIs50Tavi2]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_TotalIs50Tavi1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_TotalIs50Tavi1]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_TotalIsTaxCharge]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_TotalIsTaxCharge]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_TotalCharge]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_TotalCharge]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_TotalAdvance]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_TotalAdvance]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_Tavi50Rate2]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_Tavi50Rate2]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_Tavi50Rate1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_Tavi50Rate1]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_VATRate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_VATRate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentHeader_JobBillAmt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentHeader] DROP CONSTRAINT [DF_Job_PaymentHeader_JobBillAmt]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentDetail_FTotalAmt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentDetail] DROP CONSTRAINT [DF_Job_PaymentDetail_FTotalAmt]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentDetail_FQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentDetail] DROP CONSTRAINT [DF_Job_PaymentDetail_FQty]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentDetail_FUnitPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentDetail] DROP CONSTRAINT [DF_Job_PaymentDetail_FUnitPrice]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentDetail_ForeignDisc]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentDetail] DROP CONSTRAINT [DF_Job_PaymentDetail_ForeignDisc]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentDetail_AmtDiscount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentDetail] DROP CONSTRAINT [DF_Job_PaymentDetail_AmtDiscount]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentDetail_DiscountPerc]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentDetail] DROP CONSTRAINT [DF_Job_PaymentDetail_DiscountPerc]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentDetail_ForeignAmtCredit]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentDetail] DROP CONSTRAINT [DF_Job_PaymentDetail_ForeignAmtCredit]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentDetail_ExchangeRateCredit]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentDetail] DROP CONSTRAINT [DF_Job_PaymentDetail_ExchangeRateCredit]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentDetail_ExchangeRate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentDetail] DROP CONSTRAINT [DF_Job_PaymentDetail_ExchangeRate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentDetail_ForeignAmt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentDetail] DROP CONSTRAINT [DF_Job_PaymentDetail_ForeignAmt]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentDetail_AmtCharge]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentDetail] DROP CONSTRAINT [DF_Job_PaymentDetail_AmtCharge]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentDetail_AmtAdvance]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentDetail] DROP CONSTRAINT [DF_Job_PaymentDetail_AmtAdvance]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentDetail_Rate50Tavi]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentDetail] DROP CONSTRAINT [DF_Job_PaymentDetail_Rate50Tavi]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentDetail_Is50Tavi]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentDetail] DROP CONSTRAINT [DF_Job_PaymentDetail_Is50Tavi]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentDetail_IsTaxCharge]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentDetail] DROP CONSTRAINT [DF_Job_PaymentDetail_IsTaxCharge]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_PaymentDetail_ItemNo]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_PaymentDetail] DROP CONSTRAINT [DF_Job_PaymentDetail_ItemNo]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_KSACreditNote_TotalVAT]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_OSRCreditNote] DROP CONSTRAINT [DF_Job_KSACreditNote_TotalVAT]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_KSACreditNote_TotalCharge]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_OSRCreditNote] DROP CONSTRAINT [DF_Job_KSACreditNote_TotalCharge]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_BillingHeader_Revise]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_BillingHeader] DROP CONSTRAINT [DF_Job_BillingHeader_Revise]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_BillDSub_FTotalAmt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_BillingDetail] DROP CONSTRAINT [DF_Job_BillDSub_FTotalAmt]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_BillDSub_FQty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_BillingDetail] DROP CONSTRAINT [DF_Job_BillDSub_FQty]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_BillDSub_FUnitPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_BillingDetail] DROP CONSTRAINT [DF_Job_BillDSub_FUnitPrice]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_BillDSub_ForeignDisc]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_BillingDetail] DROP CONSTRAINT [DF_Job_BillDSub_ForeignDisc]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_BillDSub_AmtDiscount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_BillingDetail] DROP CONSTRAINT [DF_Job_BillDSub_AmtDiscount]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_BillDSub_DiscountPerc]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_BillingDetail] DROP CONSTRAINT [DF_Job_BillDSub_DiscountPerc]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_BillDSub_ForeignAmtCredit]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_BillingDetail] DROP CONSTRAINT [DF_Job_BillDSub_ForeignAmtCredit]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_BillDSub_ExchangeRateCredit]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_BillingDetail] DROP CONSTRAINT [DF_Job_BillDSub_ExchangeRateCredit]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_BillDSub_ExchangeRate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_BillingDetail] DROP CONSTRAINT [DF_Job_BillDSub_ExchangeRate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_BillDSub_ForeignAmt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_BillingDetail] DROP CONSTRAINT [DF_Job_BillDSub_ForeignAmt]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_BillDSub_AmtCharge]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_BillingDetail] DROP CONSTRAINT [DF_Job_BillDSub_AmtCharge]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_BillDSub_AmtAdvance]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_BillingDetail] DROP CONSTRAINT [DF_Job_BillDSub_AmtAdvance]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_BillDSub_Rate50Tavi]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_BillingDetail] DROP CONSTRAINT [DF_Job_BillDSub_Rate50Tavi]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_BillDSub_Is50Tavi]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_BillingDetail] DROP CONSTRAINT [DF_Job_BillDSub_Is50Tavi]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_BillDSub_IsTaxCharge]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_BillingDetail] DROP CONSTRAINT [DF_Job_BillDSub_IsTaxCharge]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Job_BillDSub_ItemNo]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_BillingDetail] DROP CONSTRAINT [DF_Job_BillDSub_ItemNo]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__Job_AdvHe__Excha__54425081]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_AdvHeader] DROP CONSTRAINT [DF__Job_AdvHe__Excha__54425081]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__Job_AdvDe__UnitP__571EBD2C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_AdvDetail] DROP CONSTRAINT [DF__Job_AdvDe__UnitP__571EBD2C]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__Job_AdvDe__AdvQt__562A98F3]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_AdvDetail] DROP CONSTRAINT [DF__Job_AdvDe__AdvQt__562A98F3]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__Job_AdvDe__Excha__553674BA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Job_AdvDetail] DROP CONSTRAINT [DF__Job_AdvDe__Excha__553674BA]
END
GO
/****** Object:  Index [IDX_BudgetPolicy]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[Job_BudgetPolicy]') AND name = N'IDX_BudgetPolicy')
DROP INDEX [IDX_BudgetPolicy] ON [dbo].[Job_BudgetPolicy]
GO
/****** Object:  View [dbo].[vChequeHeader]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vChequeHeader]'))
DROP VIEW [dbo].[vChequeHeader]
GO
/****** Object:  View [dbo].[vCheque]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vCheque]'))
DROP VIEW [dbo].[vCheque]
GO
/****** Object:  View [dbo].[vADV_UnClear]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vADV_UnClear]'))
DROP VIEW [dbo].[vADV_UnClear]
GO
/****** Object:  View [dbo].[vAdv_all]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vAdv_all]'))
DROP VIEW [dbo].[vAdv_all]
GO
/****** Object:  View [dbo].[qReport_Job_Billing]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qReport_Job_Billing]'))
DROP VIEW [dbo].[qReport_Job_Billing]
GO
/****** Object:  View [dbo].[qJob_TaxInvHeader]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_TaxInvHeader]'))
DROP VIEW [dbo].[qJob_TaxInvHeader]
GO
/****** Object:  View [dbo].[qJob_TaxInvDetail]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_TaxInvDetail]'))
DROP VIEW [dbo].[qJob_TaxInvDetail]
GO
/****** Object:  View [dbo].[qJob_Tax50Tavi]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_Tax50Tavi]'))
DROP VIEW [dbo].[qJob_Tax50Tavi]
GO
/****** Object:  View [dbo].[qJob_SumCost]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_SumCost]'))
DROP VIEW [dbo].[qJob_SumCost]
GO
/****** Object:  View [dbo].[qJob_Shipping]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_Shipping]'))
DROP VIEW [dbo].[qJob_Shipping]
GO
/****** Object:  View [dbo].[qJob_RefundTax]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_RefundTax]'))
DROP VIEW [dbo].[qJob_RefundTax]
GO
/****** Object:  View [dbo].[qJob_Quotation]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_Quotation]'))
DROP VIEW [dbo].[qJob_Quotation]
GO
/****** Object:  View [dbo].[qJob_PayHeader]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_PayHeader]'))
DROP VIEW [dbo].[qJob_PayHeader]
GO
/****** Object:  View [dbo].[qJob_PayDetail]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_PayDetail]'))
DROP VIEW [dbo].[qJob_PayDetail]
GO
/****** Object:  View [dbo].[qJob_LoadInfo]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_LoadInfo]'))
DROP VIEW [dbo].[qJob_LoadInfo]
GO
/****** Object:  View [dbo].[qJob_Document]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_Document]'))
DROP VIEW [dbo].[qJob_Document]
GO
/****** Object:  View [dbo].[qJob_DebitNote]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_DebitNote]'))
DROP VIEW [dbo].[qJob_DebitNote]
GO
/****** Object:  View [dbo].[qJob_CustAdvChqSub]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_CustAdvChqSub]'))
DROP VIEW [dbo].[qJob_CustAdvChqSub]
GO
/****** Object:  View [dbo].[qJob_CustAdvance]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_CustAdvance]'))
DROP VIEW [dbo].[qJob_CustAdvance]
GO
/****** Object:  View [dbo].[qJob_CoPersonSlip]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_CoPersonSlip]'))
DROP VIEW [dbo].[qJob_CoPersonSlip]
GO
/****** Object:  View [dbo].[qJob_Controls]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_Controls]'))
DROP VIEW [dbo].[qJob_Controls]
GO
/****** Object:  View [dbo].[qJob_ClearMJob]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_ClearMJob]'))
DROP VIEW [dbo].[qJob_ClearMJob]
GO
/****** Object:  View [dbo].[qJob_AdvMJob]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_AdvMJob]'))
DROP VIEW [dbo].[qJob_AdvMJob]
GO
/****** Object:  View [dbo].[QE_ListSelectJob]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[QE_ListSelectJob]'))
DROP VIEW [dbo].[QE_ListSelectJob]
GO
/****** Object:  View [dbo].[QE_InvoiceAPDetail]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[QE_InvoiceAPDetail]'))
DROP VIEW [dbo].[QE_InvoiceAPDetail]
GO
/****** Object:  View [dbo].[QE_CustAdvanceCheqHeader]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[QE_CustAdvanceCheqHeader]'))
DROP VIEW [dbo].[QE_CustAdvanceCheqHeader]
GO
/****** Object:  View [dbo].[QE_Clearing]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[QE_Clearing]'))
DROP VIEW [dbo].[QE_Clearing]
GO
/****** Object:  View [dbo].[QE_Advance]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[QE_Advance]'))
DROP VIEW [dbo].[QE_Advance]
GO
/****** Object:  View [dbo].[qAlert_M001]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qAlert_M001]'))
DROP VIEW [dbo].[qAlert_M001]
GO
/****** Object:  View [dbo].[qJob_RClearExp]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_RClearExp]'))
DROP VIEW [dbo].[qJob_RClearExp]
GO
/****** Object:  View [dbo].[q_StateMentAccount_V2]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[q_StateMentAccount_V2]'))
DROP VIEW [dbo].[q_StateMentAccount_V2]
GO
/****** Object:  View [dbo].[q_RcvExport]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[q_RcvExport]'))
DROP VIEW [dbo].[q_RcvExport]
GO
/****** Object:  View [dbo].[qGL_CustAdvChq]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qGL_CustAdvChq]'))
DROP VIEW [dbo].[qGL_CustAdvChq]
GO
/****** Object:  View [dbo].[qJob_CustAdvChq]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_CustAdvChq]'))
DROP VIEW [dbo].[qJob_CustAdvChq]
GO
/****** Object:  View [dbo].[qGL_RcvAR]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qGL_RcvAR]'))
DROP VIEW [dbo].[qGL_RcvAR]
GO
/****** Object:  View [dbo].[qGL_RcvEarnest]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qGL_RcvEarnest]'))
DROP VIEW [dbo].[qGL_RcvEarnest]
GO
/****** Object:  View [dbo].[qGL_SetEarnest]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qGL_SetEarnest]'))
DROP VIEW [dbo].[qGL_SetEarnest]
GO
/****** Object:  View [dbo].[Q_FinancialSalesReport]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Q_FinancialSalesReport]'))
DROP VIEW [dbo].[Q_FinancialSalesReport]
GO
/****** Object:  View [dbo].[Q_FinancialCostReport]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Q_FinancialCostReport]'))
DROP VIEW [dbo].[Q_FinancialCostReport]
GO
/****** Object:  View [dbo].[qJob_RSlip]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_RSlip]'))
DROP VIEW [dbo].[qJob_RSlip]
GO
/****** Object:  View [dbo].[Q_ClearEarness]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Q_ClearEarness]'))
DROP VIEW [dbo].[Q_ClearEarness]
GO
/****** Object:  View [dbo].[qJob_AdvDetail]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_AdvDetail]'))
DROP VIEW [dbo].[qJob_AdvDetail]
GO
/****** Object:  View [dbo].[Q_ReportCostAndProfit]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Q_ReportCostAndProfit]'))
DROP VIEW [dbo].[Q_ReportCostAndProfit]
GO
/****** Object:  View [dbo].[Q_ProfitCalculate]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Q_ProfitCalculate]'))
DROP VIEW [dbo].[Q_ProfitCalculate]
GO
/****** Object:  View [dbo].[qrpt_SalseState]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qrpt_SalseState]'))
DROP VIEW [dbo].[qrpt_SalseState]
GO
/****** Object:  View [dbo].[qrpt_CostState]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qrpt_CostState]'))
DROP VIEW [dbo].[qrpt_CostState]
GO
/****** Object:  View [dbo].[qrpt_ksat_Biggg]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qrpt_ksat_Biggg]'))
DROP VIEW [dbo].[qrpt_ksat_Biggg]
GO
/****** Object:  View [dbo].[vKPI_Summary]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vKPI_Summary]'))
DROP VIEW [dbo].[vKPI_Summary]
GO
/****** Object:  View [dbo].[vKPI]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vKPI]'))
DROP VIEW [dbo].[vKPI]
GO
/****** Object:  View [dbo].[vJob_TrackingOper]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vJob_TrackingOper]'))
DROP VIEW [dbo].[vJob_TrackingOper]
GO
/****** Object:  View [dbo].[vKPI_AdvanceSum]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vKPI_AdvanceSum]'))
DROP VIEW [dbo].[vKPI_AdvanceSum]
GO
/****** Object:  View [dbo].[vJob_CodeSum]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vJob_CodeSum]'))
DROP VIEW [dbo].[vJob_CodeSum]
GO
/****** Object:  View [dbo].[vJob_Profit]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vJob_Profit]'))
DROP VIEW [dbo].[vJob_Profit]
GO
/****** Object:  View [dbo].[vJob_Summary]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vJob_Summary]'))
DROP VIEW [dbo].[vJob_Summary]
GO
/****** Object:  View [dbo].[vJob_NoInvoice]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vJob_NoInvoice]'))
DROP VIEW [dbo].[vJob_NoInvoice]
GO
/****** Object:  View [dbo].[vJob_Invoice]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vJob_Invoice]'))
DROP VIEW [dbo].[vJob_Invoice]
GO
/****** Object:  View [dbo].[QE_CashControlDoc]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[QE_CashControlDoc]'))
DROP VIEW [dbo].[QE_CashControlDoc]
GO
/****** Object:  View [dbo].[vJob_Count]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vJob_Count]'))
DROP VIEW [dbo].[vJob_Count]
GO
/****** Object:  View [dbo].[QE_CashControlSub]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[QE_CashControlSub]'))
DROP VIEW [dbo].[QE_CashControlSub]
GO
/****** Object:  View [dbo].[QE_CashControlHeder]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[QE_CashControlHeder]'))
DROP VIEW [dbo].[QE_CashControlHeder]
GO
/****** Object:  View [dbo].[vJob_Volume]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vJob_Volume]'))
DROP VIEW [dbo].[vJob_Volume]
GO
/****** Object:  View [dbo].[QE_CashControlRefJob]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[QE_CashControlRefJob]'))
DROP VIEW [dbo].[QE_CashControlRefJob]
GO
/****** Object:  View [dbo].[QE_UnionCashJob]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[QE_UnionCashJob]'))
DROP VIEW [dbo].[QE_UnionCashJob]
GO
/****** Object:  View [dbo].[vJob_VolumeByCust]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vJob_VolumeByCust]'))
DROP VIEW [dbo].[vJob_VolumeByCust]
GO
/****** Object:  View [dbo].[vKPI_Advance]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vKPI_Advance]'))
DROP VIEW [dbo].[vKPI_Advance]
GO
/****** Object:  View [dbo].[qJob_ClearHeader]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_ClearHeader]'))
DROP VIEW [dbo].[qJob_ClearHeader]
GO
/****** Object:  View [dbo].[qJob_AdvHeader]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_AdvHeader]'))
DROP VIEW [dbo].[qJob_AdvHeader]
GO
/****** Object:  View [dbo].[QE_QoutationDetail]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[QE_QoutationDetail]'))
DROP VIEW [dbo].[QE_QoutationDetail]
GO
/****** Object:  View [dbo].[QE_QuoDetailItem]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[QE_QuoDetailItem]'))
DROP VIEW [dbo].[QE_QuoDetailItem]
GO
/****** Object:  View [dbo].[QE_QuotationHeader]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[QE_QuotationHeader]'))
DROP VIEW [dbo].[QE_QuotationHeader]
GO
/****** Object:  View [dbo].[View_RefClr]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[View_RefClr]'))
DROP VIEW [dbo].[View_RefClr]
GO
/****** Object:  View [dbo].[Q_StatementAccount]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Q_StatementAccount]'))
DROP VIEW [dbo].[Q_StatementAccount]
GO
/****** Object:  View [dbo].[Q_VouherStateOne]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Q_VouherStateOne]'))
DROP VIEW [dbo].[Q_VouherStateOne]
GO
/****** Object:  View [dbo].[Q_PaymentRef]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Q_PaymentRef]'))
DROP VIEW [dbo].[Q_PaymentRef]
GO
/****** Object:  View [dbo].[Q_VouherStateTwo]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Q_VouherStateTwo]'))
DROP VIEW [dbo].[Q_VouherStateTwo]
GO
/****** Object:  View [dbo].[Q_TaxExport]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Q_TaxExport]'))
DROP VIEW [dbo].[Q_TaxExport]
GO
/****** Object:  View [dbo].[qGL_SetAR]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qGL_SetAR]'))
DROP VIEW [dbo].[qGL_SetAR]
GO
/****** Object:  View [dbo].[vAdv_Balance]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vAdv_Balance]'))
DROP VIEW [dbo].[vAdv_Balance]
GO
/****** Object:  View [dbo].[Q_CostJoinProfit]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Q_CostJoinProfit]'))
DROP VIEW [dbo].[Q_CostJoinProfit]
GO
/****** Object:  View [dbo].[Q_ProfitCost]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Q_ProfitCost]'))
DROP VIEW [dbo].[Q_ProfitCost]
GO
/****** Object:  View [dbo].[qJob_Detail]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_Detail]'))
DROP VIEW [dbo].[qJob_Detail]
GO
/****** Object:  View [dbo].[Q_ProfitSales]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Q_ProfitSales]'))
DROP VIEW [dbo].[Q_ProfitSales]
GO
/****** Object:  View [dbo].[qrpt_TaxInvThirdStep]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qrpt_TaxInvThirdStep]'))
DROP VIEW [dbo].[qrpt_TaxInvThirdStep]
GO
/****** Object:  View [dbo].[qrpt_TaxInvSecondStep]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qrpt_TaxInvSecondStep]'))
DROP VIEW [dbo].[qrpt_TaxInvSecondStep]
GO
/****** Object:  View [dbo].[qrpt_TaxInvFristStep]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qrpt_TaxInvFristStep]'))
DROP VIEW [dbo].[qrpt_TaxInvFristStep]
GO
/****** Object:  View [dbo].[qJob_TrackingSum]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_TrackingSum]'))
DROP VIEW [dbo].[qJob_TrackingSum]
GO
/****** Object:  View [dbo].[qJob_ClearDetail]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_ClearDetail]'))
DROP VIEW [dbo].[qJob_ClearDetail]
GO
/****** Object:  View [dbo].[qJob_Tracking]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_Tracking]'))
DROP VIEW [dbo].[qJob_Tracking]
GO
/****** Object:  View [dbo].[qJob_CashControl]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_CashControl]'))
DROP VIEW [dbo].[qJob_CashControl]
GO
/****** Object:  View [dbo].[qJob_BillAnnSub]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_BillAnnSub]'))
DROP VIEW [dbo].[qJob_BillAnnSub]
GO
/****** Object:  View [dbo].[qJob_BillHeader]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_BillHeader]'))
DROP VIEW [dbo].[qJob_BillHeader]
GO
/****** Object:  View [dbo].[vJOB_DocAmount]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vJOB_DocAmount]'))
DROP VIEW [dbo].[vJOB_DocAmount]
GO
/****** Object:  View [dbo].[qJob_BillBalance]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_BillBalance]'))
DROP VIEW [dbo].[qJob_BillBalance]
GO
/****** Object:  View [dbo].[qJob_Order]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_Order]'))
DROP VIEW [dbo].[qJob_Order]
GO
/****** Object:  View [dbo].[qJob_DebitNoteSub]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_DebitNoteSub]'))
DROP VIEW [dbo].[qJob_DebitNoteSub]
GO
/****** Object:  View [dbo].[qJob_BillDetail]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[qJob_BillDetail]'))
DROP VIEW [dbo].[qJob_BillDetail]
GO
/****** Object:  Table [dbo].[Tracking8]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tracking8]') AND type in (N'U'))
DROP TABLE [dbo].[Tracking8]
GO
/****** Object:  Table [dbo].[Tracking7]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tracking7]') AND type in (N'U'))
DROP TABLE [dbo].[Tracking7]
GO
/****** Object:  Table [dbo].[Tracking6]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tracking6]') AND type in (N'U'))
DROP TABLE [dbo].[Tracking6]
GO
/****** Object:  Table [dbo].[Tracking5]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tracking5]') AND type in (N'U'))
DROP TABLE [dbo].[Tracking5]
GO
/****** Object:  Table [dbo].[Tracking4]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tracking4]') AND type in (N'U'))
DROP TABLE [dbo].[Tracking4]
GO
/****** Object:  Table [dbo].[Tracking3]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tracking3]') AND type in (N'U'))
DROP TABLE [dbo].[Tracking3]
GO
/****** Object:  Table [dbo].[Tracking2]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tracking2]') AND type in (N'U'))
DROP TABLE [dbo].[Tracking2]
GO
/****** Object:  Table [dbo].[Tracking1]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tracking1]') AND type in (N'U'))
DROP TABLE [dbo].[Tracking1]
GO
/****** Object:  Table [dbo].[NSM$]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NSM$]') AND type in (N'U'))
DROP TABLE [dbo].[NSM$]
GO
/****** Object:  Table [dbo].[Mas_Vessel]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_Vessel]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_Vessel]
GO
/****** Object:  Table [dbo].[Mas_Vender]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_Vender]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_Vender]
GO
/****** Object:  Table [dbo].[Mas_UserRolePolicy]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_UserRolePolicy]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_UserRolePolicy]
GO
/****** Object:  Table [dbo].[Mas_UserRoleDetail]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_UserRoleDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_UserRoleDetail]
GO
/****** Object:  Table [dbo].[Mas_UserRole]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_UserRole]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_UserRole]
GO
/****** Object:  Table [dbo].[Mas_UserAuth]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_UserAuth]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_UserAuth]
GO
/****** Object:  Table [dbo].[Mas_User]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_User]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_User]
GO
/****** Object:  Table [dbo].[Mas_TaxCode]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_TaxCode]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_TaxCode]
GO
/****** Object:  Table [dbo].[Mas_ServUnitType]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_ServUnitType]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_ServUnitType]
GO
/****** Object:  Table [dbo].[Mas_RFWTO]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFWTO]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFWTO]
GO
/****** Object:  Table [dbo].[Mas_RFUNT]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFUNT]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFUNT]
GO
/****** Object:  Table [dbo].[Mas_RFTRS]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFTRS]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFTRS]
GO
/****** Object:  Table [dbo].[Mas_RFTRC]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFTRC]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFTRC]
GO
/****** Object:  Table [dbo].[Mas_RFPMS]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFPMS]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFPMS]
GO
/****** Object:  Table [dbo].[Mas_RFPMG]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFPMG]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFPMG]
GO
/****** Object:  Table [dbo].[Mas_RFIPN]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFIPN]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFIPN]
GO
/****** Object:  Table [dbo].[Mas_RFIPC]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFIPC]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFIPC]
GO
/****** Object:  Table [dbo].[Mas_RFICU]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFICU]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFICU]
GO
/****** Object:  Table [dbo].[Mas_RFICD]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFICD]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFICD]
GO
/****** Object:  Table [dbo].[Mas_RFICC]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFICC]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFICC]
GO
/****** Object:  Table [dbo].[Mas_RFGTY]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFGTY]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFGTY]
GO
/****** Object:  Table [dbo].[Mas_RFFMU]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFFMU]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFFMU]
GO
/****** Object:  Table [dbo].[Mas_RFFCU]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFFCU]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFFCU]
GO
/****** Object:  Table [dbo].[Mas_RFEXP]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFEXP]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFEXP]
GO
/****** Object:  Table [dbo].[Mas_RFETB]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFETB]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFETB]
GO
/****** Object:  Table [dbo].[Mas_RFERT]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFERT]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFERT]
GO
/****** Object:  Table [dbo].[Mas_RFEDR]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFEDR]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFEDR]
GO
/****** Object:  Table [dbo].[Mas_RFECU]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFECU]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFECU]
GO
/****** Object:  Table [dbo].[Mas_RFECS]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFECS]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFECS]
GO
/****** Object:  Table [dbo].[Mas_RFDTB]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFDTB]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFDTB]
GO
/****** Object:  Table [dbo].[Mas_RFDRT]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFDRT]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFDRT]
GO
/****** Object:  Table [dbo].[Mas_RFDCT]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFDCT]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFDCT]
GO
/****** Object:  Table [dbo].[Mas_RFCTR]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFCTR]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFCTR]
GO
/****** Object:  Table [dbo].[Mas_RFCKD]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFCKD]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFCKD]
GO
/****** Object:  Table [dbo].[Mas_RFCEP]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFCEP]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFCEP]
GO
/****** Object:  Table [dbo].[Mas_RFBQT]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFBQT]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFBQT]
GO
/****** Object:  Table [dbo].[Mas_RFBOI]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFBOI]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFBOI]
GO
/****** Object:  Table [dbo].[Mas_RFBFM]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFBFM]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFBFM]
GO
/****** Object:  Table [dbo].[Mas_RFATA]    Script Date: 08-Mar-19 11:31:23 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFATA]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFATA]
GO
/****** Object:  Table [dbo].[Mas_RFARS]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_RFARS]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_RFARS]
GO
/****** Object:  Table [dbo].[Mas_Register]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_Register]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_Register]
GO
/****** Object:  Table [dbo].[Mas_REFTRS]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_REFTRS]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_REFTRS]
GO
/****** Object:  Table [dbo].[Mas_REFTRC]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_REFTRC]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_REFTRC]
GO
/****** Object:  Table [dbo].[Mas_REFSSG]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_REFSSG]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_REFSSG]
GO
/****** Object:  Table [dbo].[Mas_REFPVL]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_REFPVL]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_REFPVL]
GO
/****** Object:  Table [dbo].[Mas_REFPVC]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_REFPVC]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_REFPVC]
GO
/****** Object:  Table [dbo].[Mas_REFIPC]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_REFIPC]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_REFIPC]
GO
/****** Object:  Table [dbo].[Mas_REFIDR]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_REFIDR]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_REFIDR]
GO
/****** Object:  Table [dbo].[Mas_REFEDR]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_REFEDR]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_REFEDR]
GO
/****** Object:  Table [dbo].[Mas_ProvinceSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_ProvinceSub]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_ProvinceSub]
GO
/****** Object:  Table [dbo].[Mas_Province]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_Province]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_Province]
GO
/****** Object:  Table [dbo].[Mas_ProductSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_ProductSub]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_ProductSub]
GO
/****** Object:  Table [dbo].[Mas_ProductMark]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_ProductMark]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_ProductMark]
GO
/****** Object:  Table [dbo].[Mas_Product]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_Product]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_Product]
GO
/****** Object:  Table [dbo].[Mas_PermitIssue]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_PermitIssue]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_PermitIssue]
GO
/****** Object:  Table [dbo].[Mas_PdtGroup]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_PdtGroup]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_PdtGroup]
GO
/****** Object:  Table [dbo].[Mas_Manager]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_Manager]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_Manager]
GO
/****** Object:  Table [dbo].[Mas_LoadCause]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_LoadCause]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_LoadCause]
GO
/****** Object:  Table [dbo].[Mas_InvUnit]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_InvUnit]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_InvUnit]
GO
/****** Object:  Table [dbo].[Mas_InvExpense]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_InvExpense]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_InvExpense]
GO
/****** Object:  Table [dbo].[Mas_HistoryLog]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_HistoryLog]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_HistoryLog]
GO
/****** Object:  Table [dbo].[MAS_GLACCOUNT]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MAS_GLACCOUNT]') AND type in (N'U'))
DROP TABLE [dbo].[MAS_GLACCOUNT]
GO
/****** Object:  Table [dbo].[Mas_Factory]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_Factory]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_Factory]
GO
/****** Object:  Table [dbo].[Mas_DocType]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_DocType]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_DocType]
GO
/****** Object:  Table [dbo].[Mas_CustCredit]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_CustCredit]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_CustCredit]
GO
/****** Object:  Table [dbo].[Mas_CustContact]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_CustContact]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_CustContact]
GO
/****** Object:  Table [dbo].[Mas_CurrencyCode]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_CurrencyCode]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_CurrencyCode]
GO
/****** Object:  Table [dbo].[Mas_CountryFT]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_CountryFT]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_CountryFT]
GO
/****** Object:  Table [dbo].[Mas_ConsignTo]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_ConsignTo]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_ConsignTo]
GO
/****** Object:  Table [dbo].[Mas_Consignee]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_Consignee]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_Consignee]
GO
/****** Object:  Table [dbo].[Mas_Config]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_Config]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_Config]
GO
/****** Object:  Table [dbo].[Mas_Company]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_Company]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_Company]
GO
/****** Object:  Table [dbo].[Mas_CompAccess]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_CompAccess]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_CompAccess]
GO
/****** Object:  Table [dbo].[Mas_Broker]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_Broker]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_Broker]
GO
/****** Object:  Table [dbo].[Mas_Branch]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_Branch]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_Branch]
GO
/****** Object:  Table [dbo].[Mas_BookAccount]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_BookAccount]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_BookAccount]
GO
/****** Object:  Table [dbo].[Mas_BankCode]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_BankCode]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_BankCode]
GO
/****** Object:  Table [dbo].[Mas_Agent]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mas_Agent]') AND type in (N'U'))
DROP TABLE [dbo].[Mas_Agent]
GO
/****** Object:  Table [dbo].[Job_WHTaxDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_WHTaxDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_WHTaxDetail]
GO
/****** Object:  Table [dbo].[Job_WHTax]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_WHTax]') AND type in (N'U'))
DROP TABLE [dbo].[Job_WHTax]
GO
/****** Object:  Table [dbo].[Job_TruckOrder]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_TruckOrder]') AND type in (N'U'))
DROP TABLE [dbo].[Job_TruckOrder]
GO
/****** Object:  Table [dbo].[Job_Transport]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_Transport]') AND type in (N'U'))
DROP TABLE [dbo].[Job_Transport]
GO
/****** Object:  Table [dbo].[Job_TaxInvoiceDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_TaxInvoiceDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_TaxInvoiceDetail]
GO
/****** Object:  Table [dbo].[Job_TaxInvoice]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_TaxInvoice]') AND type in (N'U'))
DROP TABLE [dbo].[Job_TaxInvoice]
GO
/****** Object:  Table [dbo].[Job_Tax50Tavi]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_Tax50Tavi]') AND type in (N'U'))
DROP TABLE [dbo].[Job_Tax50Tavi]
GO
/****** Object:  Table [dbo].[Job_SrvTemplateSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_SrvTemplateSub]') AND type in (N'U'))
DROP TABLE [dbo].[Job_SrvTemplateSub]
GO
/****** Object:  Table [dbo].[Job_SrvTemplate]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_SrvTemplate]') AND type in (N'U'))
DROP TABLE [dbo].[Job_SrvTemplate]
GO
/****** Object:  Table [dbo].[Job_SrvStepCost]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_SrvStepCost]') AND type in (N'U'))
DROP TABLE [dbo].[Job_SrvStepCost]
GO
/****** Object:  Table [dbo].[Job_SrvStep]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_SrvStep]') AND type in (N'U'))
DROP TABLE [dbo].[Job_SrvStep]
GO
/****** Object:  Table [dbo].[Job_SrvSingleCost]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_SrvSingleCost]') AND type in (N'U'))
DROP TABLE [dbo].[Job_SrvSingleCost]
GO
/****** Object:  Table [dbo].[Job_SrvSingle]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_SrvSingle]') AND type in (N'U'))
DROP TABLE [dbo].[Job_SrvSingle]
GO
/****** Object:  Table [dbo].[Job_SrvGroup]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_SrvGroup]') AND type in (N'U'))
DROP TABLE [dbo].[Job_SrvGroup]
GO
/****** Object:  Table [dbo].[Job_SrvAirCost]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_SrvAirCost]') AND type in (N'U'))
DROP TABLE [dbo].[Job_SrvAirCost]
GO
/****** Object:  Table [dbo].[Job_SrvAirCharge]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_SrvAirCharge]') AND type in (N'U'))
DROP TABLE [dbo].[Job_SrvAirCharge]
GO
/****** Object:  Table [dbo].[Job_SrvAccount]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_SrvAccount]') AND type in (N'U'))
DROP TABLE [dbo].[Job_SrvAccount]
GO
/****** Object:  Table [dbo].[Job_ServicePolicy]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_ServicePolicy]') AND type in (N'U'))
DROP TABLE [dbo].[Job_ServicePolicy]
GO
/****** Object:  Table [dbo].[Job_RSlipSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_RSlipSub]') AND type in (N'U'))
DROP TABLE [dbo].[Job_RSlipSub]
GO
/****** Object:  Table [dbo].[Job_RSlip]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_RSlip]') AND type in (N'U'))
DROP TABLE [dbo].[Job_RSlip]
GO
/****** Object:  Table [dbo].[Job_RefundTaxHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_RefundTaxHeader]') AND type in (N'U'))
DROP TABLE [dbo].[Job_RefundTaxHeader]
GO
/****** Object:  Table [dbo].[Job_RefundTaxDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_RefundTaxDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_RefundTaxDetail]
GO
/****** Object:  Table [dbo].[Job_ReceiptHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_ReceiptHeader]') AND type in (N'U'))
DROP TABLE [dbo].[Job_ReceiptHeader]
GO
/****** Object:  Table [dbo].[Job_ReceiptDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_ReceiptDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_ReceiptDetail]
GO
/****** Object:  Table [dbo].[Job_RClearExpSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_RClearExpSub]') AND type in (N'U'))
DROP TABLE [dbo].[Job_RClearExpSub]
GO
/****** Object:  Table [dbo].[Job_RClearExp]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_RClearExp]') AND type in (N'U'))
DROP TABLE [dbo].[Job_RClearExp]
GO
/****** Object:  Table [dbo].[Job_QuotationItem]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_QuotationItem]') AND type in (N'U'))
DROP TABLE [dbo].[Job_QuotationItem]
GO
/****** Object:  Table [dbo].[Job_QuotationHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_QuotationHeader]') AND type in (N'U'))
DROP TABLE [dbo].[Job_QuotationHeader]
GO
/****** Object:  Table [dbo].[Job_QuotationDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_QuotationDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_QuotationDetail]
GO
/****** Object:  Table [dbo].[Job_QuoHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_QuoHeader]') AND type in (N'U'))
DROP TABLE [dbo].[Job_QuoHeader]
GO
/****** Object:  Table [dbo].[Job_QuoDetailItem]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_QuoDetailItem]') AND type in (N'U'))
DROP TABLE [dbo].[Job_QuoDetailItem]
GO
/****** Object:  Table [dbo].[Job_QuoDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_QuoDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_QuoDetail]
GO
/****** Object:  Table [dbo].[Job_PaymentHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_PaymentHeader]') AND type in (N'U'))
DROP TABLE [dbo].[Job_PaymentHeader]
GO
/****** Object:  Table [dbo].[Job_PaymentDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_PaymentDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_PaymentDetail]
GO
/****** Object:  Table [dbo].[Job_OSRCreditNote]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_OSRCreditNote]') AND type in (N'U'))
DROP TABLE [dbo].[Job_OSRCreditNote]
GO
/****** Object:  Table [dbo].[Job_OrderLog]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_OrderLog]') AND type in (N'U'))
DROP TABLE [dbo].[Job_OrderLog]
GO
/****** Object:  Table [dbo].[Job_Order]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_Order]') AND type in (N'U'))
DROP TABLE [dbo].[Job_Order]
GO
/****** Object:  Table [dbo].[Job_LoadInfoDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_LoadInfoDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_LoadInfoDetail]
GO
/****** Object:  Table [dbo].[Job_LoadInfo]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_LoadInfo]') AND type in (N'U'))
DROP TABLE [dbo].[Job_LoadInfo]
GO
/****** Object:  Table [dbo].[Job_InvoiceHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_InvoiceHeader]') AND type in (N'U'))
DROP TABLE [dbo].[Job_InvoiceHeader]
GO
/****** Object:  Table [dbo].[Job_InvoiceDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_InvoiceDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_InvoiceDetail]
GO
/****** Object:  Table [dbo].[Job_GLHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_GLHeader]') AND type in (N'U'))
DROP TABLE [dbo].[Job_GLHeader]
GO
/****** Object:  Table [dbo].[Job_GLDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_GLDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_GLDetail]
GO
/****** Object:  Table [dbo].[Job_Document]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_Document]') AND type in (N'U'))
DROP TABLE [dbo].[Job_Document]
GO
/****** Object:  Table [dbo].[Job_DocPolicy]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_DocPolicy]') AND type in (N'U'))
DROP TABLE [dbo].[Job_DocPolicy]
GO
/****** Object:  Table [dbo].[Job_DocFollow]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_DocFollow]') AND type in (N'U'))
DROP TABLE [dbo].[Job_DocFollow]
GO
/****** Object:  Table [dbo].[Job_DetailOption]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_DetailOption]') AND type in (N'U'))
DROP TABLE [dbo].[Job_DetailOption]
GO
/****** Object:  Table [dbo].[Job_Detail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_Detail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_Detail]
GO
/****** Object:  Table [dbo].[Job_Delivery]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_Delivery]') AND type in (N'U'))
DROP TABLE [dbo].[Job_Delivery]
GO
/****** Object:  Table [dbo].[Job_DebitNoteSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_DebitNoteSub]') AND type in (N'U'))
DROP TABLE [dbo].[Job_DebitNoteSub]
GO
/****** Object:  Table [dbo].[Job_DebitNote]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_DebitNote]') AND type in (N'U'))
DROP TABLE [dbo].[Job_DebitNote]
GO
/****** Object:  Table [dbo].[Job_CustExp]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_CustExp]') AND type in (N'U'))
DROP TABLE [dbo].[Job_CustExp]
GO
/****** Object:  Table [dbo].[Job_CustAdvHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_CustAdvHeader]') AND type in (N'U'))
DROP TABLE [dbo].[Job_CustAdvHeader]
GO
/****** Object:  Table [dbo].[Job_CustAdvDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_CustAdvDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_CustAdvDetail]
GO
/****** Object:  Table [dbo].[Job_CustAdvChqSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_CustAdvChqSub]') AND type in (N'U'))
DROP TABLE [dbo].[Job_CustAdvChqSub]
GO
/****** Object:  Table [dbo].[Job_CustAdvChqDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_CustAdvChqDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_CustAdvChqDetail]
GO
/****** Object:  Table [dbo].[Job_CustAdvChq]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_CustAdvChq]') AND type in (N'U'))
DROP TABLE [dbo].[Job_CustAdvChq]
GO
/****** Object:  Table [dbo].[Job_CPolicyHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_CPolicyHeader]') AND type in (N'U'))
DROP TABLE [dbo].[Job_CPolicyHeader]
GO
/****** Object:  Table [dbo].[Job_CPolicyDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_CPolicyDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_CPolicyDetail]
GO
/****** Object:  Table [dbo].[Job_CoPersonSlipSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_CoPersonSlipSub]') AND type in (N'U'))
DROP TABLE [dbo].[Job_CoPersonSlipSub]
GO
/****** Object:  Table [dbo].[Job_CoPersonSlip]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_CoPersonSlip]') AND type in (N'U'))
DROP TABLE [dbo].[Job_CoPersonSlip]
GO
/****** Object:  Table [dbo].[Job_Controls]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_Controls]') AND type in (N'U'))
DROP TABLE [dbo].[Job_Controls]
GO
/****** Object:  Table [dbo].[Job_CNDNHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_CNDNHeader]') AND type in (N'U'))
DROP TABLE [dbo].[Job_CNDNHeader]
GO
/****** Object:  Table [dbo].[Job_CNDNDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_CNDNDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_CNDNDetail]
GO
/****** Object:  Table [dbo].[Job_ClearMJob]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_ClearMJob]') AND type in (N'U'))
DROP TABLE [dbo].[Job_ClearMJob]
GO
/****** Object:  Table [dbo].[Job_ClearHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_ClearHeader]') AND type in (N'U'))
DROP TABLE [dbo].[Job_ClearHeader]
GO
/****** Object:  Table [dbo].[Job_ClearExp]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_ClearExp]') AND type in (N'U'))
DROP TABLE [dbo].[Job_ClearExp]
GO
/****** Object:  Table [dbo].[Job_ClearDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_ClearDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_ClearDetail]
GO
/****** Object:  Table [dbo].[Job_CashFlow]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_CashFlow]') AND type in (N'U'))
DROP TABLE [dbo].[Job_CashFlow]
GO
/****** Object:  Table [dbo].[Job_CashControlSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_CashControlSub]') AND type in (N'U'))
DROP TABLE [dbo].[Job_CashControlSub]
GO
/****** Object:  Table [dbo].[Job_CashControlDoc]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_CashControlDoc]') AND type in (N'U'))
DROP TABLE [dbo].[Job_CashControlDoc]
GO
/****** Object:  Table [dbo].[Job_CashControl]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_CashControl]') AND type in (N'U'))
DROP TABLE [dbo].[Job_CashControl]
GO
/****** Object:  Table [dbo].[Job_BudgetPolicy]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_BudgetPolicy]') AND type in (N'U'))
DROP TABLE [dbo].[Job_BudgetPolicy]
GO
/****** Object:  Table [dbo].[Job_BillingHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_BillingHeader]') AND type in (N'U'))
DROP TABLE [dbo].[Job_BillingHeader]
GO
/****** Object:  Table [dbo].[Job_BillingDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_BillingDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_BillingDetail]
GO
/****** Object:  Table [dbo].[Job_BillAnnSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_BillAnnSub]') AND type in (N'U'))
DROP TABLE [dbo].[Job_BillAnnSub]
GO
/****** Object:  Table [dbo].[Job_BillAnn]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_BillAnn]') AND type in (N'U'))
DROP TABLE [dbo].[Job_BillAnn]
GO
/****** Object:  Table [dbo].[Job_BillAcceptHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_BillAcceptHeader]') AND type in (N'U'))
DROP TABLE [dbo].[Job_BillAcceptHeader]
GO
/****** Object:  Table [dbo].[Job_BillAcceptDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_BillAcceptDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_BillAcceptDetail]
GO
/****** Object:  Table [dbo].[Job_AdvMJob]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_AdvMJob]') AND type in (N'U'))
DROP TABLE [dbo].[Job_AdvMJob]
GO
/****** Object:  Table [dbo].[Job_AdvHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_AdvHeader]') AND type in (N'U'))
DROP TABLE [dbo].[Job_AdvHeader]
GO
/****** Object:  Table [dbo].[Job_AdvDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Job_AdvDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Job_AdvDetail]
GO
/****** Object:  Table [dbo].[ChequeType]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChequeType]') AND type in (N'U'))
DROP TABLE [dbo].[ChequeType]
GO
/****** Object:  Table [dbo].[ChequeHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChequeHeader]') AND type in (N'U'))
DROP TABLE [dbo].[ChequeHeader]
GO
/****** Object:  Table [dbo].[ChequeDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChequeDetail]') AND type in (N'U'))
DROP TABLE [dbo].[ChequeDetail]
GO
/****** Object:  Table [dbo].[BankCode]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BankCode]') AND type in (N'U'))
DROP TABLE [dbo].[BankCode]
GO
/****** Object:  UserDefinedFunction [dbo].[GetUserName]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetUserName]
GO
/****** Object:  UserDefinedFunction [dbo].[GetShipBy]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetShipBy]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetShipBy]
GO
/****** Object:  UserDefinedFunction [dbo].[GetJobType]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetJobType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetJobType]
GO
/****** Object:  UserDefinedFunction [dbo].[GetJobStatus]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetJobStatus]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetJobStatus]
GO
/****** Object:  Database [JOB_WEB]    Script Date: 08-Mar-19 11:31:24 AM ******/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'JOB_WEB')
DROP DATABASE [JOB_WEB]
GO
/****** Object:  Database [JOB_WEB]    Script Date: 08-Mar-19 11:31:24 AM ******/
CREATE DATABASE [JOB_WEB] ON  PRIMARY 
( NAME = N'JOB_INTER_NEW', FILENAME = N'D:\Database\JOBIDEAL.MDF' , SIZE = 48128KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'JOB_INTER_NEW_log', FILENAME = N'D:\Database\JOBIDEAL.LDF' , SIZE = 24384KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 COLLATE Thai_CI_AS
GO
ALTER DATABASE [JOB_WEB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JOB_WEB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JOB_WEB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JOB_WEB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JOB_WEB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JOB_WEB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JOB_WEB] SET ARITHABORT OFF 
GO
ALTER DATABASE [JOB_WEB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JOB_WEB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JOB_WEB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JOB_WEB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JOB_WEB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JOB_WEB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JOB_WEB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JOB_WEB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JOB_WEB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JOB_WEB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [JOB_WEB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JOB_WEB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JOB_WEB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JOB_WEB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JOB_WEB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JOB_WEB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JOB_WEB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JOB_WEB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [JOB_WEB] SET  MULTI_USER 
GO
ALTER DATABASE [JOB_WEB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JOB_WEB] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'JOB_WEB', N'ON'
GO
/****** Object:  UserDefinedFunction [dbo].[GetJobStatus]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[GetJobStatus]
(
@jobsts varchar(20)
)
RETURNS varchar(50)
AS 
BEGIN
	DECLARE @stsname varchar(50)
	IF @jobsts='99' 
		SET @stsname='CANCEL'
	else IF @jobsts='6' 
		SET @stsname='COMPLETE'
	else IF @jobsts='5'
		SET @stsname='FULL-BILL'
	else IF @jobsts='4'
		SET @stsname='PART-BILL'
	else IF @jobsts='3'
		SET @stsname='CLOSE'		
	else IF @jobsts='2'
		SET @stsname='PROCESS'		
	else 
		SET @stsname='OPEN';
		
	RETURN @stsname
END 

GO
/****** Object:  UserDefinedFunction [dbo].[GetJobType]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[GetJobType]
(
@jobsts varchar(20)
)
RETURNS varchar(50)
AS 
BEGIN
	DECLARE @stsname varchar(50)
	IF @jobsts='1' 
		SET @stsname='IMPORT'
	else IF @jobsts='2' 
		SET @stsname='EXPORT'
	else IF @jobsts='3'
		SET @stsname='TRANSPORT'
	else IF @jobsts='4'
		SET @stsname='CO FORM'
	else IF @jobsts='5'
		SET @stsname='GENERAL'		
	else IF @jobsts='6'
		SET @stsname='DOCUMENT'		
	else 
		SET @stsname='OTHERS';
		
	RETURN @stsname
END 










GO
/****** Object:  UserDefinedFunction [dbo].[GetShipBy]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[GetShipBy]
(
@jobsts varchar(20)
)
RETURNS varchar(50)
AS 
BEGIN

	DECLARE @stsname varchar(50)
	IF @jobsts='1' 
		SET @stsname='AIR'
	else IF @jobsts='2' 
		SET @stsname='SEA'
	else IF @jobsts='3'
		SET @stsname='TRAIN'
	else IF @jobsts='4'
		SET @stsname='TRUCK'
	else IF @jobsts='5'
		SET @stsname='GENERAL'		
	else IF @jobsts='6'
		SET @stsname='PASSENGER'		
	else IF @jobsts='7'
		SET @stsname='FREIGHT'
	else IF @jobsts='8'
		SET @stsname='LCB'						
	else IF @jobsts='9'
		SET @stsname='BOI'			
	else IF @jobsts='10'
		SET @stsname='RE EXPORT'				
	else IF @jobsts='11'
		SET @stsname='FORMULA'				
	else IF @jobsts='12'
		SET @stsname='ENTER 19 BIS'
	else IF @jobsts='13'
		SET @stsname='LOCAL'								
	else IF @jobsts='14'
		SET @stsname='TAX-RETURN'
	else IF @jobsts='15'
		SET @stsname='FORM-A'																			
	else IF @jobsts='16'
		SET @stsname='FORM-D'
	else IF @jobsts='17'
		SET @stsname='FORM-E'	
	else IF @jobsts='18'
		SET @stsname='FORM-CO'
	else IF @jobsts='19'
		SET @stsname='CHAMBER'							
	else IF @jobsts='20'
		SET @stsname='FORM-AI'
	else IF @jobsts='21'
		SET @stsname='FORM-AK'
	else IF @jobsts='22'
		SET @stsname='TEXTTILE'
	else IF @jobsts='23'
		SET @stsname='THAI-AUS'								
	else IF @jobsts='24'
		SET @stsname='JTEPA'
	else IF @jobsts='25'
		SET @stsname='MEXICO'
	else IF @jobsts='26'
		SET @stsname='ANNZ'
	else IF @jobsts='27'
		SET @stsname='REGISTER'
	else IF @jobsts='28'
		SET @stsname='BANKING'
	else IF @jobsts='29'
		SET @stsname='LEGALIZE'
	else IF @jobsts='30'
		SET @stsname='INSURANCE'
	else IF @jobsts='31'
		SET @stsname='COURIER'
	else IF @jobsts='32'
		SET @stsname='MARKETING'
	else IF @jobsts='33'
		SET @stsname='FREIGHT'
	else IF @jobsts='34'
		SET @stsname='DOCUMENT'
	else IF @jobsts='35'
		SET @stsname='WAREHOUSE'
	else IF @jobsts='36'
		SET @stsname='CONSIGNMENT'
	else IF @jobsts='37'
		SET @stsname='SUPPPLY-CHAIN'
	else IF @jobsts='38'
		SET @stsname='MILK-RUN'
	else IF @jobsts='39'
		SET @stsname='CUSTOMER-SERVICE'
	else 
		SET @stsname='OTHERS';
		
	RETURN @stsname
END 






GO
/****** Object:  UserDefinedFunction [dbo].[GetUserName]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetUserName]
(
@CSCode varchar(30)
)
RETURNS varchar(255)
AS
BEGIN
	DECLARE @username varchar(255)
	
	SELECT @username=TName from Mas_User where UserID=@CSCode
	
	RETURN @username
		
END

GO
/****** Object:  Table [dbo].[BankCode]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankCode](
	[BankCode] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[BankName] [nvarchar](2000) COLLATE Thai_CI_AS NULL,
	[BankBranch] [nvarchar](2000) COLLATE Thai_CI_AS NULL,
	[BankForm] [nvarchar](2000) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_BankCode] PRIMARY KEY CLUSTERED 
(
	[BankCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChequeDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChequeDetail](
	[BankID] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[ChequeNo] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[Seq] [int] NOT NULL,
	[JobNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Expense] [nvarchar](2000) COLLATE Thai_CI_AS NULL,
	[Amount] [float] NULL,
	[VoucherNo] [varchar](50) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_ChequeDetail] PRIMARY KEY CLUSTERED 
(
	[BankID] ASC,
	[ChequeNo] ASC,
	[Seq] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChequeHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChequeHeader](
	[BankID] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[ChequeNo] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[ChequeType] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ChequeDate] [date] NULL,
	[IssueDate] [date] NULL,
	[IssueBy] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CustCode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[PayTo] [nvarchar](2000) COLLATE Thai_CI_AS NULL,
	[Total] [float] NULL,
	[ChequeStatus] [varchar](50) COLLATE Thai_CI_AS NULL,
	[BookNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[HaveSquare] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Payee] [varchar](50) COLLATE Thai_CI_AS NULL,
	[HaveLine] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Remark] [nvarchar](2000) COLLATE Thai_CI_AS NULL,
	[Printed] [varchar](50) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_ChequeHeader] PRIMARY KEY CLUSTERED 
(
	[BankID] ASC,
	[ChequeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChequeType]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChequeType](
	[ChequeType] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[ChequeTypeDesc] [nvarchar](2000) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_ChequeType] PRIMARY KEY CLUSTERED 
(
	[ChequeType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_AdvDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_AdvDetail](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[AdvNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[ItemNo] [int] NOT NULL,
	[STCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AdvAmount] [float] NULL,
	[IsChargeVAT] [tinyint] NULL,
	[ChargeVAT] [float] NULL,
	[Rate50Tavi] [float] NULL,
	[Charge50Tavi] [float] NULL,
	[TRemark] [varchar](100) COLLATE Thai_CI_AS NULL,
	[IsDuplicate] [tinyint] NULL,
	[PayChqTo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[Doc50Tavi] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Is50Tavi] [tinyint] NULL,
	[VATRate] [float] NULL,
	[AdvNet] [float] NULL,
	[SDescription] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ForJNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[VenCode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CurrencyCode] [varchar](12) COLLATE Thai_CI_AS NULL,
	[ExchangeRate] [float] NOT NULL,
	[AdvQty] [float] NOT NULL,
	[UnitPrice] [float] NOT NULL,
 CONSTRAINT [pk_adv_d] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[AdvNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_AdvHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_AdvHeader](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[AdvNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[JobType] [tinyint] NULL,
	[AdvDate] [datetime] NULL,
	[AdvType] [tinyint] NULL,
	[EmpCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[InvNo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[DocStatus] [tinyint] NULL,
	[VATRate] [int] NULL,
	[TotalAdvance] [float] NULL,
	[TotalVAT] [float] NULL,
	[Total50Tavi] [float] NULL,
	[TRemark] [varchar](250) COLLATE Thai_CI_AS NULL,
	[ApproveBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveTime] [datetime] NULL,
	[PaymentBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[PaymentDate] [datetime] NULL,
	[PaymentTime] [datetime] NULL,
	[PaymentRef] [varchar](20) COLLATE Thai_CI_AS NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[AdvCash] [float] NULL,
	[AdvChqCash] [float] NULL,
	[AdvChq] [float] NULL,
	[AdvCred] [float] NULL,
	[PayChqTo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[PayChqDate] [datetime] NULL,
	[Doc50Tavi] [varchar](15) COLLATE Thai_CI_AS NULL,
	[AdvBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[ShipBy] [tinyint] NULL,
	[PaymentNo] [varchar](20) COLLATE Thai_CI_AS NULL,
	[MainCurrency] [varchar](12) COLLATE Thai_CI_AS NULL,
	[SubCurrency] [varchar](12) COLLATE Thai_CI_AS NULL,
	[ExchangeRate] [float] NOT NULL,
 CONSTRAINT [pk_adv_h] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[AdvNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_AdvMJob]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_AdvMJob](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[AdvNO] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ItemNo] [smallint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[AdvDate] [datetime] NULL,
	[CSCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[TotalDuty] [float] NULL,
	[TotalExpense] [float] NULL,
	[TRemark] [varchar](100) COLLATE Thai_CI_AS NULL,
	[IsDuplicate] [tinyint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_BillAcceptDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_BillAcceptDetail](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[BillAcceptNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[ItemNo] [smallint] NOT NULL,
	[InvNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[AmtAdvance] [float] NULL,
	[AmtChargeNonVAT] [float] NULL,
	[AmtChargeVAT] [float] NULL,
	[AmtWH] [float] NULL,
	[AmtVAT] [float] NULL,
	[AmtTotal] [float] NULL,
	[CurrencyCode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ExchangeRate] [float] NULL,
 CONSTRAINT [PK_BillAcceptD] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[BillAcceptNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_BillAcceptHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_BillAcceptHeader](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[BillAcceptNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[BillDate] [datetime] NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[BillRecvBy] [varchar](30) COLLATE Thai_CI_AS NULL,
	[BillRecvDate] [datetime] NULL,
	[DuePaymentDate] [datetime] NULL,
	[BillRemark] [varchar](255) COLLATE Thai_CI_AS NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
 CONSTRAINT [PK_BillAcceptH] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[BillAcceptNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_BillAnn]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_BillAnn](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DocNO] [varchar](15) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[RecvBy] [varchar](30) COLLATE Thai_CI_AS NULL,
	[RecvDate] [datetime] NULL,
	[PaymentDate] [datetime] NULL,
	[TRemark] [varchar](255) COLLATE Thai_CI_AS NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_BillAnnSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_BillAnnSub](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DocNO] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ItemNo] [smallint] NULL,
	[BillNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[AmtAdvance] [float] NULL,
	[AmtChargeNoVAT] [float] NULL,
	[AmtChargeVAT] [float] NULL,
	[AmtWH1] [float] NULL,
	[AmtWH3] [float] NULL,
	[AmtVAT] [float] NULL,
	[AmtTotal] [float] NULL,
	[CurrencyCode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ExchangeRate] [float] NULL,
	[ForeignAmt] [float] NULL,
	[ReceiptDate] [datetime] NULL,
	[ReceiptNo] [varchar](20) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_BillingDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_BillingDetail](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DocNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ItemNo] [smallint] NOT NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SDescription] [varchar](255) COLLATE Thai_CI_AS NULL,
	[ExpSlipNO] [varchar](100) COLLATE Thai_CI_AS NULL,
	[SRemark] [varchar](100) COLLATE Thai_CI_AS NULL,
	[QtyUnit] [varchar](30) COLLATE Thai_CI_AS NULL,
	[IsTaxCharge] [tinyint] NOT NULL,
	[Is50Tavi] [tinyint] NOT NULL,
	[Rate50Tavi] [float] NOT NULL,
	[AmtAdvance] [float] NOT NULL,
	[AmtCharge] [float] NOT NULL,
	[ForeignAmt] [float] NOT NULL,
	[CurrencyCode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ExchangeRate] [float] NOT NULL,
	[CurrencyCodeCredit] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ExchangeRateCredit] [float] NOT NULL,
	[ForeignAmtCredit] [float] NOT NULL,
	[DiscountPerc] [float] NOT NULL,
	[AmtDiscount] [float] NOT NULL,
	[ForeignDisc] [float] NOT NULL,
	[FUnitPrice] [float] NOT NULL,
	[FQty] [float] NOT NULL,
	[FTotalAmt] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_BillingHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_BillingHeader](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DocNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[JobNo] [varchar](3000) COLLATE Thai_CI_AS NULL,
	[JobBillAmt] [tinyint] NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[BillToCustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[BillToCustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[ContactName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[EmpCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[PrintedBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[PrintedDate] [datetime] NULL,
	[PrintedTime] [datetime] NULL,
	[RefNo] [varchar](255) COLLATE Thai_CI_AS NULL,
	[VATRate] [float] NULL,
	[Tavi50Rate1] [float] NULL,
	[Tavi50Rate2] [float] NULL,
	[TaxInvNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[TaxInvDate] [datetime] NULL,
	[TotalAdvance] [float] NULL,
	[TotalCharge] [float] NULL,
	[TotalIsTaxCharge] [float] NULL,
	[TotalIs50Tavi1] [float] NULL,
	[TotalIs50Tavi2] [float] NULL,
	[TotalVAT] [float] NULL,
	[Total50Tavi1] [float] NULL,
	[Total50Tavi2] [float] NULL,
	[TotalCustAdv] [float] NULL,
	[TotalNet] [float] NULL,
	[BillDate] [datetime] NULL,
	[BillTime] [datetime] NULL,
	[BillAcceptNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[PayDate] [datetime] NULL,
	[PayTime] [datetime] NULL,
	[Remark1] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark2] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark3] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark4] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark5] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark6] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark7] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark8] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark9] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark10] [varchar](max) COLLATE Thai_CI_AS NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[PaidFlag] [tinyint] NULL,
	[ShippingRemark] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CurrencyCode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ExchangeRate] [float] NULL,
	[ForeignAmt] [float] NULL,
	[QuatationNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Revise] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_BudgetPolicy]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_BudgetPolicy](
	[ID] [int] NOT NULL,
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SDescription] [varchar](150) COLLATE Thai_CI_AS NULL,
	[TRemark] [varchar](50) COLLATE Thai_CI_AS NULL,
	[MaxAdvance] [float] NULL,
	[MaxCost] [float] NULL,
	[MinCharge] [float] NULL,
	[MinProfit] [float] NULL,
	[Active] [varchar](5) COLLATE Thai_CI_AS NULL,
	[LastUpdate] [datetime] NULL,
	[UpdateBy] [varchar](10) COLLATE Thai_CI_AS NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_CashControl]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_CashControl](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NOT NULL,
	[ControlNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[VoucherDate] [datetime] NULL,
	[TRemark] [varchar](100) COLLATE Thai_CI_AS NULL,
	[RecUser] [varchar](10) COLLATE Thai_CI_AS NULL,
	[RecDate] [datetime] NULL,
	[RecTime] [datetime] NULL,
	[PostedBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[PostedDate] [datetime] NULL,
	[PostedTime] [datetime] NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
 CONSTRAINT [PK_CashControl] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[ControlNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_CashControlDoc]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_CashControlDoc](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NOT NULL,
	[ControlNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[ItemNo] [int] NOT NULL,
	[DocType] [varchar](5) COLLATE Thai_CI_AS NULL,
	[DocNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[CmpType] [varchar](1) COLLATE Thai_CI_AS NULL,
	[CmpCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CmpBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[PaidAmount] [float] NULL,
	[TotalAmount] [float] NULL,
 CONSTRAINT [PK_CashControldoc] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[ControlNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_CashControlSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_CashControlSub](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NOT NULL,
	[ControlNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[ItemNo] [int] NOT NULL,
	[PRVoucher] [varchar](20) COLLATE Thai_CI_AS NULL,
	[PRType] [varchar](1) COLLATE Thai_CI_AS NULL,
	[ChqNo] [varchar](20) COLLATE Thai_CI_AS NULL,
	[BookCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[BankCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[BankBranch] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ChqDate] [datetime] NULL,
	[CashAmount] [float] NULL,
	[ChqAmount] [float] NULL,
	[CreditAmount] [float] NULL,
	[IsLocal] [tinyint] NULL,
	[ChqStatus] [varchar](1) COLLATE Thai_CI_AS NULL,
	[TRemark] [varchar](100) COLLATE Thai_CI_AS NULL,
	[PayChqTo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[DocNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[SICode] [varchar](100) COLLATE Thai_CI_AS NULL,
	[RecvBank] [varchar](5) COLLATE Thai_CI_AS NULL,
	[RecvBranch] [varchar](50) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_CashControlSub] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[ControlNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_CashFlow]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_CashFlow](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[RefNo] [varchar](20) COLLATE Thai_CI_AS NOT NULL,
	[AccType] [smallint] NOT NULL,
	[BankCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[BookAcc] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Remark] [varchar](100) COLLATE Thai_CI_AS NULL,
	[RecordDate] [datetime] NULL,
	[RecordBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ChqNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ChqDate] [datetime] NULL,
	[ChqPayTo] [varchar](255) COLLATE Thai_CI_AS NULL,
	[ChqBackNote] [varchar](255) COLLATE Thai_CI_AS NULL,
	[ChqAmount] [float] NULL,
	[ChqStatus] [int] NULL,
	[ClearDate] [datetime] NULL,
	[ChqDueDate] [datetime] NULL,
	[TransRefNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TransDate] [datetime] NULL,
	[TransAmt] [float] NULL,
	[TransBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[TransBank] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[TransBookAcc] [varchar](15) COLLATE Thai_CI_AS NULL,
	[SourceDocType] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SourceDocNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SDescription] [varchar](255) COLLATE Thai_CI_AS NULL,
	[BankCharge] [float] NULL,
	[IsWHT] [float] NULL,
	[WHTRate] [float] NULL,
	[WHTDocNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[WHTAmt] [float] NULL,
	[TotalAmt] [float] NULL,
	[IsVat] [float] NULL,
	[VatRate] [float] NULL,
	[TotalVat] [float] NULL,
	[TotalNet] [float] NULL,
	[SlipNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[SlipDate] [datetime] NULL,
	[ApproveBy] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ApproveDate] [datetime] NULL,
	[PrintDate] [datetime] NULL,
	[PrintBy] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CancelBy] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelReason] [varchar](255) COLLATE Thai_CI_AS NULL,
	[PostBy] [varchar](50) COLLATE Thai_CI_AS NULL,
	[PostDate] [datetime] NULL,
	[ControlNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[VoucherNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[VoucherItemNo] [int] NULL,
	[GLAccountCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[DebitAmt] [float] NULL,
	[CreditAmt] [float] NULL,
 CONSTRAINT [PK_Job_CashFlow] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[RefNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_ClearDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_ClearDetail](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[ClrNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ItemNo] [smallint] NULL,
	[LinkItem] [smallint] NULL,
	[STCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SDescription] [varchar](100) COLLATE Thai_CI_AS NULL,
	[VenderCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Qty] [float] NULL,
	[UnitCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CurrencyCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[CurRate] [float] NULL,
	[UnitPrice] [float] NULL,
	[FPrice] [float] NULL,
	[BPrice] [float] NULL,
	[QUnitPrice] [float] NULL,
	[QFPrice] [float] NULL,
	[QBPrice] [float] NULL,
	[UnitCost] [float] NULL,
	[FCost] [float] NULL,
	[BCost] [float] NULL,
	[ChargeVAT] [float] NULL,
	[Tax50Tavi] [float] NULL,
	[AdvNO] [varchar](15) COLLATE Thai_CI_AS NULL,
	[AdvAmount] [float] NULL,
	[UsedAmount] [float] NULL,
	[IsQuoItem] [tinyint] NULL,
	[SlipNO] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Remark] [varchar](100) COLLATE Thai_CI_AS NULL,
	[IsDuplicate] [tinyint] NULL,
	[IsLtdAdv50Tavi] [tinyint] NULL,
	[Pay50TaviTo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[NO50Tavi] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Date50Tavi] [datetime] NULL,
	[VenderBillingNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[AirQtyStep] [varchar](100) COLLATE Thai_CI_AS NULL,
	[StepSub] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[JobNo] [varchar](15) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_ClearExp]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_ClearExp](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SDescription] [varchar](150) COLLATE Thai_CI_AS NULL,
	[TRemark] [varchar](50) COLLATE Thai_CI_AS NULL,
	[AmountCharge] [float] NULL,
	[Status] [varchar](5) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_ClearHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_ClearHeader](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[ClrNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ClrDate] [datetime] NULL,
	[ClearanceDate] [datetime] NULL,
	[EmpCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AdvRefNo] [varchar](255) COLLATE Thai_CI_AS NULL,
	[AdvTotal] [float] NULL,
	[JobType] [tinyint] NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[InvNo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ClearType] [tinyint] NULL,
	[ClearFrom] [tinyint] NULL,
	[DocStatus] [tinyint] NULL,
	[TotalExpense] [float] NULL,
	[TRemark] [varchar](250) COLLATE Thai_CI_AS NULL,
	[ApproveBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveTime] [datetime] NULL,
	[ReceiveBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ReceiveDate] [datetime] NULL,
	[ReceiveTime] [datetime] NULL,
	[ReceiveRef] [varchar](20) COLLATE Thai_CI_AS NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CoPersonCode] [varchar](15) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_ClearMJob]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_ClearMJob](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ClrNO] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ItemNo] [smallint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[ClrDate] [datetime] NULL,
	[CSCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[TotalExpense] [float] NULL,
	[TRemark] [varchar](100) COLLATE Thai_CI_AS NULL,
	[IsDuplicate] [tinyint] NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SlipNo] [varchar](20) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_CNDNDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_CNDNDetail](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[DocNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[ItemNo] [int] NOT NULL,
	[BillingNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SDescription] [varchar](100) COLLATE Thai_CI_AS NULL,
	[OriginalAmt] [float] NULL,
	[CorrectAmt] [float] NULL,
	[DiffAmt] [float] NULL,
	[IsTaxCharge] [int] NULL,
	[VATRate] [float] NULL,
	[VATAmt] [float] NULL,
	[TotalNet] [float] NULL,
	[CurrencyCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[ExchangeRate] [float] NULL,
	[ForeignNet] [float] NULL,
 CONSTRAINT [PK_CNDNDetail] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_CNDNHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_CNDNHeader](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[DocNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[DocType] [smallint] NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[CustBranch] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[DocDate] [datetime] NULL,
	[EmpCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ApproveBy] [varchar](110) COLLATE Thai_CI_AS NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveTime] [datetime] NULL,
	[UpdateBy] [varchar](110) COLLATE Thai_CI_AS NULL,
	[LastupDate] [datetime] NULL,
	[DocStatus] [int] NULL,
	[CancelDate] [datetime] NULL,
	[CancelReason] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Remark] [varchar](255) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_CNDN] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_Controls]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_Controls](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ItemNo] [smallint] NULL,
	[SCID] [varchar](10) COLLATE Thai_CI_AS NULL,
	[EmpCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[BDate] [datetime] NULL,
	[BTime] [datetime] NULL,
	[NDate] [datetime] NULL,
	[NTime] [datetime] NULL,
	[ADate] [datetime] NULL,
	[AlertReson] [varchar](250) COLLATE Thai_CI_AS NULL,
	[UnLockBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[UnLockDate] [datetime] NULL,
	[UnLockTime] [datetime] NULL,
	[TRemark] [varchar](255) COLLATE Thai_CI_AS NULL,
	[DayStart] [tinyint] NULL,
	[DayStartDate] [datetime] NULL,
	[AmtDHoliday] [tinyint] NULL,
	[AmtDPeriod] [tinyint] NULL,
	[AmtDOverDue] [tinyint] NULL,
	[MaximumDay] [int] NULL,
	[Field1] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field2] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field3] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field4] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field5] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field6] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field7] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field8] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field9] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field10] [varchar](255) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_CoPersonSlip]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_CoPersonSlip](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[CoPersonCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[DocNO] [varchar](15) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[AmtTotal] [float] NULL,
	[AmtWH] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_CoPersonSlipSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_CoPersonSlipSub](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[CoPersonCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[DocNO] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ItemNo] [smallint] NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SDescription] [varchar](255) COLLATE Thai_CI_AS NULL,
	[AmtCharge] [float] NULL,
	[AmtWH] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_CPolicyDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_CPolicyDetail](
	[PolicyCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ItemNo] [smallint] NULL,
	[SCID] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SCDescription] [varchar](100) COLLATE Thai_CI_AS NULL,
	[MaximumDay] [smallint] NULL,
	[DayStart] [tinyint] NULL,
	[Field1] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field2] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field3] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field4] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field5] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field6] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field7] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field8] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field9] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field10] [varchar](255) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_CPolicyHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_CPolicyHeader](
	[PolicyCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[PolicyName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_CustAdvChq]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_CustAdvChq](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NOT NULL,
	[RefNo] [varchar](20) COLLATE Thai_CI_AS NOT NULL,
	[BankCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[ChqNo] [varchar](20) COLLATE Thai_CI_AS NOT NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[ChqDate] [datetime] NULL,
	[ChqAmount] [float] NULL,
	[TotalUsed] [float] NULL,
	[PayTo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[Remark] [varchar](100) COLLATE Thai_CI_AS NULL,
	[RecordDate] [datetime] NULL,
	[RecordBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DepBookAcc] [varchar](15) COLLATE Thai_CI_AS NULL,
	[DepDate] [datetime] NULL,
	[DepUser] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ApproveBy] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ApproveDate] [datetime] NULL,
	[CancelBy] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelReason] [varchar](255) COLLATE Thai_CI_AS NULL,
	[ClearBy] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ClearDate] [datetime] NULL,
	[ControlNo] [varchar](50) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_Job_CustAdvChq] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[RefNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_CustAdvChqDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_CustAdvChqDetail](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[RefNo] [varchar](20) COLLATE Thai_CI_AS NOT NULL,
	[SeqNo] [int] NOT NULL,
	[JNo] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[LinkItem] [int] NOT NULL,
	[BillingNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[SICode] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[PayAmount] [float] NULL,
	[Remark] [varchar](100) COLLATE Thai_CI_AS NULL,
	[VoucherNo] [int] NULL,
 CONSTRAINT [PK_Job_CustAdvChqDetail] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[RefNo] ASC,
	[SeqNo] ASC,
	[JNo] ASC,
	[LinkItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_CustAdvChqSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_CustAdvChqSub](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[RefNo] [varchar](20) COLLATE Thai_CI_AS NOT NULL,
	[SeqNo] [int] NOT NULL,
	[JNO] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[BillFlag] [varchar](1) COLLATE Thai_CI_AS NULL,
	[BillingNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[SICode] [varchar](100) COLLATE Thai_CI_AS NULL,
	[PayAmount] [float] NULL,
	[Remark] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ClearingNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ItemNo] [smallint] NULL,
 CONSTRAINT [PK_Job_CustAdvChqSub] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[RefNo] ASC,
	[SeqNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_CustAdvDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_CustAdvDetail](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[DocNo] [tinyint] NULL,
	[ItemNo] [smallint] NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SDescription] [varchar](255) COLLATE Thai_CI_AS NULL,
	[TotalExpense] [float] NULL,
	[PayTo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[PaySlipNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Remark] [varchar](255) COLLATE Thai_CI_AS NULL,
	[PaySlipDate] [datetime] NULL,
	[ReceiptDue] [datetime] NULL,
	[ReceiptNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ReceiptDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_CustAdvHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_CustAdvHeader](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[DocNo] [tinyint] NULL,
	[DocDate] [datetime] NULL,
	[TotalAdvance] [float] NULL,
	[RefNO] [varchar](15) COLLATE Thai_CI_AS NULL,
	[AdvNo] [varchar](20) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_CustExp]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_CustExp](
	[Custcode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SDescription] [varchar](150) COLLATE Thai_CI_AS NULL,
	[TRemark] [varchar](50) COLLATE Thai_CI_AS NULL,
	[AmountCharge] [float] NULL,
	[Status] [varchar](5) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_DebitNote]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_DebitNote](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DocNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[InvNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[EmpCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ApproveBy] [varchar](110) COLLATE Thai_CI_AS NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveTime] [datetime] NULL,
	[Remark] [varchar](255) COLLATE Thai_CI_AS NULL,
	[VatRate] [float] NULL,
	[VatAmt] [float] NULL,
	[TotalNet] [float] NULL,
	[VatInclude] [smallint] NULL,
	[IsCreditNote] [smallint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_DebitNoteSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_DebitNoteSub](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DocNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ItemNo] [int] NULL,
	[BillingNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SDescription] [varchar](100) COLLATE Thai_CI_AS NULL,
	[OriginalAmt] [float] NULL,
	[CorrectAmt] [float] NULL,
	[DiffAmt] [float] NULL,
	[CurrencyCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[ExchangeRate] [float] NULL,
	[ForeignAmt] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_Delivery]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_Delivery](
	[JobNo] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[Seq] [int] NOT NULL,
	[DeliverTo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[DeliverAddr] [varchar](500) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_Job_Delivery] PRIMARY KEY CLUSTERED 
(
	[JobNo] ASC,
	[Seq] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_Detail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_Detail](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[LinkItem] [smallint] NULL,
	[ItemNo] [smallint] NULL,
	[STCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SDescription] [varchar](100) COLLATE Thai_CI_AS NULL,
	[SRemark] [varchar](250) COLLATE Thai_CI_AS NULL,
	[VenderCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[VenderContact] [varchar](100) COLLATE Thai_CI_AS NULL,
	[EmpCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Start] [varchar](5) COLLATE Thai_CI_AS NULL,
	[CY] [varchar](5) COLLATE Thai_CI_AS NULL,
	[Endding] [varchar](5) COLLATE Thai_CI_AS NULL,
	[DNNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[PdtType] [varchar](5) COLLATE Thai_CI_AS NULL,
	[Qty] [float] NULL,
	[UnitCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CurrencyCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[CurRate] [float] NULL,
	[UnitPrice] [float] NULL,
	[FPrice] [float] NULL,
	[BPrice] [float] NULL,
	[QUnitPrice] [float] NULL,
	[QFPrice] [float] NULL,
	[QBPrice] [float] NULL,
	[UnitCost] [float] NULL,
	[FCost] [float] NULL,
	[BCost] [float] NULL,
	[Tax50Tavi] [float] NULL,
	[BillExtn] [tinyint] NULL,
	[ChargeDate] [datetime] NULL,
	[IsQuoItem] [tinyint] NULL,
	[ProductName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ClearingNO] [varchar](15) COLLATE Thai_CI_AS NULL,
	[RSlipNO] [varchar](100) COLLATE Thai_CI_AS NULL,
	[AirQtyStep] [varchar](100) COLLATE Thai_CI_AS NULL,
	[StepSub] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[PostFlag] [varchar](3) COLLATE Thai_CI_AS NULL,
	[PostStatus] [varchar](1) COLLATE Thai_CI_AS NULL,
	[PostErrMsg] [varchar](100) COLLATE Thai_CI_AS NULL,
	[LastestPostDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_DetailOption]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_DetailOption](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Field1] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field2] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field3] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field4] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field5] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field6] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field7] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field8] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field9] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field10] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field11] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field12] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field13] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field14] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field15] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field16] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field17] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field18] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field19] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field20] [varchar](255) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_DocFollow]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_DocFollow](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ItemNo] [smallint] NULL,
	[DocType] [varchar](5) COLLATE Thai_CI_AS NULL,
	[DocNo] [varchar](20) COLLATE Thai_CI_AS NULL,
	[DDuration] [smallint] NULL,
	[DueDate] [datetime] NULL,
	[FollowResult] [varchar](1) COLLATE Thai_CI_AS NULL,
	[ExternalUnit] [varchar](70) COLLATE Thai_CI_AS NULL,
	[ExternalContact] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ExternalTel] [varchar](50) COLLATE Thai_CI_AS NULL,
	[FollowReson] [varchar](250) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_DocPolicy]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_DocPolicy](
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[DocTypeList] [varchar](255) COLLATE Thai_CI_AS NULL,
	[PolicyCode] [varchar](10) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_Document]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_Document](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ItemNo] [smallint] NULL,
	[DocType] [varchar](5) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[DocNo] [varchar](20) COLLATE Thai_CI_AS NULL,
	[Description] [varchar](250) COLLATE Thai_CI_AS NULL,
	[FileName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[StorePlace] [varchar](100) COLLATE Thai_CI_AS NULL,
	[IsCalling] [tinyint] NULL,
	[RecvCallDate] [datetime] NULL,
	[RecvCallBy] [varchar](50) COLLATE Thai_CI_AS NULL,
	[IsFollowUp] [tinyint] NULL,
	[BeginFollowDate] [datetime] NULL,
	[FinishFollowDate] [datetime] NULL,
	[FollowBy] [varchar](50) COLLATE Thai_CI_AS NULL,
	[IsSendToCustomer] [tinyint] NULL,
	[SendToDate] [datetime] NULL,
	[SendToBy] [varchar](50) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_GLDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_GLDetail](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[GLRefNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[ItemNo] [int] NOT NULL,
	[GLAccountCode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[GLDescription] [nvarchar](255) COLLATE Thai_CI_AS NULL,
	[SourceDocument] [nvarchar](max) COLLATE Thai_CI_AS NULL,
	[DebitAmt] [float] NULL,
	[CreditAmt] [float] NULL,
	[EntryDate] [datetime] NULL,
	[EntryBy] [varchar](15) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_GLDetail] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[GLRefNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_GLHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_GLHeader](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[GLRefNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[FiscalYear] [varchar](10) COLLATE Thai_CI_AS NOT NULL,
	[LastupDate] [datetime] NULL,
	[UpdateBy] [varchar](15) COLLATE Thai_CI_AS NULL,
	[GLType] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Remark] [nvarchar](255) COLLATE Thai_CI_AS NULL,
	[TotalDebit] [float] NULL,
	[TotalCredit] [float] NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveBy] [varchar](15) COLLATE Thai_CI_AS NULL,
	[PostDate] [datetime] NULL,
	[PostBy] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelBy] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CancelReason] [nvarchar](255) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_GLHeader] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[GLRefNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_InvoiceDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_InvoiceDetail](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[DocNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[ItemNo] [smallint] NOT NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SDescription] [varchar](255) COLLATE Thai_CI_AS NULL,
	[ExpSlipNO] [varchar](100) COLLATE Thai_CI_AS NULL,
	[SRemark] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CurrencyCode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ExchangeRate] [float] NOT NULL,
	[Qty] [float] NOT NULL,
	[QtyUnit] [varchar](30) COLLATE Thai_CI_AS NULL,
	[UnitPrice] [float] NOT NULL,
	[FUnitPrice] [float] NOT NULL,
	[Amt] [float] NOT NULL,
	[FAmt] [float] NOT NULL,
	[DiscountType] [int] NOT NULL,
	[DiscountPerc] [float] NOT NULL,
	[AmtDiscount] [float] NOT NULL,
	[FAmtDiscount] [float] NOT NULL,
	[Is50Tavi] [tinyint] NOT NULL,
	[Rate50Tavi] [float] NOT NULL,
	[Amt50Tavi] [float] NOT NULL,
	[IsTaxCharge] [tinyint] NOT NULL,
	[AmtVat] [float] NOT NULL,
	[TotalAmt] [float] NOT NULL,
	[FTotalAmt] [float] NOT NULL,
	[AmtAdvance] [float] NOT NULL,
	[AmtCharge] [float] NOT NULL,
 CONSTRAINT [PK_InvD] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_InvoiceHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_InvoiceHeader](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[DocNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[BillToCustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[BillToCustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[ContactName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[EmpCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[PrintedBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[PrintedDate] [datetime] NULL,
	[PrintedTime] [datetime] NULL,
	[RefNo] [varchar](255) COLLATE Thai_CI_AS NULL,
	[VATRate] [float] NULL,
	[TotalAdvance] [float] NULL,
	[TotalDiscount] [float] NULL,
	[TotalCharge] [float] NULL,
	[TotalIsTaxCharge] [float] NULL,
	[TotalIs50Tavi] [float] NULL,
	[TotalVAT] [float] NULL,
	[Total50Tavi] [float] NULL,
	[TotalCustAdv] [float] NULL,
	[TotalNet] [float] NULL,
	[CurrencyCode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ExchangeRate] [float] NULL,
	[ForeignNet] [float] NULL,
	[BillAcceptDate] [datetime] NULL,
	[BillIssueDate] [datetime] NULL,
	[BillAcceptNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Remark1] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark2] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark3] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark4] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark5] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark6] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark7] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark8] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark9] [varchar](max) COLLATE Thai_CI_AS NULL,
	[Remark10] [varchar](max) COLLATE Thai_CI_AS NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[ShippingRemark] [varchar](50) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_InvH] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_LoadInfo]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_LoadInfo](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NOT NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[VenderCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ContactName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[BookingNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[LoadDate] [datetime] NULL,
	[Remark] [varchar](250) COLLATE Thai_CI_AS NULL,
	[PackingPlace] [varchar](250) COLLATE Thai_CI_AS NULL,
	[CYPlace] [varchar](250) COLLATE Thai_CI_AS NULL,
	[FactoryPlace] [varchar](250) COLLATE Thai_CI_AS NULL,
	[ReturnPlace] [varchar](250) COLLATE Thai_CI_AS NULL,
	[PackingDate] [datetime] NULL,
	[CYDate] [datetime] NULL,
	[FactoryDate] [datetime] NULL,
	[ReturnDate] [datetime] NULL,
	[PackingTime] [datetime] NULL,
	[CYTime] [datetime] NULL,
	[FactoryTime] [datetime] NULL,
	[ReturnTime] [datetime] NULL,
 CONSTRAINT [PK_JOB_LOADINFO] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[JNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_LoadInfoDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_LoadInfoDetail](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NOT NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[ItemNo] [smallint] NOT NULL,
	[CTN_NO] [varchar](15) COLLATE Thai_CI_AS NULL,
	[SealNumber] [varchar](20) COLLATE Thai_CI_AS NULL,
	[TruckNO] [varchar](15) COLLATE Thai_CI_AS NULL,
	[TruckIN] [datetime] NULL,
	[Start] [datetime] NULL,
	[Finish] [datetime] NULL,
	[TimeUsed] [datetime] NULL,
	[CauseCode] [varchar](5) COLLATE Thai_CI_AS NULL,
	[Comment] [varchar](100) COLLATE Thai_CI_AS NULL,
	[TruckType] [varchar](20) COLLATE Thai_CI_AS NULL,
	[Driver] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TargetYardDate] [datetime] NULL,
	[TargetYardTime] [datetime] NULL,
	[ActualYardDate] [datetime] NULL,
	[ActualYardTime] [datetime] NULL,
	[UnloadFinishDate] [datetime] NULL,
	[UnloadFinishTime] [datetime] NULL,
	[UnloadDate] [datetime] NULL,
	[UnloadTime] [datetime] NULL,
	[Location] [varchar](500) COLLATE Thai_CI_AS NULL,
	[ReturnDate] [datetime] NULL,
 CONSTRAINT [PK_JOB_LOADINFODETAIL] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[JNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_Order]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_Order](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[JRevise] [tinyint] NULL,
	[ConfirmDate] [datetime] NULL,
	[CPolicyCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[CustContactName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[QNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Revise] [smallint] NULL,
	[ManagerCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CSCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Description] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[TRemark] [varchar](250) COLLATE Thai_CI_AS NULL,
	[JobStatus] [tinyint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[InvNo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[InvTotal] [float] NULL,
	[InvProduct] [varchar](100) COLLATE Thai_CI_AS NULL,
	[InvCountry] [varchar](2) COLLATE Thai_CI_AS NULL,
	[InvFCountry] [varchar](2) COLLATE Thai_CI_AS NULL,
	[InvInterPort] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvProductQty] [float] NULL,
	[InvProductUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvCurUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvCurRate] [float] NULL,
	[ImExDate] [datetime] NULL,
	[BLNo] [varchar](40) COLLATE Thai_CI_AS NULL,
	[BookingNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ClearPort] [varchar](5) COLLATE Thai_CI_AS NULL,
	[ClearPortNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ClearDate] [datetime] NULL,
	[LoadDate] [datetime] NULL,
	[ForwarderCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AgentCode] [varchar](5) COLLATE Thai_CI_AS NULL,
	[VesselName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ETDDate] [datetime] NULL,
	[ETADate] [datetime] NULL,
	[ETTime] [datetime] NULL,
	[FNetPrice] [varchar](50) COLLATE Thai_CI_AS NULL,
	[BNetPrice] [float] NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelProveDate] [datetime] NULL,
	[CancelProveTime] [datetime] NULL,
	[CloseJobDate] [datetime] NULL,
	[CloseJobTime] [datetime] NULL,
	[CloseJobBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DeclareType] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DeclareNumber] [varchar](20) COLLATE Thai_CI_AS NULL,
	[DeclareStatus] [varchar](1) COLLATE Thai_CI_AS NULL,
	[TyAuthorSp] [varchar](2) COLLATE Thai_CI_AS NULL,
	[Ty19BIS] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TyClearTax] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TyClearTaxReson] [varchar](50) COLLATE Thai_CI_AS NULL,
	[EstDeliverDate] [datetime] NULL,
	[EstDeliverTime] [datetime] NULL,
	[TotalContainer] [varchar](50) COLLATE Thai_CI_AS NULL,
	[DutyDate] [datetime] NULL,
	[DutyAmount] [float] NULL,
	[DutyCustPayOther] [varchar](30) COLLATE Thai_CI_AS NULL,
	[DutyCustPayChqAmt] [float] NULL,
	[DutyCustPayBankAmt] [float] NULL,
	[DutyCustPayEPAYAmt] [float] NULL,
	[DutyCustPayCardAmt] [float] NULL,
	[DutyCustPayCashAmt] [float] NULL,
	[DutyCustPayOtherAmt] [float] NULL,
	[DutyLtdPayOther] [varchar](30) COLLATE Thai_CI_AS NULL,
	[DutyLtdPayChqAmt] [float] NULL,
	[DutyLtdPayEPAYAmt] [float] NULL,
	[DutyLtdPayCashAmt] [float] NULL,
	[DutyLtdPayOtherAmt] [float] NULL,
	[ConfirmChqDate] [datetime] NULL,
	[ShippingEmp] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ShippingCmd] [varchar](70) COLLATE Thai_CI_AS NULL,
	[TotalGW] [float] NULL,
	[GWUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[TSRequest] [tinyint] NULL,
	[ShipmentType] [tinyint] NULL,
	[ReadyToClearDate] [datetime] NULL,
	[Commission] [int] NULL,
	[CommPayTo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ProjectName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[MVesselName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TotalNW] [float] NULL,
	[Measurement] [varchar](20) COLLATE Thai_CI_AS NULL,
	[CustRefNO] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TotalQty] [varchar](50) COLLATE Thai_CI_AS NULL,
	[HAWB] [varchar](50) COLLATE Thai_CI_AS NULL,
	[MAWB] [varchar](50) COLLATE Thai_CI_AS NULL,
	[consigneecode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[privilegests] [varchar](255) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [pk_JobOrder] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[JNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_OrderLog]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_OrderLog](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ItemNo] [int] NULL,
	[EmpCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[LogDate] [datetime] NULL,
	[LogTime] [datetime] NULL,
	[TRemark] [varchar](255) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_OSRCreditNote]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_OSRCreditNote](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NULL,
	[DocNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[BillToCustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[BillToCustBranch] [varchar](5) COLLATE Thai_CI_AS NULL,
	[TotalCharge] [float] NOT NULL,
	[TotalVAT] [float] NOT NULL,
	[BillNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Remark1] [varchar](100) COLLATE Thai_CI_AS NULL,
	[Remark2] [varchar](100) COLLATE Thai_CI_AS NULL,
	[Remark3] [varchar](100) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_PaymentDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_PaymentDetail](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DocNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ItemNo] [smallint] NOT NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SDescription] [varchar](255) COLLATE Thai_CI_AS NULL,
	[ExpSlipNO] [varchar](100) COLLATE Thai_CI_AS NULL,
	[SRemark] [varchar](100) COLLATE Thai_CI_AS NULL,
	[QtyUnit] [varchar](30) COLLATE Thai_CI_AS NULL,
	[IsTaxCharge] [tinyint] NOT NULL,
	[Is50Tavi] [tinyint] NOT NULL,
	[Rate50Tavi] [float] NOT NULL,
	[AmtAdvance] [float] NOT NULL,
	[AmtCharge] [float] NOT NULL,
	[ForeignAmt] [float] NOT NULL,
	[CurrencyCode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ExchangeRate] [float] NOT NULL,
	[CurrencyCodeCredit] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ExchangeRateCredit] [float] NOT NULL,
	[ForeignAmtCredit] [float] NOT NULL,
	[DiscountPerc] [float] NOT NULL,
	[AmtDiscount] [float] NOT NULL,
	[ForeignDisc] [float] NOT NULL,
	[FUnitPrice] [float] NOT NULL,
	[FQty] [float] NOT NULL,
	[FTotalAmt] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_PaymentHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_PaymentHeader](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DocNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[JobBillAmt] [tinyint] NOT NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[BillToCustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[BillToCustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[ContactName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[EmpCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[PrintedBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[PrintedDate] [datetime] NULL,
	[PrintedTime] [datetime] NULL,
	[RefNo] [varchar](255) COLLATE Thai_CI_AS NULL,
	[VATRate] [float] NOT NULL,
	[Tavi50Rate1] [float] NOT NULL,
	[Tavi50Rate2] [float] NOT NULL,
	[TaxInvNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[TaxInvDate] [datetime] NULL,
	[TotalAdvance] [float] NOT NULL,
	[TotalCharge] [float] NOT NULL,
	[TotalIsTaxCharge] [float] NOT NULL,
	[TotalIs50Tavi1] [float] NOT NULL,
	[TotalIs50Tavi2] [float] NOT NULL,
	[TotalVAT] [float] NOT NULL,
	[Total50Tavi1] [float] NOT NULL,
	[Total50Tavi2] [float] NOT NULL,
	[TotalCustAdv] [float] NOT NULL,
	[TotalNet] [float] NOT NULL,
	[BillDate] [datetime] NULL,
	[BillTime] [datetime] NULL,
	[BillAcceptNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[PayDate] [datetime] NULL,
	[PayTime] [datetime] NULL,
	[Remark1] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Remark2] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Remark3] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Remark4] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Remark5] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Remark6] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Remark7] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Remark8] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Remark9] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Remark10] [varchar](255) COLLATE Thai_CI_AS NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[PaidFlag] [tinyint] NOT NULL,
	[ShippingRemark] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CurrencyCode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ExchangeRate] [float] NOT NULL,
	[ForeignAmt] [float] NOT NULL,
	[QuatationNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Revise] [int] NOT NULL,
	[JobCustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[JobCustBranch] [varchar](4) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_QuoDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_QuoDetail](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[QNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Revise] [smallint] NULL,
	[ItemNo] [smallint] NULL,
	[LinkItem] [smallint] NULL,
	[Description] [varchar](200) COLLATE Thai_CI_AS NULL,
	[TotalPrice] [int] NULL,
	[UnitCode] [varchar](10) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_QuoDetailItem]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_QuoDetailItem](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[QNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Revise] [smallint] NULL,
	[LinkItem] [smallint] NULL,
	[ItemNo] [smallint] NULL,
	[STCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[NameThai] [varchar](100) COLLATE Thai_CI_AS NULL,
	[VenderCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[UnitCharge] [varchar](10) COLLATE Thai_CI_AS NULL,
	[UnitPrice] [float] NULL,
	[CurrencyCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[Start] [varchar](5) COLLATE Thai_CI_AS NULL,
	[Endding] [varchar](5) COLLATE Thai_CI_AS NULL,
	[CY] [varchar](5) COLLATE Thai_CI_AS NULL,
	[QtyStep] [varchar](250) COLLATE Thai_CI_AS NULL,
	[StepSub] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[IsPrintPrice] [tinyint] NULL,
	[IsShowOnPrint] [tinyint] NULL,
	[PrivoteType] [tinyint] NULL,
	[UnitCost] [float] NOT NULL,
	[UnitQTY] [float] NOT NULL,
	[CurrencyRate] [float] NOT NULL,
	[Isvat] [int] NOT NULL,
	[VatRate] [int] NOT NULL,
	[VatAmt] [float] NOT NULL,
	[IsTax] [int] NOT NULL,
	[TaxRate] [int] NOT NULL,
	[TaxAmt] [float] NOT NULL,
	[TotalAmt] [float] NOT NULL,
	[CurrentTHB] [float] NOT NULL,
	[UnitDiscntPerc] [float] NOT NULL,
	[UnitDiscntAmt] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_QuoHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_QuoHeader](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[QNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Revise] [smallint] NULL,
	[ReferQNo] [varchar](20) COLLATE Thai_CI_AS NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[BillToCustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[BillToCustBranch] [varchar](5) COLLATE Thai_CI_AS NULL,
	[ContactName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[ManagerCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DescriptionH] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[DescriptionF] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[TRemark] [varchar](250) COLLATE Thai_CI_AS NULL,
	[ApproveBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveTime] [datetime] NULL,
	[ExchageRate] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_QuotationDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_QuotationDetail](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[QNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[SeqNo] [smallint] NOT NULL,
	[JobType] [smallint] NOT NULL,
	[ShipBy] [smallint] NOT NULL,
	[Description] [nvarchar](max) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_QuoDetail] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[QNo] ASC,
	[SeqNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_QuotationHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_QuotationHeader](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[QNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[ReferQNo] [varchar](20) COLLATE Thai_CI_AS NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[BillToCustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[BillToCustBranch] [varchar](5) COLLATE Thai_CI_AS NULL,
	[ContactName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[ManagerCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DescriptionH] [nvarchar](max) COLLATE Thai_CI_AS NULL,
	[DescriptionF] [nvarchar](max) COLLATE Thai_CI_AS NULL,
	[TRemark] [varchar](250) COLLATE Thai_CI_AS NULL,
	[DocStatus] [int] NULL,
	[ApproveBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveTime] [datetime] NULL,
	[CancelBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelReason] [nvarchar](255) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_QuotaionH] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[QNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_QuotationItem]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_QuotationItem](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[QNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[SeqNo] [smallint] NOT NULL,
	[ItemNo] [smallint] NOT NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DescriptionThai] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CalculateType] [int] NOT NULL,
	[QtyBegin] [float] NULL,
	[QtyEnd] [float] NULL,
	[UnitCheck] [varchar](10) COLLATE Thai_CI_AS NOT NULL,
	[CurrencyCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[CurrencyRate] [float] NOT NULL,
	[ChargeAmt] [float] NOT NULL,
	[Isvat] [int] NOT NULL,
	[VatRate] [int] NOT NULL,
	[VatAmt] [float] NOT NULL,
	[IsTax] [int] NOT NULL,
	[TaxRate] [int] NOT NULL,
	[TaxAmt] [float] NOT NULL,
	[TotalAmt] [float] NOT NULL,
	[TotalCharge] [float] NOT NULL,
	[UnitDiscntPerc] [float] NOT NULL,
	[UnitDiscntAmt] [float] NOT NULL,
	[VenderCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[VenderCost] [float] NULL,
	[BaseProfit] [float] NULL,
	[CommissionPerc] [float] NULL,
	[CommissionAmt] [float] NULL,
	[NetProfit] [float] NULL,
	[IsRequired] [int] NOT NULL,
 CONSTRAINT [PK_QuoItem] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[QNo] ASC,
	[SeqNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_RClearExp]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_RClearExp](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NOT NULL,
	[DocNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[DocDate] [datetime] NULL,
	[TotalNetCharge] [float] NULL,
	[TotalCustAdv] [float] NULL,
	[BillingNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CancelProve] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CancelDate] [date] NULL,
	[CancelReason] [nvarchar](255) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_RClearExp] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_RClearExpSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_RClearExpSub](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NOT NULL,
	[DocNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[ItemNo] [smallint] NOT NULL,
	[SDescription] [varchar](150) COLLATE Thai_CI_AS NULL,
	[TRemark] [varchar](50) COLLATE Thai_CI_AS NULL,
	[AmountCharge] [float] NULL,
 CONSTRAINT [PK_RClearExpSub] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_ReceiptDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_ReceiptDetail](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[ReceiptNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[ItemNo] [smallint] NOT NULL,
	[CreditAmount] [float] NULL,
	[CashAmount] [float] NULL,
	[TransferAmount] [float] NULL,
	[ChequeAmount] [float] NULL,
	[ControlNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[VoucherNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ControlItemNo] [int] NULL,
	[InvoiceNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[InvoiceItemNo] [int] NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SDescription] [varchar](100) COLLATE Thai_CI_AS NULL,
	[VATRate] [float] NULL,
	[Rate50Tavi] [float] NULL,
	[Amt] [float] NULL,
	[AmtVAT] [float] NULL,
	[Amt50Tavi] [float] NULL,
	[Net] [float] NULL,
	[DCurrencyCode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[DExchangeRate] [float] NULL,
	[FAmt] [float] NULL,
	[FAmtVAT] [float] NULL,
	[FAmt50Tavi] [float] NULL,
	[FNet] [float] NULL,
 CONSTRAINT [PK_ReceiptD] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[ReceiptNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_ReceiptHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_ReceiptHeader](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[ReceiptNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[ReceiptDate] [datetime] NULL,
	[ReceiptType] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[BillToCustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[BillToCustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[TRemark] [varchar](250) COLLATE Thai_CI_AS NULL,
	[EmpCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[PrintedBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[PrintedDate] [datetime] NULL,
	[PrintedTime] [datetime] NULL,
	[ReceiveBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ReceiveDate] [datetime] NULL,
	[ReceiveTime] [datetime] NULL,
	[ReceiveRef] [varchar](30) COLLATE Thai_CI_AS NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CurrencyCode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ExchangeRate] [float] NULL,
	[TotalCharge] [float] NULL,
	[TotalVAT] [float] NULL,
	[Total50Tavi] [float] NULL,
	[TotalNet] [float] NULL,
 CONSTRAINT [PK_ReceiptHeader] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[ReceiptNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_RefundTaxDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_RefundTaxDetail](
	[RefundNo] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[DNo] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[DeclareNumber] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ExDate] [datetime] NULL,
	[Product] [varchar](50) COLLATE Thai_CI_AS NULL,
	[FOB] [float] NULL,
	[NetWeight] [float] NULL,
	[GFrom] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TTariff] [float] NULL,
	[TRate] [float] NULL,
	[TAmount] [float] NULL,
	[INVNo] [varchar](50) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_RefundTaxHeader]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_RefundTaxHeader](
	[RefundNo] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[SendDate] [datetime] NULL,
	[ReDate] [datetime] NULL,
	[ClaimNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ClaimDate] [datetime] NULL,
	[TaxCardDate] [datetime] NULL,
	[CNDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_RSlip]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_RSlip](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DocNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[BillToCustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[BillToCustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[TotalCharge] [float] NULL,
	[TotalVAT] [float] NULL,
	[Remark1] [varchar](100) COLLATE Thai_CI_AS NULL,
	[Remark2] [varchar](100) COLLATE Thai_CI_AS NULL,
	[Remark3] [varchar](100) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_RSlipSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_RSlipSub](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DocNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ItemNo] [smallint] NULL,
	[BillNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[SDescription] [varchar](150) COLLATE Thai_CI_AS NULL,
	[AmtCharge] [float] NULL,
	[AmtVAT] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_ServicePolicy]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_ServicePolicy](
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[Field1] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field2] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field3] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field4] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field5] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field6] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field7] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field8] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field9] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field10] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field11] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field12] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field13] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field14] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field15] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field16] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field17] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field18] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field19] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Field20] [varchar](255) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_SrvAccount]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_SrvAccount](
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[JobType] [tinyint] NULL,
	[GLAccountCode] [varchar](15) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_SrvAirCharge]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_SrvAirCharge](
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[NameThai] [varchar](100) COLLATE Thai_CI_AS NULL,
	[NameEng] [varchar](100) COLLATE Thai_CI_AS NULL,
	[UnitCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ProcessDesc] [varchar](250) COLLATE Thai_CI_AS NULL,
	[GLAccountCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[IsTaxCharge] [tinyint] NULL,
	[Is50Tavi] [tinyint] NULL,
	[Rate50Tavi] [float] NULL,
	[IsCredit] [tinyint] NULL,
	[IsExpense] [tinyint] NULL,
	[IsShowPrice] [tinyint] NULL,
	[IsHaveSlip] [tinyint] NULL,
	[IsPay50TaviTo] [tinyint] NULL,
	[IsLtdAdv50Tavi] [tinyint] NULL,
	[QtyStep] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ChargeStep] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[IsUsedCoSlip] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_SrvAirCost]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_SrvAirCost](
	[VenderCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[UnitCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[QtyStep] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ChargeStep] [varchar](4000) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_SrvGroup]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_SrvGroup](
	[GroupCode] [varchar](10) COLLATE Thai_CI_AS NOT NULL,
	[GroupName] [nvarchar](255) COLLATE Thai_CI_AS NOT NULL,
	[GLAccountCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[IsApplyPolicy] [int] NULL,
	[IsTaxCharge] [tinyint] NULL,
	[Is50Tavi] [tinyint] NULL,
	[Rate50Tavi] [float] NULL,
	[IsCredit] [tinyint] NULL,
	[IsExpense] [tinyint] NULL,
	[IsHaveSlip] [tinyint] NULL,
	[IsLtdAdv50Tavi] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_SrvSingle]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_SrvSingle](
	[SICode] [varchar](10) COLLATE Thai_CI_AS NOT NULL,
	[NameThai] [varchar](100) COLLATE Thai_CI_AS NULL,
	[NameEng] [varchar](100) COLLATE Thai_CI_AS NULL,
	[StdPrice] [float] NULL,
	[UnitCharge] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CurrencyCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DefaultVender] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ProcessDesc] [varchar](250) COLLATE Thai_CI_AS NULL,
	[GLAccountCodeSales] [varchar](15) COLLATE Thai_CI_AS NULL,
	[GLAccountCodeCost] [varchar](15) COLLATE Thai_CI_AS NULL,
	[IsTaxCharge] [tinyint] NOT NULL,
	[Is50Tavi] [tinyint] NOT NULL,
	[Rate50Tavi] [float] NOT NULL,
	[IsCredit] [tinyint] NOT NULL,
	[IsExpense] [tinyint] NOT NULL,
	[IsShowPrice] [tinyint] NOT NULL,
	[IsHaveSlip] [tinyint] NOT NULL,
	[IsPay50TaviTo] [tinyint] NOT NULL,
	[IsLtdAdv50Tavi] [tinyint] NOT NULL,
	[IsUsedCoSlip] [int] NOT NULL,
	[GroupCode] [varchar](10) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [pk_sicode] PRIMARY KEY CLUSTERED 
(
	[SICode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_SrvSingleCost]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_SrvSingleCost](
	[VenderCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Description] [varchar](100) COLLATE Thai_CI_AS NULL,
	[Cost] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_SrvStep]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_SrvStep](
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[NameThai] [varchar](100) COLLATE Thai_CI_AS NULL,
	[NameEng] [varchar](100) COLLATE Thai_CI_AS NULL,
	[Start] [varchar](5) COLLATE Thai_CI_AS NULL,
	[Endding] [varchar](5) COLLATE Thai_CI_AS NULL,
	[CY] [varchar](5) COLLATE Thai_CI_AS NULL,
	[UnitCharge] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CurrencyCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DefaultVender] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ProcessDesc] [varchar](250) COLLATE Thai_CI_AS NULL,
	[GLAccountCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[IsTaxCharge] [tinyint] NULL,
	[Is50Tavi] [tinyint] NULL,
	[Rate50Tavi] [float] NULL,
	[IsCredit] [tinyint] NULL,
	[IsExpense] [tinyint] NULL,
	[IsShowPrice] [tinyint] NULL,
	[IsHaveSlip] [tinyint] NULL,
	[IsPay50TaviTo] [tinyint] NULL,
	[IsLtdAdv50Tavi] [tinyint] NULL,
	[ChargeType] [varchar](1) COLLATE Thai_CI_AS NULL,
	[StepSub] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[IsUsedCoSlip] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_SrvStepCost]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_SrvStepCost](
	[VenderCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[StepSub] [varchar](4000) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_SrvTemplate]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_SrvTemplate](
	[STCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[NameThai] [varchar](100) COLLATE Thai_CI_AS NULL,
	[TermOfPayment] [tinyint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_SrvTemplateSub]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_SrvTemplateSub](
	[STCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ItemNo] [int] NULL,
	[SICode] [varchar](50) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_Tax50Tavi]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_Tax50Tavi](
	[BranchCode] [varchar](4) COLLATE Thai_CI_AS NOT NULL,
	[DocNo] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[DocRefType] [tinyint] NULL,
	[DocRefNo] [varchar](20) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[TaxNumber1] [varchar](15) COLLATE Thai_CI_AS NULL,
	[TName1] [varchar](max) COLLATE Thai_CI_AS NULL,
	[TAddress1] [varchar](150) COLLATE Thai_CI_AS NULL,
	[TaxNumber2] [varchar](15) COLLATE Thai_CI_AS NULL,
	[TName2] [varchar](max) COLLATE Thai_CI_AS NULL,
	[TAddress2] [varchar](150) COLLATE Thai_CI_AS NULL,
	[TaxNumber3] [varchar](15) COLLATE Thai_CI_AS NULL,
	[TName3] [varchar](max) COLLATE Thai_CI_AS NULL,
	[TAddress3] [varchar](150) COLLATE Thai_CI_AS NULL,
	[SeqInForm] [int] NULL,
	[FormType] [tinyint] NULL,
	[IncRate] [float] NULL,
	[IncOther] [varchar](70) COLLATE Thai_CI_AS NULL,
	[IncType1] [varchar](5) COLLATE Thai_CI_AS NULL,
	[PayDate1] [datetime] NULL,
	[PayAmount1] [float] NULL,
	[PayTax1] [float] NULL,
	[IncType2] [varchar](5) COLLATE Thai_CI_AS NULL,
	[PayDate2] [datetime] NULL,
	[PayAmount2] [float] NULL,
	[PayTax2] [float] NULL,
	[IncType3] [varchar](5) COLLATE Thai_CI_AS NULL,
	[PayDate3] [datetime] NULL,
	[PayAmount3] [float] NULL,
	[PayTax3] [float] NULL,
	[TotalPayAmount] [float] NULL,
	[TotalPayTax] [float] NULL,
	[SoLicenseNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[SoLicenseAmount] [float] NULL,
	[SoAccAmount] [float] NULL,
	[PayeeAccNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[SoTaxNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[PayTaxType] [tinyint] NULL,
	[PayTaxOther] [varchar](20) COLLATE Thai_CI_AS NULL,
	[IDCard1] [varchar](15) COLLATE Thai_CI_AS NULL,
	[IDCard2] [varchar](15) COLLATE Thai_CI_AS NULL,
	[IDCard3] [varchar](15) COLLATE Thai_CI_AS NULL,
	[PayTaxDesc1] [varchar](50) COLLATE Thai_CI_AS NULL,
	[PayTaxDesc2] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TaxLawNo] [varchar](2) COLLATE Thai_CI_AS NULL,
	[PayTaxDesc3] [varchar](50) COLLATE Thai_CI_AS NULL,
	[UpdateBy] [nvarchar](255) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_JobTax50Tavi] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_TaxInvoice]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_TaxInvoice](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[InvDate] [datetime] NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[BillToCustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[BillToCustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[BillingNO] [varchar](255) COLLATE Thai_CI_AS NULL,
	[VATRate] [float] NULL,
	[TotalCharge] [float] NULL,
	[TotalVAT] [float] NULL,
	[Total50Tavi] [float] NULL,
	[TotalNet] [float] NULL,
	[TRemark] [varchar](250) COLLATE Thai_CI_AS NULL,
	[EmpCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[PrintedBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[PrintedDate] [datetime] NULL,
	[PrintedTime] [datetime] NULL,
	[ReceiveBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ReceiveDate] [datetime] NULL,
	[ReceiveTime] [datetime] NULL,
	[ReceiveRef] [varchar](30) COLLATE Thai_CI_AS NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CurrencyCode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ExchangeRate] [float] NULL,
	[ForeignAmt] [float] NULL,
	[CashDate] [date] NULL,
	[CashAmount] [float] NULL,
	[Transferdate] [date] NULL,
	[TransferBank] [varchar](100) COLLATE Thai_CI_AS NULL,
	[TransferAmount] [float] NULL,
	[CheqDate] [date] NULL,
	[CheqBank] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CheqAmount] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_TaxInvoiceDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_TaxInvoiceDetail](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ItemNo] [smallint] NULL,
	[SICode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SDescription] [varchar](100) COLLATE Thai_CI_AS NULL,
	[Rate50Tavi] [float] NULL,
	[AmtCharge] [float] NULL,
	[AmtVAT] [float] NULL,
	[Amt50Tavi] [float] NULL,
	[Qty] [float] NULL,
	[UnitPrice] [float] NULL,
	[QtyUnit] [varchar](50) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_Transport]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_Transport](
	[BranchCode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[JobNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TransportSeq] [int] NULL,
	[BookingDate] [datetime] NULL,
	[DueDate] [datetime] NULL,
	[DueTime] [datetime] NULL,
	[FromLocation] [varchar](255) COLLATE Thai_CI_AS NULL,
	[ToLocation] [varchar](255) COLLATE Thai_CI_AS NULL,
	[CarType] [tinyint] NULL,
	[CarSize] [tinyint] NULL,
	[Product] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Qty] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Remark] [varchar](255) COLLATE Thai_CI_AS NULL,
	[RequestDept] [varchar](255) COLLATE Thai_CI_AS NULL,
	[RequestBy] [varchar](255) COLLATE Thai_CI_AS NULL,
	[ApproveBy] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ApproveDate] [datetime] NULL,
	[Driver] [varchar](255) COLLATE Thai_CI_AS NULL,
	[CarID] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Reason] [varchar](255) COLLATE Thai_CI_AS NULL,
	[DeliverSlip] [varchar](50) COLLATE Thai_CI_AS NULL,
	[DeliveryDate] [datetime] NULL,
	[DeliverBy] [varchar](255) COLLATE Thai_CI_AS NULL,
	[StartTime] [varchar](10) COLLATE Thai_CI_AS NULL,
	[StartMile] [float] NULL,
	[EndTime] [varchar](10) COLLATE Thai_CI_AS NULL,
	[EndMile] [float] NULL,
	[ArrivalDate] [datetime] NULL,
	[ArrivalTime] [datetime] NULL,
	[SlipNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[SlipDate] [datetime] NULL,
	[CheckedBy] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ClearBy] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ClearDate] [datetime] NULL,
	[DocStatus] [tinyint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_TruckOrder]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_TruckOrder](
	[CarNo] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[CarDate] [datetime] NULL,
	[JobNo] [varchar](20) COLLATE Thai_CI_AS NULL,
	[CustName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CustTel] [varchar](20) COLLATE Thai_CI_AS NULL,
	[SPlace] [varchar](50) COLLATE Thai_CI_AS NULL,
	[DPlace] [varchar](50) COLLATE Thai_CI_AS NULL,
	[SenderName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[SenderTel] [varchar](20) COLLATE Thai_CI_AS NULL,
	[ReceiverName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[GoodsType] [varchar](50) COLLATE Thai_CI_AS NULL,
	[GoodsQty] [varchar](50) COLLATE Thai_CI_AS NULL,
	[GoodsWeight] [float] NULL,
	[CarType] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CarDriver] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CarLicense] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CarStatus] [varchar](1) COLLATE Thai_CI_AS NULL,
	[CarNote] [varchar](250) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_WHTax]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_WHTax](
	[BranchCode] [varchar](4) COLLATE Thai_CI_AS NOT NULL,
	[DocNo] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[DocDate] [datetime] NULL,
	[TaxNumber1] [varchar](15) COLLATE Thai_CI_AS NULL,
	[TName1] [varchar](max) COLLATE Thai_CI_AS NULL,
	[TAddress1] [varchar](max) COLLATE Thai_CI_AS NULL,
	[TaxNumber2] [varchar](15) COLLATE Thai_CI_AS NULL,
	[TName2] [varchar](max) COLLATE Thai_CI_AS NULL,
	[TAddress2] [varchar](max) COLLATE Thai_CI_AS NULL,
	[TaxNumber3] [varchar](15) COLLATE Thai_CI_AS NULL,
	[TName3] [varchar](max) COLLATE Thai_CI_AS NULL,
	[TAddress3] [varchar](max) COLLATE Thai_CI_AS NULL,
	[IDCard1] [varchar](15) COLLATE Thai_CI_AS NULL,
	[IDCard2] [varchar](15) COLLATE Thai_CI_AS NULL,
	[IDCard3] [varchar](15) COLLATE Thai_CI_AS NULL,
	[SeqInForm] [int] NULL,
	[FormType] [tinyint] NULL,
	[TaxLawNo] [varchar](2) COLLATE Thai_CI_AS NULL,
	[IncRate] [float] NULL,
	[IncOther] [varchar](70) COLLATE Thai_CI_AS NULL,
	[UpdateBy] [nvarchar](255) COLLATE Thai_CI_AS NULL,
	[TotalPayAmount] [float] NULL,
	[TotalPayTax] [float] NULL,
	[SoLicenseNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[SoLicenseAmount] [float] NULL,
	[SoAccAmount] [float] NULL,
	[PayeeAccNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[SoTaxNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[PayTaxType] [tinyint] NULL,
	[PayTaxOther] [varchar](20) COLLATE Thai_CI_AS NULL,
	[CancelProve] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CancelReason] [varchar](max) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL,
	[Branch1] [varchar](5) COLLATE Thai_CI_AS NULL,
	[Branch2] [varchar](5) COLLATE Thai_CI_AS NULL,
	[Branch3] [varchar](5) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_JobWHTax] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_WHTaxDetail]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_WHTaxDetail](
	[BranchCode] [varchar](4) COLLATE Thai_CI_AS NOT NULL,
	[DocNo] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[ItemNo] [int] NOT NULL,
	[IncType] [varchar](5) COLLATE Thai_CI_AS NULL,
	[PayDate] [datetime] NULL,
	[PayAmount] [float] NULL,
	[PayTax] [float] NULL,
	[PayTaxDesc] [varchar](50) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[DocRefType] [tinyint] NULL,
	[DocRefNo] [varchar](20) COLLATE Thai_CI_AS NULL,
	[PayRate] [float] NULL,
 CONSTRAINT [PK_JobWHTaxD] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_Agent]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_Agent](
	[Code] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TName] [varchar](255) COLLATE Thai_CI_AS NULL,
	[English] [varchar](255) COLLATE Thai_CI_AS NULL,
	[TAddress1] [varchar](255) COLLATE Thai_CI_AS NULL,
	[TAddress2] [varchar](255) COLLATE Thai_CI_AS NULL,
	[EAddress1] [varchar](255) COLLATE Thai_CI_AS NULL,
	[EAddress2] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Phone] [varchar](255) COLLATE Thai_CI_AS NULL,
	[FaxNumber] [varchar](255) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_BankCode]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_BankCode](
	[Code] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[BName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CustomsCode] [varchar](3) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [pK_masbankcode] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_BookAccount]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_BookAccount](
	[BranchCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[BookCode] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[BookName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[BankCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[BankBranch] [varchar](50) COLLATE Thai_CI_AS NULL,
	[IsLocal] [tinyint] NOT NULL,
	[ACType] [varchar](10) COLLATE Thai_CI_AS NULL,
	[TAddress1] [varchar](70) COLLATE Thai_CI_AS NULL,
	[TAddress2] [varchar](70) COLLATE Thai_CI_AS NULL,
	[EAddress1] [varchar](70) COLLATE Thai_CI_AS NULL,
	[EAddress2] [varchar](70) COLLATE Thai_CI_AS NULL,
	[Phone] [varchar](30) COLLATE Thai_CI_AS NULL,
	[FaxNumber] [varchar](30) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [pk_masbookacc] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[BookCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_Branch]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_Branch](
	[Code] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[BrName] [varchar](50) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [pk_branch] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_Broker]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_Broker](
	[ID] [varchar](20) COLLATE Thai_CI_AS NULL,
	[Name] [varchar](60) COLLATE Thai_CI_AS NULL,
	[CardBeginDate] [datetime] NULL,
	[CardFinishDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_CompAccess]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_CompAccess](
	[CompName] [varchar](30) COLLATE Thai_CI_AS NULL,
	[AppName] [varchar](20) COLLATE Thai_CI_AS NULL,
	[OpenDate] [datetime] NULL,
	[OpenTime] [datetime] NULL,
	[CloseDate] [datetime] NULL,
	[CloseTime] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_Company]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_Company](
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NOT NULL,
	[Branch] [varchar](10) COLLATE Thai_CI_AS NOT NULL,
	[CustGroup] [varchar](20) COLLATE Thai_CI_AS NULL,
	[TaxNumber] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Title] [varchar](15) COLLATE Thai_CI_AS NULL,
	[NameThai] [varchar](255) COLLATE Thai_CI_AS NULL,
	[NameEng] [varchar](255) COLLATE Thai_CI_AS NULL,
	[TAddress1] [varchar](80) COLLATE Thai_CI_AS NULL,
	[TAddress2] [varchar](80) COLLATE Thai_CI_AS NULL,
	[EAddress1] [varchar](80) COLLATE Thai_CI_AS NULL,
	[EAddress2] [varchar](80) COLLATE Thai_CI_AS NULL,
	[Phone] [varchar](30) COLLATE Thai_CI_AS NULL,
	[FaxNumber] [varchar](30) COLLATE Thai_CI_AS NULL,
	[LoginName] [varchar](20) COLLATE Thai_CI_AS NULL,
	[LoginPassword] [varchar](20) COLLATE Thai_CI_AS NULL,
	[ManagerCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CSCodeIM] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CSCodeEX] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CSCodeOT] [varchar](10) COLLATE Thai_CI_AS NULL,
	[GLAccountCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustType] [tinyint] NOT NULL,
	[BillToCustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[BillToBranch] [varchar](10) COLLATE Thai_CI_AS NULL,
	[UsedLanguage] [varchar](2) COLLATE Thai_CI_AS NULL,
	[LevelGrade] [varchar](5) COLLATE Thai_CI_AS NULL,
	[TermOfPayment] [tinyint] NULL,
	[BillCondition] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CreditLimit] [float] NULL,
	[MapText] [varchar](250) COLLATE Thai_CI_AS NULL,
	[MapFileName] [varchar](150) COLLATE Thai_CI_AS NULL,
	[CmpType] [varchar](1) COLLATE Thai_CI_AS NULL,
	[CmpLevelExp] [varchar](1) COLLATE Thai_CI_AS NULL,
	[CmpLevelImp] [varchar](1) COLLATE Thai_CI_AS NULL,
	[Is19bis] [tinyint] NOT NULL,
	[MgrSeq] [smallint] NOT NULL,
	[LevelNoExp] [int] NOT NULL,
	[LevelNoImp] [int] NOT NULL,
	[LnNO] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AdjTaxCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[BkAuthorNo] [varchar](10) COLLATE Thai_CI_AS NULL,
	[BkAuthorCnn] [varchar](10) COLLATE Thai_CI_AS NULL,
	[LtdPsWkName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[ConsStatus] [varchar](255) COLLATE Thai_CI_AS NULL,
	[CommLevel] [varchar](2) COLLATE Thai_CI_AS NULL,
	[DutyLimit] [float] NOT NULL,
	[CommRate] [float] NOT NULL,
	[TAddress] [varchar](255) COLLATE Thai_CI_AS NULL,
	[TDistrict] [varchar](35) COLLATE Thai_CI_AS NULL,
	[TSubProvince] [varchar](35) COLLATE Thai_CI_AS NULL,
	[TProvince] [varchar](3) COLLATE Thai_CI_AS NULL,
	[TPostCode] [varchar](9) COLLATE Thai_CI_AS NULL,
	[DMailAddress] [varchar](35) COLLATE Thai_CI_AS NULL,
	[PrivilegeOption] [varchar](1) COLLATE Thai_CI_AS NULL,
	[GoldCardNO] [smallint] NOT NULL,
	[CustomsBrokerSeq] [smallint] NOT NULL,
	[ISCustomerSign] [tinyint] NOT NULL,
	[ISCustomerSignInv] [tinyint] NOT NULL,
	[ISCustomerSignDec] [tinyint] NOT NULL,
	[ISCustomerSignECon] [tinyint] NOT NULL,
	[IsShippingCannotSign] [tinyint] NOT NULL,
	[ExportCode] [varchar](20) COLLATE Thai_CI_AS NULL,
	[Code19BIS] [varchar](15) COLLATE Thai_CI_AS NULL,
	[WEB_SITE] [varchar](255) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [pk_company] PRIMARY KEY CLUSTERED 
(
	[CustCode] ASC,
	[Branch] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_Config]    Script Date: 08-Mar-19 11:31:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_Config](
	[ConfigCode] [nvarchar](50) COLLATE Thai_CI_AS NOT NULL,
	[ConfigKey] [nvarchar](500) COLLATE Thai_CI_AS NOT NULL,
	[ConfigValue] [nvarchar](max) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED 
(
	[ConfigCode] ASC,
	[ConfigKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_Consignee]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_Consignee](
	[TaxNumber] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Code] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Name] [varchar](70) COLLATE Thai_CI_AS NULL,
	[Address1] [varchar](70) COLLATE Thai_CI_AS NULL,
	[Address2] [varchar](70) COLLATE Thai_CI_AS NULL,
	[Phone] [varchar](15) COLLATE Thai_CI_AS NULL,
	[FaxNumber] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CountryCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[NameEng] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CityName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ZipCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DestinationPort] [varchar](30) COLLATE Thai_CI_AS NULL,
	[CommFormName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[PackFormName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CustFormName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CommStyle] [varchar](2) COLLATE Thai_CI_AS NULL,
	[CustStyle] [varchar](2) COLLATE Thai_CI_AS NULL,
	[PackStyle] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TAddress] [varchar](255) COLLATE Thai_CI_AS NULL,
	[TDistrict] [varchar](35) COLLATE Thai_CI_AS NULL,
	[TSubProvince] [varchar](35) COLLATE Thai_CI_AS NULL,
	[TProvince] [varchar](3) COLLATE Thai_CI_AS NULL,
	[TPostCode] [varchar](9) COLLATE Thai_CI_AS NULL,
	[DMailAddress] [varchar](35) COLLATE Thai_CI_AS NULL,
	[ConsStatus] [varchar](2) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_ConsignTo]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_ConsignTo](
	[TaxNumber] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ConCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ConTo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[NameEng] [varchar](100) COLLATE Thai_CI_AS NULL,
	[Address1] [varchar](100) COLLATE Thai_CI_AS NULL,
	[Address2] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CityName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ZipCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CountryCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DestinationPort] [varchar](30) COLLATE Thai_CI_AS NULL,
	[Phone] [varchar](15) COLLATE Thai_CI_AS NULL,
	[FaxNumber] [varchar](15) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_CountryFT]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_CountryFT](
	[CTYCODE] [varchar](3) COLLATE Thai_CI_AS NOT NULL,
	[CTYName] [varchar](35) COLLATE Thai_CI_AS NULL,
	[CURCODE] [varchar](3) COLLATE Thai_CI_AS NULL,
	[FTCODE] [int] NULL,
	[CUCODE] [int] NULL,
 CONSTRAINT [pk_country] PRIMARY KEY CLUSTERED 
(
	[CTYCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_CurrencyCode]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_CurrencyCode](
	[Code] [varchar](3) COLLATE Thai_CI_AS NOT NULL,
	[TName] [varchar](35) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL,
 CONSTRAINT [pk_currency] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_CustContact]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_CustContact](
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Branch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[ItemNo] [smallint] NULL,
	[DepType] [varchar](20) COLLATE Thai_CI_AS NULL,
	[UPosition] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[EMail] [varchar](50) COLLATE Thai_CI_AS NULL,
	[PhoneExtn] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DMail] [varchar](50) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_CustCredit]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_CustCredit](
	[custcode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[custbranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[recvno] [varchar](255) COLLATE Thai_CI_AS NULL,
	[recvdate] [datetime] NULL,
	[recvamount] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_DocType]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_DocType](
	[DocType] [varchar](5) COLLATE Thai_CI_AS NULL,
	[DocName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[StartAtType] [tinyint] NULL,
	[DDuration] [varchar](50) COLLATE Thai_CI_AS NULL,
	[IsFollowUp] [tinyint] NULL,
	[IsSendToCustomer] [tinyint] NULL,
	[IsCalling] [tinyint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_Factory]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_Factory](
	[FactoryNo] [varchar](8) COLLATE Thai_CI_AS NULL,
	[FactoryName] [varchar](255) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MAS_GLACCOUNT]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAS_GLACCOUNT](
	[BranchCode] [nvarchar](10) COLLATE Thai_CI_AS NOT NULL,
	[JobType] [int] NOT NULL,
	[ShipBy] [int] NOT NULL,
	[GLCostCode] [nvarchar](50) COLLATE Thai_CI_AS NULL,
	[GLCostName] [nvarchar](500) COLLATE Thai_CI_AS NULL,
	[GLSalesCode] [nvarchar](50) COLLATE Thai_CI_AS NULL,
	[GLSalsesName] [nvarchar](500) COLLATE Thai_CI_AS NULL,
	[IDent] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_MAS_GLACCOUNT] PRIMARY KEY CLUSTERED 
(
	[IDent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_HistoryLog]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_HistoryLog](
	[LogID] [int] NULL,
	[LogDate] [datetime] NULL,
	[LogTime] [datetime] NULL,
	[EmpCode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[LogType] [tinyint] NULL,
	[Description] [varchar](250) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_InvExpense]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_InvExpense](
	[ExpCode] [varchar](2) COLLATE Thai_CI_AS NULL,
	[Descriptions] [varchar](100) COLLATE Thai_CI_AS NULL,
	[StdCost] [float] NULL,
	[CurrencyCode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[GroupType] [tinyint] NULL,
	[ItemAvgType] [tinyint] NULL,
	[IsDestCharge] [tinyint] NULL,
	[Incoterms2000] [varchar](100) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_InvUnit]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_InvUnit](
	[Code] [varchar](20) COLLATE Thai_CI_AS NULL,
	[TName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[EDICode] [varchar](3) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_LoadCause]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_LoadCause](
	[Code] [varchar](5) COLLATE Thai_CI_AS NULL,
	[TName] [varchar](50) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_Manager]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_Manager](
	[TaxNumber] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SeqNO] [smallint] NULL,
	[Name] [varchar](60) COLLATE Thai_CI_AS NULL,
	[CardID] [varchar](40) COLLATE Thai_CI_AS NULL,
	[Type] [smallint] NULL,
	[CardBeginDate] [datetime] NULL,
	[CardFinishDate] [datetime] NULL,
	[LastUpDate] [datetime] NULL,
	[LtdPsOld] [smallint] NULL,
	[LtdPsNation] [varchar](15) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_PdtGroup]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_PdtGroup](
	[TaxNumber] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Code] [varchar](10) COLLATE Thai_CI_AS NULL,
	[TName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[EName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[CustCode] [varchar](10) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_PermitIssue]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_PermitIssue](
	[IssueBy] [varchar](17) COLLATE Thai_CI_AS NULL,
	[IssueName] [varchar](100) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_Product]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_Product](
	[Taxnumber] [varchar](10) COLLATE Thai_CI_AS NULL,
	[GroupCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Code] [varchar](20) COLLATE Thai_CI_AS NULL,
	[TariffClass] [varchar](7) COLLATE Thai_CI_AS NULL,
	[TariffSeq] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TariffStatCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[RTCProductCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ProductYear] [smallint] NULL,
	[WeightUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[QuantityUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[AllPrice] [varchar](50) COLLATE Thai_CI_AS NULL,
	[InvoiceQTYUnit] [varchar](50) COLLATE Thai_CI_AS NULL,
	[BrandName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[ProductAttribute1] [varchar](70) COLLATE Thai_CI_AS NULL,
	[ProductAttribute2] [varchar](70) COLLATE Thai_CI_AS NULL,
	[Desc1] [varchar](70) COLLATE Thai_CI_AS NULL,
	[Desc2] [varchar](70) COLLATE Thai_CI_AS NULL,
	[Desc3] [varchar](70) COLLATE Thai_CI_AS NULL,
	[Degree] [float] NULL,
	[CC] [float] NULL,
	[Remark] [varchar](80) COLLATE Thai_CI_AS NULL,
	[AFTACode] [varchar](5) COLLATE Thai_CI_AS NULL,
	[ExciseNo] [varchar](20) COLLATE Thai_CI_AS NULL,
	[LastUpdate] [datetime] NULL,
	[AnnPrice] [float] NULL,
	[FormulaNo] [varchar](20) COLLATE Thai_CI_AS NULL,
	[NewRawCode] [varchar](6) COLLATE Thai_CI_AS NULL,
	[OldRawCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[RawUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[OtherPdtName] [tinyint] NULL,
	[CurUnitPrice] [varchar](3) COLLATE Thai_CI_AS NULL,
	[BondNo] [varchar](10) COLLATE Thai_CI_AS NULL,
	[BoiNo] [varchar](20) COLLATE Thai_CI_AS NULL,
	[Compen] [varchar](1) COLLATE Thai_CI_AS NULL,
	[Announce1] [varchar](100) COLLATE Thai_CI_AS NULL,
	[Announce2] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ShipMark1] [varchar](35) COLLATE Thai_CI_AS NULL,
	[ShipMark2] [varchar](35) COLLATE Thai_CI_AS NULL,
	[ShipMark3] [varchar](35) COLLATE Thai_CI_AS NULL,
	[ShipMark4] [varchar](35) COLLATE Thai_CI_AS NULL,
	[ShipMark5] [varchar](35) COLLATE Thai_CI_AS NULL,
	[ShipMark6] [varchar](35) COLLATE Thai_CI_AS NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[InvDesc] [varchar](150) COLLATE Thai_CI_AS NULL,
	[DecDesc1] [varchar](70) COLLATE Thai_CI_AS NULL,
	[DecDesc2] [varchar](70) COLLATE Thai_CI_AS NULL,
	[DecDesc3] [varchar](70) COLLATE Thai_CI_AS NULL,
	[DecDesc4] [varchar](70) COLLATE Thai_CI_AS NULL,
	[DecDesc5] [varchar](70) COLLATE Thai_CI_AS NULL,
	[CardAmt] [smallint] NULL,
	[IsRawmat] [tinyint] NULL,
	[RawCode] [varchar](20) COLLATE Thai_CI_AS NULL,
	[BOIQuotaCode] [varchar](4) COLLATE Thai_CI_AS NULL,
	[BOIQuotaNo] [varchar](6) COLLATE Thai_CI_AS NULL,
	[BOIType] [tinyint] NULL,
	[PermitNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CommodityAWB] [varchar](4) COLLATE Thai_CI_AS NULL,
	[RTCCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[PrivilegeCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[ExportTariff] [varchar](12) COLLATE Thai_CI_AS NULL,
	[UNDGNumber] [varchar](4) COLLATE Thai_CI_AS NULL,
	[PdtUnitCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[IsPermit] [tinyint] NULL,
	[IsReExport] [tinyint] NULL,
	[Prate] [float] NULL,
	[Srate] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_ProductMark]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_ProductMark](
	[TaxNumber] [varchar](15) COLLATE Thai_CI_AS NULL,
	[GroupCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Code] [varchar](20) COLLATE Thai_CI_AS NULL,
	[Consignee] [varchar](10) COLLATE Thai_CI_AS NULL,
	[BrandName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[MarkDesc1] [varchar](50) COLLATE Thai_CI_AS NULL,
	[MarkDesc2] [varchar](50) COLLATE Thai_CI_AS NULL,
	[MarkDesc3] [varchar](50) COLLATE Thai_CI_AS NULL,
	[MarkDesc4] [varchar](50) COLLATE Thai_CI_AS NULL,
	[MarkDesc5] [varchar](50) COLLATE Thai_CI_AS NULL,
	[MarkDesc6] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ImageFileName] [varchar](100) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_ProductSub]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_ProductSub](
	[TaxNumber] [varchar](15) COLLATE Thai_CI_AS NULL,
	[GroupCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Code] [varchar](20) COLLATE Thai_CI_AS NULL,
	[SubCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[SubDescEng] [varchar](100) COLLATE Thai_CI_AS NULL,
	[SubDescThai] [varchar](100) COLLATE Thai_CI_AS NULL,
	[SubLabel] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ImageFileName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[DimSize] [varchar](50) COLLATE Thai_CI_AS NULL,
	[DimUnit] [varchar](20) COLLATE Thai_CI_AS NULL,
	[OriginalUnit] [varchar](20) COLLATE Thai_CI_AS NULL,
	[WeightUnit] [varchar](20) COLLATE Thai_CI_AS NULL,
	[PackRatio] [varchar](100) COLLATE Thai_CI_AS NULL,
	[SalesPackUnit] [varchar](20) COLLATE Thai_CI_AS NULL,
	[SalesPackPerQty] [float] NULL,
	[SalesPrice] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CalcPriceFrom] [tinyint] NULL,
	[SubRawCode] [varchar](20) COLLATE Thai_CI_AS NULL,
	[SubRawUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[SubFormulaNo] [varchar](30) COLLATE Thai_CI_AS NULL,
	[NetWeight] [float] NULL,
	[GrossWeight] [float] NULL,
	[BarcodeType] [varchar](15) COLLATE Thai_CI_AS NULL,
	[BarCodeNo] [varchar](20) COLLATE Thai_CI_AS NULL,
	[PackToPrint] [varchar](100) COLLATE Thai_CI_AS NULL,
	[UnitRatio] [varchar](50) COLLATE Thai_CI_AS NULL,
	[PackageUnit] [varchar](20) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_Province]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_Province](
	[ProvinceCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[ProvinceName] [varchar](35) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_ProvinceSub]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_ProvinceSub](
	[ProvinceCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[SubProvince] [varchar](35) COLLATE Thai_CI_AS NULL,
	[District] [varchar](35) COLLATE Thai_CI_AS NULL,
	[PostCode] [varchar](9) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_REFEDR]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_REFEDR](
	[ExportTariff] [varchar](12) COLLATE Thai_CI_AS NULL,
	[TariffSeq] [varchar](5) COLLATE Thai_CI_AS NULL,
	[DutyCode] [varchar](1) COLLATE Thai_CI_AS NULL,
	[DutyRate] [float] NULL,
	[DutyRateS] [float] NULL,
	[SpecCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[Description] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[DescriptionEng] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[AnnounceNo] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AnnounceDate] [datetime] NULL,
	[AnnDesc] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_REFIDR]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_REFIDR](
	[ImportTariff] [varchar](12) COLLATE Thai_CI_AS NULL,
	[TariffSeq] [varchar](5) COLLATE Thai_CI_AS NULL,
	[DutyCode] [varchar](1) COLLATE Thai_CI_AS NULL,
	[DutyRate] [float] NULL,
	[DutyRateS] [float] NULL,
	[SpecCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[AnnounceNo] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AnnounceDate] [datetime] NULL,
	[Description] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_REFIPC]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_REFIPC](
	[PortCode] [varchar](5) COLLATE Thai_CI_AS NULL,
	[PortName] [varchar](125) COLLATE Thai_CI_AS NULL,
	[CountryCode] [varchar](2) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_REFPVC]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_REFPVC](
	[PrivCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[PrivDesc] [varchar](255) COLLATE Thai_CI_AS NULL,
	[AnnounceNo] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AnnounceDate] [datetime] NULL,
	[Description] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_REFPVL]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_REFPVL](
	[TariffClass] [varchar](12) COLLATE Thai_CI_AS NULL,
	[TariffSeq] [varchar](5) COLLATE Thai_CI_AS NULL,
	[CountryCode] [varchar](2) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[TGRLEV] [varchar](3) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_REFSSG]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_REFSSG](
	[TGRLEV] [varchar](3) COLLATE Thai_CI_AS NULL,
	[TGYear] [smallint] NULL,
	[PermitQty] [float] NULL,
	[PermitQtyRmn] [float] NULL,
	[QtyUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_REFTRC]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_REFTRC](
	[TariffClass] [varchar](12) COLLATE Thai_CI_AS NULL,
	[TariffDescThai] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[TariffDescEng] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_REFTRS]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_REFTRS](
	[TariffClass] [varchar](12) COLLATE Thai_CI_AS NULL,
	[StatCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[StatDescThai] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[StatDescEng] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[UnitCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[AnnounceNo] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AnnounceDate] [datetime] NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_Register]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_Register](
	[TaxNumber] [varchar](10) COLLATE Thai_CI_AS NULL,
	[LtdNameEng] [varchar](70) COLLATE Thai_CI_AS NULL,
	[LtdNameThai] [varchar](70) COLLATE Thai_CI_AS NULL,
	[MgrSeq] [smallint] NULL,
	[AddrSeq] [smallint] NULL,
	[EDIUserID] [varchar](8) COLLATE Thai_CI_AS NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFARS]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFARS](
	[AreaCode] [varchar](5) COLLATE Thai_CI_AS NOT NULL,
	[AreaName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[AccNo] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Payee] [varchar](10) COLLATE Thai_CI_AS NULL,
	[BankCode] [varchar](5) COLLATE Thai_CI_AS NULL,
	[AcType] [varchar](1) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [pk_customsPort] PRIMARY KEY CLUSTERED 
(
	[AreaCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFATA]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFATA](
	[CTYATA] [varchar](2) COLLATE Thai_CI_AS NULL,
	[CUNCDE01] [smallint] NULL,
	[CUNCDE02] [smallint] NULL,
	[CUNCDE03] [smallint] NULL,
	[CUNCDE04] [smallint] NULL,
	[CUNCDE05] [smallint] NULL,
	[CUNCDE06] [smallint] NULL,
	[CUNCDE07] [smallint] NULL,
	[CUNCDE08] [smallint] NULL,
	[CUNCDE09] [smallint] NULL,
	[CUNCDE10] [smallint] NULL,
	[CUNCDE11] [smallint] NULL,
	[CUNCDE12] [smallint] NULL,
	[CUNCDE13] [smallint] NULL,
	[CUNCDE14] [smallint] NULL,
	[CUNNME01] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CUNNME02] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CUNNME03] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CUNNME04] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CUNNME05] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CUNNME06] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CUNNME07] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CUNNME08] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CUNNME09] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CUNNME10] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CUNNME11] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CUNNME12] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CUNNME13] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CUNNME14] [varchar](50) COLLATE Thai_CI_AS NULL,
	[AGM01] [varchar](1) COLLATE Thai_CI_AS NULL,
	[AGM02] [varchar](1) COLLATE Thai_CI_AS NULL,
	[AGM03] [varchar](1) COLLATE Thai_CI_AS NULL,
	[AGM04] [varchar](1) COLLATE Thai_CI_AS NULL,
	[AGM05] [varchar](1) COLLATE Thai_CI_AS NULL,
	[AGM06] [varchar](1) COLLATE Thai_CI_AS NULL,
	[AGM07] [varchar](1) COLLATE Thai_CI_AS NULL,
	[AGM08] [varchar](1) COLLATE Thai_CI_AS NULL,
	[AGM09] [varchar](1) COLLATE Thai_CI_AS NULL,
	[AGM10] [varchar](1) COLLATE Thai_CI_AS NULL,
	[AGM11] [varchar](1) COLLATE Thai_CI_AS NULL,
	[AGM12] [varchar](1) COLLATE Thai_CI_AS NULL,
	[AGM13] [varchar](1) COLLATE Thai_CI_AS NULL,
	[AGM14] [varchar](1) COLLATE Thai_CI_AS NULL,
	[DTESTR] [datetime] NULL,
	[DTEFIN] [datetime] NULL,
	[UIDCTEAMN] [varchar](50) COLLATE Thai_CI_AS NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFBFM]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFBFM](
	[TaxNumber] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Code] [varchar](20) COLLATE Thai_CI_AS NULL,
	[Parent] [varchar](40) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[Desc1] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Desc2] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Desc3] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Desc4] [varchar](50) COLLATE Thai_CI_AS NULL,
	[UID] [varchar](6) COLLATE Thai_CI_AS NULL,
	[RecDate] [datetime] NULL,
	[RecTime] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFBOI]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFBOI](
	[BOINumber] [varchar](7) COLLATE Thai_CI_AS NULL,
	[BOI_Expand] [varchar](30) COLLATE Thai_CI_AS NULL,
	[IssuedDate] [datetime] NULL,
	[RefNumber] [varchar](10) COLLATE Thai_CI_AS NULL,
	[TaxNumber1] [varchar](10) COLLATE Thai_CI_AS NULL,
	[TaxNumber2] [varchar](10) COLLATE Thai_CI_AS NULL,
	[TaxNumber3] [varchar](10) COLLATE Thai_CI_AS NULL,
	[TaxNumber4] [varchar](10) COLLATE Thai_CI_AS NULL,
	[MachineEffDate] [datetime] NULL,
	[MachineExpDate] [datetime] NULL,
	[RawMatEffDate] [datetime] NULL,
	[RawMatExpDate] [datetime] NULL,
	[GoodType1] [float] NULL,
	[GoodType2] [float] NULL,
	[GoodType3] [float] NULL,
	[UID] [varchar](6) COLLATE Thai_CI_AS NULL,
	[RecDate] [datetime] NULL,
	[RecTime] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFBQT]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFBQT](
	[BOIQTANUM] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DTEISU] [datetime] NULL,
	[BOIQTATYP] [smallint] NULL,
	[BOIEMTRTE] [float] NULL,
	[CAT] [varchar](1) COLLATE Thai_CI_AS NULL,
	[CMPTAXNUM1] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CMPTAXNUM2] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CMPTAXNUM3] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CMPTAXNUM4] [varchar](10) COLLATE Thai_CI_AS NULL,
	[REFBQTNUM] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DTEREFBQT] [datetime] NULL,
	[IVCNUM1] [varchar](35) COLLATE Thai_CI_AS NULL,
	[DTEIVC1] [datetime] NULL,
	[IVCNUM2] [varchar](35) COLLATE Thai_CI_AS NULL,
	[DTEIVC2] [datetime] NULL,
	[IVCNUM3] [varchar](35) COLLATE Thai_CI_AS NULL,
	[DTEIVC3] [datetime] NULL,
	[IVCNUM4] [varchar](35) COLLATE Thai_CI_AS NULL,
	[DTEIVC4] [datetime] NULL,
	[BOINUM1] [varchar](7) COLLATE Thai_CI_AS NULL,
	[DTEBOI1] [datetime] NULL,
	[BOINUM2] [varchar](7) COLLATE Thai_CI_AS NULL,
	[DTEBOI2] [datetime] NULL,
	[BOINUM3] [varchar](7) COLLATE Thai_CI_AS NULL,
	[DTEBOI3] [datetime] NULL,
	[BOINUM4] [varchar](7) COLLATE Thai_CI_AS NULL,
	[DTEBOI4] [datetime] NULL,
	[DTEEFV] [datetime] NULL,
	[DTEEPR] [varchar](50) COLLATE Thai_CI_AS NULL,
	[UIDCTEAMN] [varchar](6) COLLATE Thai_CI_AS NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFCEP]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFCEP](
	[TRFCLS] [varchar](7) COLLATE Thai_CI_AS NULL,
	[CEPCDE] [varchar](3) COLLATE Thai_CI_AS NULL,
	[TRFSEQ] [varchar](2) COLLATE Thai_CI_AS NULL,
	[DSCTRS1] [varchar](60) COLLATE Thai_CI_AS NULL,
	[DSCTRS2] [varchar](60) COLLATE Thai_CI_AS NULL,
	[DSCTRS3] [varchar](60) COLLATE Thai_CI_AS NULL,
	[DSCTRS4] [varchar](60) COLLATE Thai_CI_AS NULL,
	[DSCTRS5] [varchar](60) COLLATE Thai_CI_AS NULL,
	[DTESTR] [datetime] NULL,
	[DTEFIN] [datetime] NULL,
	[DTYRTE1] [float] NULL,
	[DTYRTE2] [float] NULL,
	[BNAGM] [varchar](1) COLLATE Thai_CI_AS NULL,
	[IDAGM] [varchar](1) COLLATE Thai_CI_AS NULL,
	[LAAGM] [varchar](1) COLLATE Thai_CI_AS NULL,
	[MYAGM] [varchar](1) COLLATE Thai_CI_AS NULL,
	[MMAGM] [varchar](1) COLLATE Thai_CI_AS NULL,
	[PHAGM] [varchar](1) COLLATE Thai_CI_AS NULL,
	[SGAGM] [varchar](1) COLLATE Thai_CI_AS NULL,
	[VNAGM] [varchar](1) COLLATE Thai_CI_AS NULL,
	[UIDCTEAMN] [varchar](6) COLLATE Thai_CI_AS NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL,
	[KHAGM] [varchar](1) COLLATE Thai_CI_AS NULL,
	[DTYSPE1] [float] NULL,
	[DTYSPE2] [float] NULL,
	[DTYCDE] [varchar](1) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFCKD]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFCKD](
	[CKDAPRNUM] [varchar](8) COLLATE Thai_CI_AS NULL,
	[BANNME] [varchar](20) COLLATE Thai_CI_AS NULL,
	[PRDATB1] [varchar](35) COLLATE Thai_CI_AS NULL,
	[PRDCDE] [varchar](20) COLLATE Thai_CI_AS NULL,
	[CMPTAXNUM] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CMPBRN] [varchar](4) COLLATE Thai_CI_AS NULL,
	[PRTTYP] [varchar](50) COLLATE Thai_CI_AS NULL,
	[CKDSEQNUM] [int] NULL,
	[QTYPERUNT] [smallint] NULL,
	[DPMIDT] [varchar](8) COLLATE Thai_CI_AS NULL,
	[JOBTYP] [varchar](2) COLLATE Thai_CI_AS NULL,
	[CKDPRTNME] [varchar](50) COLLATE Thai_CI_AS NULL,
	[PRTNTE] [varchar](50) COLLATE Thai_CI_AS NULL,
	[DTESTR] [datetime] NULL,
	[DTEFIN] [datetime] NULL,
	[UIDCTEAMN] [varchar](6) COLLATE Thai_CI_AS NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFCTR]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFCTR](
	[TariffClass] [varchar](7) COLLATE Thai_CI_AS NULL,
	[TariffSeq] [varchar](2) COLLATE Thai_CI_AS NULL,
	[CompensationRate] [float] NULL,
	[AnnounceNo] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AnnounceDate] [datetime] NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFDCT]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFDCT](
	[Type] [varchar](3) COLLATE Thai_CI_AS NOT NULL,
	[Description] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Category] [varchar](1) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL,
 CONSTRAINT [pk_declareType] PRIMARY KEY CLUSTERED 
(
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFDRT]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFDRT](
	[TRFCLS] [varchar](12) COLLATE Thai_CI_AS NULL,
	[TRFSEQ] [varchar](5) COLLATE Thai_CI_AS NULL,
	[DTYCDE] [varchar](1) COLLATE Thai_CI_AS NULL,
	[DTYYRTE] [float] NULL,
	[DTYSPE] [float] NULL,
	[SPECDE] [varchar](3) COLLATE Thai_CI_AS NULL,
	[ANONUM] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DTEANO] [datetime] NULL,
	[DTESTR] [datetime] NULL,
	[DTEFIN] [datetime] NULL,
	[DSCTRS1] [varchar](60) COLLATE Thai_CI_AS NULL,
	[DSCTRS2] [varchar](60) COLLATE Thai_CI_AS NULL,
	[UIDCTEAMN] [varchar](6) COLLATE Thai_CI_AS NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFDTB]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFDTB](
	[DTBUNTCDE] [varchar](6) COLLATE Thai_CI_AS NULL,
	[DTBCST] [float] NULL,
	[SUBUNTCDE] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DTEANO] [datetime] NULL,
	[DTESTR] [datetime] NULL,
	[UIDCTEAMN] [varchar](6) COLLATE Thai_CI_AS NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFECS]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFECS](
	[ECSNUM] [varchar](8) COLLATE Thai_CI_AS NULL,
	[DTESTR] [datetime] NULL,
	[ECSCDE] [varchar](1) COLLATE Thai_CI_AS NULL,
	[ECSRTE] [float] NULL,
	[ECSSPE] [float] NULL,
	[SPECDE] [varchar](3) COLLATE Thai_CI_AS NULL,
	[CALAVRCDE] [varchar](1) COLLATE Thai_CI_AS NULL,
	[CALSPE] [varchar](1) COLLATE Thai_CI_AS NULL,
	[DIFCDE] [varchar](1) COLLATE Thai_CI_AS NULL,
	[CST] [float] NULL,
	[ANONUM] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DTEANO] [datetime] NULL,
	[DTEFIN] [datetime] NULL,
	[UIDCTEAMN] [varchar](6) COLLATE Thai_CI_AS NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFECU]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFECU](
	[CurrencyCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[ExchangeRate] [float] NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFEDR]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFEDR](
	[TariffClass] [varchar](12) COLLATE Thai_CI_AS NULL,
	[TariffSeq] [varchar](5) COLLATE Thai_CI_AS NULL,
	[DutyCode] [varchar](1) COLLATE Thai_CI_AS NULL,
	[AdDutyRate] [float] NULL,
	[SpecDutyRate] [float] NULL,
	[SpecCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[AnnounceNo] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AnnounceDate] [datetime] NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFERT]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFERT](
	[ERT] [float] NULL,
	[CSTWHLCL] [float] NULL,
	[CSTWOLCL] [float] NULL,
	[DTESTR] [datetime] NULL,
	[DTEFIN] [datetime] NULL,
	[UIDCTEAMN] [varchar](6) COLLATE Thai_CI_AS NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFETB]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFETB](
	[ETBNUM] [varchar](4) COLLATE Thai_CI_AS NULL,
	[ETBNME] [varchar](35) COLLATE Thai_CI_AS NULL,
	[CMPTAXNUM] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CMPBRN] [varchar](4) COLLATE Thai_CI_AS NULL,
	[ADR1] [varchar](70) COLLATE Thai_CI_AS NULL,
	[ADR2] [varchar](70) COLLATE Thai_CI_AS NULL,
	[PHN] [varchar](15) COLLATE Thai_CI_AS NULL,
	[FAXNUM] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ETBOFRNME] [varchar](35) COLLATE Thai_CI_AS NULL,
	[ETBFACCDE] [varchar](2) COLLATE Thai_CI_AS NULL,
	[DTESTR] [datetime] NULL,
	[DTEFIN] [datetime] NULL,
	[UIDCTEAMN] [varchar](6) COLLATE Thai_CI_AS NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFEXP]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFEXP](
	[ExportTariff] [varchar](12) COLLATE Thai_CI_AS NULL,
	[TariffSeq] [varchar](5) COLLATE Thai_CI_AS NULL,
	[DutyCode] [varchar](1) COLLATE Thai_CI_AS NULL,
	[DutyRate] [float] NULL,
	[DutyRateS] [float] NULL,
	[SpecCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[Description] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[AnnounceNo] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AnnounceDate] [datetime] NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFFCU]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFFCU](
	[CurrencyCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[ExchangeRate] [float] NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFFMU]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFFMU](
	[FormulaNo] [varchar](10) COLLATE Thai_CI_AS NULL,
	[TaxNumber] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Parent] [varchar](40) COLLATE Thai_CI_AS NULL,
	[Desc1] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Desc2] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Desc3] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Desc4] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Desc5] [varchar](50) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[UID] [varchar](6) COLLATE Thai_CI_AS NULL,
	[RecDate] [datetime] NULL,
	[RecTime] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFGTY]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFGTY](
	[GoodsType] [float] NULL,
	[Description] [varchar](60) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[UID] [varchar](6) COLLATE Thai_CI_AS NULL,
	[RecDate] [datetime] NULL,
	[RecTime] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFICC]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFICC](
	[CountryCode] [varchar](2) COLLATE Thai_CI_AS NULL,
	[CountryName] [varchar](35) COLLATE Thai_CI_AS NULL,
	[CurrencyCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[WTOCountry] [varchar](1) COLLATE Thai_CI_AS NULL,
	[Continent] [varchar](2) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFICD]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFICD](
	[PortCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[PortName] [varchar](35) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFICU]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFICU](
	[CurrencyCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[ExchangeRate] [float] NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFIPC]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFIPC](
	[PortCode] [varchar](3) COLLATE Thai_CI_AS NOT NULL,
	[PortName] [varchar](35) COLLATE Thai_CI_AS NULL,
	[CountryCode] [varchar](3) COLLATE Thai_CI_AS NOT NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
 CONSTRAINT [pk_interport] PRIMARY KEY CLUSTERED 
(
	[PortCode] ASC,
	[CountryCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFIPN]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFIPN](
	[MICode] [varchar](2) COLLATE Thai_CI_AS NULL,
	[Message1] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Message2] [varchar](50) COLLATE Thai_CI_AS NULL,
	[Message3] [varchar](50) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFPMG]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFPMG](
	[TariffClass] [varchar](7) COLLATE Thai_CI_AS NULL,
	[TariffCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[PermissionGT] [varchar](2) COLLATE Thai_CI_AS NULL,
	[PermitIssue] [varchar](10) COLLATE Thai_CI_AS NULL,
	[GoodsDesc1] [varchar](50) COLLATE Thai_CI_AS NULL,
	[GoodsDesc2] [varchar](50) COLLATE Thai_CI_AS NULL,
	[GoodsDesc3] [varchar](50) COLLATE Thai_CI_AS NULL,
	[GoodsDesc4] [varchar](50) COLLATE Thai_CI_AS NULL,
	[AnnounceNo] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AnnounceDate] [datetime] NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[CreateID] [varchar](6) COLLATE Thai_CI_AS NULL,
	[CreateDate] [datetime] NULL,
	[CreateTime] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFPMS]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFPMS](
	[PermitID] [varchar](15) COLLATE Thai_CI_AS NULL,
	[PermitIssue] [varchar](10) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[TaxNumber] [varchar](10) COLLATE Thai_CI_AS NULL,
	[TariffClass] [varchar](7) COLLATE Thai_CI_AS NULL,
	[InvoiceNumber] [varchar](17) COLLATE Thai_CI_AS NULL,
	[InvoiceDate] [datetime] NULL,
	[PermitDesc1] [varchar](50) COLLATE Thai_CI_AS NULL,
	[PermitDesc2] [varchar](50) COLLATE Thai_CI_AS NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFTRC]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFTRC](
	[TariffClass] [varchar](12) COLLATE Thai_CI_AS NULL,
	[CompIndicator] [varchar](1) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL,
	[VatRate] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFTRS]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFTRS](
	[TariffClass] [varchar](12) COLLATE Thai_CI_AS NULL,
	[TariffStatCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[GoodsUnitCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[Desc1] [varchar](60) COLLATE Thai_CI_AS NULL,
	[Desc2] [varchar](60) COLLATE Thai_CI_AS NULL,
	[Desc3] [varchar](60) COLLATE Thai_CI_AS NULL,
	[Desc4] [varchar](60) COLLATE Thai_CI_AS NULL,
	[Desc5] [varchar](60) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[LastUpDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFUNT]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFUNT](
	[Code] [varchar](3) COLLATE Thai_CI_AS NULL,
	[TName] [varchar](35) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_RFWTO]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_RFWTO](
	[TRFCLS] [varchar](7) COLLATE Thai_CI_AS NULL,
	[TRFSEQ] [varchar](2) COLLATE Thai_CI_AS NULL,
	[DTYCDE] [varchar](1) COLLATE Thai_CI_AS NULL,
	[DTYYRTE] [float] NULL,
	[DTYSPE] [float] NULL,
	[SPECDE] [varchar](3) COLLATE Thai_CI_AS NULL,
	[ANONUM] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DTEANO] [datetime] NULL,
	[DTESTR] [datetime] NULL,
	[DTEFIN] [datetime] NULL,
	[DSCTRS1] [varchar](60) COLLATE Thai_CI_AS NULL,
	[DSCTRS2] [varchar](50) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_ServUnitType]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_ServUnitType](
	[UnitType] [varchar](10) COLLATE Thai_CI_AS NOT NULL,
	[UName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[EName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[IsCTNUnit] [int] NULL,
 CONSTRAINT [pk_servunit] PRIMARY KEY CLUSTERED 
(
	[UnitType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_TaxCode]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_TaxCode](
	[TaxNumber] [varchar](15) COLLATE Thai_CI_AS NULL,
	[TName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[Address1] [varchar](70) COLLATE Thai_CI_AS NULL,
	[Address2] [varchar](70) COLLATE Thai_CI_AS NULL,
	[Phone] [varchar](30) COLLATE Thai_CI_AS NULL,
	[FaxNumber] [varchar](30) COLLATE Thai_CI_AS NULL,
	[QuotaAmount] [float] NULL,
	[SkipCoSlip] [int] NULL,
	[UsedAmount] [float] NULL,
	[Status] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_User]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_User](
	[UserID] [varchar](10) COLLATE Thai_CI_AS NOT NULL,
	[UPassword] [varchar](70) COLLATE Thai_CI_AS NULL,
	[TName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[EName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[TPosition] [varchar](50) COLLATE Thai_CI_AS NULL,
	[LoginDate] [datetime] NULL,
	[LoginTime] [datetime] NULL,
	[LogoutDate] [datetime] NULL,
	[LogoutTime] [datetime] NULL,
	[UPosition] [smallint] NULL,
	[MaxRateDisc] [float] NULL,
	[MaxAdvance] [float] NULL,
	[JobAuthorize] [varchar](20) COLLATE Thai_CI_AS NULL,
	[EMail] [varchar](50) COLLATE Thai_CI_AS NULL,
	[MobilePhone] [varchar](10) COLLATE Thai_CI_AS NULL,
	[IsAlertByAgent] [tinyint] NULL,
	[IsAlertByEMail] [tinyint] NULL,
	[IsAlertBySMS] [tinyint] NULL,
	[UserUpline] [varchar](10) COLLATE Thai_CI_AS NULL,
	[GLAccountCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[UsedLanguage] [varchar](2) COLLATE Thai_CI_AS NULL,
	[DMailAccount] [varchar](50) COLLATE Thai_CI_AS NULL,
	[DMailPassword] [varchar](50) COLLATE Thai_CI_AS NULL,
	[JobPolicy] [varchar](255) COLLATE Thai_CI_AS NULL,
	[AlertPolicy] [varchar](255) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [pk_user] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_UserAuth]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_UserAuth](
	[UserID] [varchar](50) COLLATE Thai_CI_AS NULL,
	[AppID] [varchar](255) COLLATE Thai_CI_AS NULL,
	[MenuID] [varchar](255) COLLATE Thai_CI_AS NULL,
	[Author] [varchar](10) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_UserRole]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_UserRole](
	[RoleID] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[RoleDesc] [nvarchar](255) COLLATE Thai_CI_AS NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_UserRoleDetail]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_UserRoleDetail](
	[RoleID] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[UserID] [varchar](10) COLLATE Thai_CI_AS NOT NULL,
 CONSTRAINT [PK_RoleDetail] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_UserRolePolicy]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_UserRolePolicy](
	[RoleID] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[ModuleID] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[Author] [varchar](10) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [PK_RolePolicy] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[ModuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_Vender]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_Vender](
	[VenCode] [varchar](50) COLLATE Thai_CI_AS NOT NULL,
	[BranchCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[TaxNumber] [varchar](30) COLLATE Thai_CI_AS NULL,
	[Title] [varchar](15) COLLATE Thai_CI_AS NULL,
	[TName] [varchar](120) COLLATE Thai_CI_AS NULL,
	[English] [varchar](120) COLLATE Thai_CI_AS NULL,
	[TAddress1] [varchar](150) COLLATE Thai_CI_AS NULL,
	[TAddress2] [varchar](150) COLLATE Thai_CI_AS NULL,
	[EAddress1] [varchar](150) COLLATE Thai_CI_AS NULL,
	[EAddress2] [varchar](150) COLLATE Thai_CI_AS NULL,
	[Phone] [varchar](30) COLLATE Thai_CI_AS NULL,
	[FaxNumber] [varchar](30) COLLATE Thai_CI_AS NULL,
	[LoginName] [varchar](20) COLLATE Thai_CI_AS NULL,
	[LoginPassword] [varchar](20) COLLATE Thai_CI_AS NULL,
	[GLAccountCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ContactAcc] [varchar](150) COLLATE Thai_CI_AS NULL,
	[ContactSale] [varchar](150) COLLATE Thai_CI_AS NULL,
	[ContactSupport1] [varchar](150) COLLATE Thai_CI_AS NULL,
	[ContactSupport2] [varchar](150) COLLATE Thai_CI_AS NULL,
	[ContactSupport3] [varchar](150) COLLATE Thai_CI_AS NULL,
	[WEB_SITE] [varchar](255) COLLATE Thai_CI_AS NULL,
 CONSTRAINT [pk_vender] PRIMARY KEY CLUSTERED 
(
	[VenCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mas_Vessel]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_Vessel](
	[RegsNumber] [varchar](17) COLLATE Thai_CI_AS NULL,
	[TName] [varchar](35) COLLATE Thai_CI_AS NULL,
	[VesselType] [varchar](1) COLLATE Thai_CI_AS NULL,
	[OTNumber] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CompanyBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[NCountry] [varchar](2) COLLATE Thai_CI_AS NULL,
	[CargoType] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TICount] [varchar](3) COLLATE Thai_CI_AS NULL,
	[RiskRating] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TareTonnage] [varchar](6) COLLATE Thai_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NSM$]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NSM$](
	[SICode] [nvarchar](255) COLLATE Thai_CI_AS NULL,
	[NameThai] [nvarchar](255) COLLATE Thai_CI_AS NULL,
	[NameEng] [nvarchar](255) COLLATE Thai_CI_AS NULL,
	[SICode1] [nvarchar](255) COLLATE Thai_CI_AS NULL,
	[StdPrice] [float] NULL,
	[UnitCharge] [nvarchar](255) COLLATE Thai_CI_AS NULL,
	[CurrencyCode] [nvarchar](255) COLLATE Thai_CI_AS NULL,
	[DefaultVender] [nvarchar](255) COLLATE Thai_CI_AS NULL,
	[ProcessDesc] [nvarchar](255) COLLATE Thai_CI_AS NULL,
	[GLAccountCode Sales] [float] NULL,
	[GLAccountCode Cost] [float] NULL,
	[IsTaxCharge] [float] NULL,
	[Is50Tavi] [float] NULL,
	[Rate50Tavi] [float] NULL,
	[IsCredit] [float] NULL,
	[IsExpense] [float] NULL,
	[IsShowPrice] [float] NULL,
	[IsHaveSlip] [float] NULL,
	[IsPay50TaviTo] [float] NULL,
	[IsLtdAdv50Tavi] [float] NULL,
	[IsUsedCoSlip] [float] NULL,
	[F22] [nvarchar](255) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tracking1]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tracking1](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[JRevise] [tinyint] NULL,
	[ConfirmDate] [datetime] NULL,
	[CPolicyCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[CustContactName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[QNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Revise] [smallint] NULL,
	[ManagerCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CSCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Description] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[TRemark] [varchar](250) COLLATE Thai_CI_AS NULL,
	[JobStatus] [tinyint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[InvNo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[InvTotal] [float] NULL,
	[InvProduct] [varchar](100) COLLATE Thai_CI_AS NULL,
	[InvCountry] [varchar](2) COLLATE Thai_CI_AS NULL,
	[InvFCountry] [varchar](2) COLLATE Thai_CI_AS NULL,
	[InvInterPort] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvProductQty] [float] NULL,
	[InvProductUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvCurUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvCurRate] [float] NULL,
	[ImExDate] [datetime] NULL,
	[BLNo] [varchar](40) COLLATE Thai_CI_AS NULL,
	[BookingNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ClearPort] [varchar](5) COLLATE Thai_CI_AS NULL,
	[ClearPortNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ClearDate] [datetime] NULL,
	[LoadDate] [datetime] NULL,
	[ForwarderCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AgentCode] [varchar](5) COLLATE Thai_CI_AS NULL,
	[VesselName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ETDDate] [datetime] NULL,
	[ETADate] [datetime] NULL,
	[ETTime] [datetime] NULL,
	[FNetPrice] [varchar](50) COLLATE Thai_CI_AS NULL,
	[BNetPrice] [float] NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelProveDate] [datetime] NULL,
	[CancelProveTime] [datetime] NULL,
	[CloseJobDate] [datetime] NULL,
	[CloseJobTime] [datetime] NULL,
	[CloseJobBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DeclareType] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DeclareNumber] [varchar](20) COLLATE Thai_CI_AS NULL,
	[DeclareStatus] [varchar](1) COLLATE Thai_CI_AS NULL,
	[TyAuthorSp] [varchar](2) COLLATE Thai_CI_AS NULL,
	[Ty19BIS] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TyClearTax] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TyClearTaxReson] [varchar](50) COLLATE Thai_CI_AS NULL,
	[EstDeliverDate] [datetime] NULL,
	[EstDeliverTime] [datetime] NULL,
	[TotalContainer] [varchar](50) COLLATE Thai_CI_AS NULL,
	[DutyDate] [datetime] NULL,
	[DutyAmount] [float] NULL,
	[DutyCustPayOther] [varchar](30) COLLATE Thai_CI_AS NULL,
	[DutyCustPayChqAmt] [float] NULL,
	[DutyCustPayBankAmt] [float] NULL,
	[DutyCustPayEPAYAmt] [float] NULL,
	[DutyCustPayCardAmt] [float] NULL,
	[DutyCustPayCashAmt] [float] NULL,
	[DutyCustPayOtherAmt] [float] NULL,
	[DutyLtdPayOther] [varchar](30) COLLATE Thai_CI_AS NULL,
	[DutyLtdPayChqAmt] [float] NULL,
	[DutyLtdPayEPAYAmt] [float] NULL,
	[DutyLtdPayCashAmt] [float] NULL,
	[DutyLtdPayOtherAmt] [float] NULL,
	[ConfirmChqDate] [datetime] NULL,
	[ShippingEmp] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ShippingCmd] [varchar](70) COLLATE Thai_CI_AS NULL,
	[TotalGW] [float] NULL,
	[GWUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[TSRequest] [tinyint] NULL,
	[ShipmentType] [tinyint] NULL,
	[ReadyToClearDate] [datetime] NULL,
	[Commission] [int] NULL,
	[CommPayTo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ProjectName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[MVesselName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TotalNW] [float] NULL,
	[Measurement] [varchar](20) COLLATE Thai_CI_AS NULL,
	[CustRefNO] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TotalQty] [varchar](50) COLLATE Thai_CI_AS NULL,
	[HAWB] [varchar](50) COLLATE Thai_CI_AS NULL,
	[MAWB] [varchar](50) COLLATE Thai_CI_AS NULL,
	[consigneecode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[privilegests] [varchar](255) COLLATE Thai_CI_AS NULL,
	[CustID] [varchar](20) COLLATE Thai_CI_AS NULL,
	[Title] [varchar](15) COLLATE Thai_CI_AS NULL,
	[NameThai] [varchar](255) COLLATE Thai_CI_AS NULL,
	[NameEng] [varchar](255) COLLATE Thai_CI_AS NULL,
	[AreaName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[CSName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[SalesCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ConsigneeName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ForwarderName] [varchar](120) COLLATE Thai_CI_AS NULL,
	[AgentName] [varchar](120) COLLATE Thai_CI_AS NULL,
	[TAddress1] [varchar](80) COLLATE Thai_CI_AS NULL,
	[TAddress2] [varchar](80) COLLATE Thai_CI_AS NULL,
	[EAddress1] [varchar](80) COLLATE Thai_CI_AS NULL,
	[EAddress2] [varchar](80) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tracking2]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tracking2](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[JRevise] [tinyint] NULL,
	[ConfirmDate] [datetime] NULL,
	[CPolicyCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[CustContactName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[QNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Revise] [smallint] NULL,
	[ManagerCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CSCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Description] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[TRemark] [varchar](250) COLLATE Thai_CI_AS NULL,
	[JobStatus] [tinyint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[InvNo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[InvTotal] [float] NULL,
	[InvProduct] [varchar](100) COLLATE Thai_CI_AS NULL,
	[InvCountry] [varchar](2) COLLATE Thai_CI_AS NULL,
	[InvFCountry] [varchar](2) COLLATE Thai_CI_AS NULL,
	[InvInterPort] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvProductQty] [float] NULL,
	[InvProductUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvCurUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvCurRate] [float] NULL,
	[ImExDate] [datetime] NULL,
	[BLNo] [varchar](40) COLLATE Thai_CI_AS NULL,
	[BookingNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ClearPort] [varchar](5) COLLATE Thai_CI_AS NULL,
	[ClearPortNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ClearDate] [datetime] NULL,
	[LoadDate] [datetime] NULL,
	[ForwarderCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AgentCode] [varchar](5) COLLATE Thai_CI_AS NULL,
	[VesselName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ETDDate] [datetime] NULL,
	[ETADate] [datetime] NULL,
	[ETTime] [datetime] NULL,
	[FNetPrice] [varchar](50) COLLATE Thai_CI_AS NULL,
	[BNetPrice] [float] NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelProveDate] [datetime] NULL,
	[CancelProveTime] [datetime] NULL,
	[CloseJobDate] [datetime] NULL,
	[CloseJobTime] [datetime] NULL,
	[CloseJobBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DeclareType] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DeclareNumber] [varchar](20) COLLATE Thai_CI_AS NULL,
	[DeclareStatus] [varchar](1) COLLATE Thai_CI_AS NULL,
	[TyAuthorSp] [varchar](2) COLLATE Thai_CI_AS NULL,
	[Ty19BIS] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TyClearTax] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TyClearTaxReson] [varchar](50) COLLATE Thai_CI_AS NULL,
	[EstDeliverDate] [datetime] NULL,
	[EstDeliverTime] [datetime] NULL,
	[TotalContainer] [varchar](50) COLLATE Thai_CI_AS NULL,
	[DutyDate] [datetime] NULL,
	[DutyAmount] [float] NULL,
	[DutyCustPayOther] [varchar](30) COLLATE Thai_CI_AS NULL,
	[DutyCustPayChqAmt] [float] NULL,
	[DutyCustPayBankAmt] [float] NULL,
	[DutyCustPayEPAYAmt] [float] NULL,
	[DutyCustPayCardAmt] [float] NULL,
	[DutyCustPayCashAmt] [float] NULL,
	[DutyCustPayOtherAmt] [float] NULL,
	[DutyLtdPayOther] [varchar](30) COLLATE Thai_CI_AS NULL,
	[DutyLtdPayChqAmt] [float] NULL,
	[DutyLtdPayEPAYAmt] [float] NULL,
	[DutyLtdPayCashAmt] [float] NULL,
	[DutyLtdPayOtherAmt] [float] NULL,
	[ConfirmChqDate] [datetime] NULL,
	[ShippingEmp] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ShippingCmd] [varchar](70) COLLATE Thai_CI_AS NULL,
	[TotalGW] [float] NULL,
	[GWUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[TSRequest] [tinyint] NULL,
	[ShipmentType] [tinyint] NULL,
	[ReadyToClearDate] [datetime] NULL,
	[Commission] [int] NULL,
	[CommPayTo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ProjectName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[MVesselName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TotalNW] [float] NULL,
	[Measurement] [varchar](20) COLLATE Thai_CI_AS NULL,
	[CustRefNO] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TotalQty] [varchar](50) COLLATE Thai_CI_AS NULL,
	[HAWB] [varchar](50) COLLATE Thai_CI_AS NULL,
	[MAWB] [varchar](50) COLLATE Thai_CI_AS NULL,
	[consigneecode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[privilegests] [varchar](255) COLLATE Thai_CI_AS NULL,
	[CustID] [varchar](20) COLLATE Thai_CI_AS NULL,
	[Title] [varchar](15) COLLATE Thai_CI_AS NULL,
	[NameThai] [varchar](255) COLLATE Thai_CI_AS NULL,
	[NameEng] [varchar](255) COLLATE Thai_CI_AS NULL,
	[AreaName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[CSName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[SalesCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ConsigneeName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ForwarderName] [varchar](120) COLLATE Thai_CI_AS NULL,
	[AgentName] [varchar](120) COLLATE Thai_CI_AS NULL,
	[TAddress1] [varchar](80) COLLATE Thai_CI_AS NULL,
	[TAddress2] [varchar](80) COLLATE Thai_CI_AS NULL,
	[EAddress1] [varchar](80) COLLATE Thai_CI_AS NULL,
	[EAddress2] [varchar](80) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tracking3]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tracking3](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[JRevise] [tinyint] NULL,
	[ConfirmDate] [datetime] NULL,
	[CPolicyCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[CustContactName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[QNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Revise] [smallint] NULL,
	[ManagerCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CSCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Description] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[TRemark] [varchar](250) COLLATE Thai_CI_AS NULL,
	[JobStatus] [tinyint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[InvNo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[InvTotal] [float] NULL,
	[InvProduct] [varchar](100) COLLATE Thai_CI_AS NULL,
	[InvCountry] [varchar](2) COLLATE Thai_CI_AS NULL,
	[InvFCountry] [varchar](2) COLLATE Thai_CI_AS NULL,
	[InvInterPort] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvProductQty] [float] NULL,
	[InvProductUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvCurUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvCurRate] [float] NULL,
	[ImExDate] [datetime] NULL,
	[BLNo] [varchar](40) COLLATE Thai_CI_AS NULL,
	[BookingNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ClearPort] [varchar](5) COLLATE Thai_CI_AS NULL,
	[ClearPortNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ClearDate] [datetime] NULL,
	[LoadDate] [datetime] NULL,
	[ForwarderCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AgentCode] [varchar](5) COLLATE Thai_CI_AS NULL,
	[VesselName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ETDDate] [datetime] NULL,
	[ETADate] [datetime] NULL,
	[ETTime] [datetime] NULL,
	[FNetPrice] [varchar](50) COLLATE Thai_CI_AS NULL,
	[BNetPrice] [float] NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelProveDate] [datetime] NULL,
	[CancelProveTime] [datetime] NULL,
	[CloseJobDate] [datetime] NULL,
	[CloseJobTime] [datetime] NULL,
	[CloseJobBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DeclareType] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DeclareNumber] [varchar](20) COLLATE Thai_CI_AS NULL,
	[DeclareStatus] [varchar](1) COLLATE Thai_CI_AS NULL,
	[TyAuthorSp] [varchar](2) COLLATE Thai_CI_AS NULL,
	[Ty19BIS] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TyClearTax] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TyClearTaxReson] [varchar](50) COLLATE Thai_CI_AS NULL,
	[EstDeliverDate] [datetime] NULL,
	[EstDeliverTime] [datetime] NULL,
	[TotalContainer] [varchar](50) COLLATE Thai_CI_AS NULL,
	[DutyDate] [datetime] NULL,
	[DutyAmount] [float] NULL,
	[DutyCustPayOther] [varchar](30) COLLATE Thai_CI_AS NULL,
	[DutyCustPayChqAmt] [float] NULL,
	[DutyCustPayBankAmt] [float] NULL,
	[DutyCustPayEPAYAmt] [float] NULL,
	[DutyCustPayCardAmt] [float] NULL,
	[DutyCustPayCashAmt] [float] NULL,
	[DutyCustPayOtherAmt] [float] NULL,
	[DutyLtdPayOther] [varchar](30) COLLATE Thai_CI_AS NULL,
	[DutyLtdPayChqAmt] [float] NULL,
	[DutyLtdPayEPAYAmt] [float] NULL,
	[DutyLtdPayCashAmt] [float] NULL,
	[DutyLtdPayOtherAmt] [float] NULL,
	[ConfirmChqDate] [datetime] NULL,
	[ShippingEmp] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ShippingCmd] [varchar](70) COLLATE Thai_CI_AS NULL,
	[TotalGW] [float] NULL,
	[GWUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[TSRequest] [tinyint] NULL,
	[ShipmentType] [tinyint] NULL,
	[ReadyToClearDate] [datetime] NULL,
	[Commission] [int] NULL,
	[CommPayTo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ProjectName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[MVesselName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TotalNW] [float] NULL,
	[Measurement] [varchar](20) COLLATE Thai_CI_AS NULL,
	[CustRefNO] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TotalQty] [varchar](50) COLLATE Thai_CI_AS NULL,
	[HAWB] [varchar](50) COLLATE Thai_CI_AS NULL,
	[MAWB] [varchar](50) COLLATE Thai_CI_AS NULL,
	[consigneecode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[privilegests] [varchar](255) COLLATE Thai_CI_AS NULL,
	[CustID] [varchar](20) COLLATE Thai_CI_AS NULL,
	[Title] [varchar](15) COLLATE Thai_CI_AS NULL,
	[NameThai] [varchar](255) COLLATE Thai_CI_AS NULL,
	[NameEng] [varchar](255) COLLATE Thai_CI_AS NULL,
	[AreaName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[CSName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[SalesCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ConsigneeName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ForwarderName] [varchar](120) COLLATE Thai_CI_AS NULL,
	[AgentName] [varchar](120) COLLATE Thai_CI_AS NULL,
	[TAddress1] [varchar](80) COLLATE Thai_CI_AS NULL,
	[TAddress2] [varchar](80) COLLATE Thai_CI_AS NULL,
	[EAddress1] [varchar](80) COLLATE Thai_CI_AS NULL,
	[EAddress2] [varchar](80) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tracking4]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tracking4](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[JRevise] [tinyint] NULL,
	[ConfirmDate] [datetime] NULL,
	[CPolicyCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[CustContactName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[QNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Revise] [smallint] NULL,
	[ManagerCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CSCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Description] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[TRemark] [varchar](250) COLLATE Thai_CI_AS NULL,
	[JobStatus] [tinyint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[InvNo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[InvTotal] [float] NULL,
	[InvProduct] [varchar](100) COLLATE Thai_CI_AS NULL,
	[InvCountry] [varchar](2) COLLATE Thai_CI_AS NULL,
	[InvFCountry] [varchar](2) COLLATE Thai_CI_AS NULL,
	[InvInterPort] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvProductQty] [float] NULL,
	[InvProductUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvCurUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvCurRate] [float] NULL,
	[ImExDate] [datetime] NULL,
	[BLNo] [varchar](40) COLLATE Thai_CI_AS NULL,
	[BookingNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ClearPort] [varchar](5) COLLATE Thai_CI_AS NULL,
	[ClearPortNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ClearDate] [datetime] NULL,
	[LoadDate] [datetime] NULL,
	[ForwarderCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AgentCode] [varchar](5) COLLATE Thai_CI_AS NULL,
	[VesselName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ETDDate] [datetime] NULL,
	[ETADate] [datetime] NULL,
	[ETTime] [datetime] NULL,
	[FNetPrice] [varchar](50) COLLATE Thai_CI_AS NULL,
	[BNetPrice] [float] NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelProveDate] [datetime] NULL,
	[CancelProveTime] [datetime] NULL,
	[CloseJobDate] [datetime] NULL,
	[CloseJobTime] [datetime] NULL,
	[CloseJobBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DeclareType] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DeclareNumber] [varchar](20) COLLATE Thai_CI_AS NULL,
	[DeclareStatus] [varchar](1) COLLATE Thai_CI_AS NULL,
	[TyAuthorSp] [varchar](2) COLLATE Thai_CI_AS NULL,
	[Ty19BIS] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TyClearTax] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TyClearTaxReson] [varchar](50) COLLATE Thai_CI_AS NULL,
	[EstDeliverDate] [datetime] NULL,
	[EstDeliverTime] [datetime] NULL,
	[TotalContainer] [varchar](50) COLLATE Thai_CI_AS NULL,
	[DutyDate] [datetime] NULL,
	[DutyAmount] [float] NULL,
	[DutyCustPayOther] [varchar](30) COLLATE Thai_CI_AS NULL,
	[DutyCustPayChqAmt] [float] NULL,
	[DutyCustPayBankAmt] [float] NULL,
	[DutyCustPayEPAYAmt] [float] NULL,
	[DutyCustPayCardAmt] [float] NULL,
	[DutyCustPayCashAmt] [float] NULL,
	[DutyCustPayOtherAmt] [float] NULL,
	[DutyLtdPayOther] [varchar](30) COLLATE Thai_CI_AS NULL,
	[DutyLtdPayChqAmt] [float] NULL,
	[DutyLtdPayEPAYAmt] [float] NULL,
	[DutyLtdPayCashAmt] [float] NULL,
	[DutyLtdPayOtherAmt] [float] NULL,
	[ConfirmChqDate] [datetime] NULL,
	[ShippingEmp] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ShippingCmd] [varchar](70) COLLATE Thai_CI_AS NULL,
	[TotalGW] [float] NULL,
	[GWUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[TSRequest] [tinyint] NULL,
	[ShipmentType] [tinyint] NULL,
	[ReadyToClearDate] [datetime] NULL,
	[Commission] [int] NULL,
	[CommPayTo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ProjectName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[MVesselName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TotalNW] [float] NULL,
	[Measurement] [varchar](20) COLLATE Thai_CI_AS NULL,
	[CustRefNO] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TotalQty] [varchar](50) COLLATE Thai_CI_AS NULL,
	[HAWB] [varchar](50) COLLATE Thai_CI_AS NULL,
	[MAWB] [varchar](50) COLLATE Thai_CI_AS NULL,
	[consigneecode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[privilegests] [varchar](255) COLLATE Thai_CI_AS NULL,
	[CustID] [varchar](20) COLLATE Thai_CI_AS NULL,
	[Title] [varchar](15) COLLATE Thai_CI_AS NULL,
	[NameThai] [varchar](255) COLLATE Thai_CI_AS NULL,
	[NameEng] [varchar](255) COLLATE Thai_CI_AS NULL,
	[AreaName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[CSName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[SalesCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ConsigneeName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ForwarderName] [varchar](120) COLLATE Thai_CI_AS NULL,
	[AgentName] [varchar](120) COLLATE Thai_CI_AS NULL,
	[TAddress1] [varchar](80) COLLATE Thai_CI_AS NULL,
	[TAddress2] [varchar](80) COLLATE Thai_CI_AS NULL,
	[EAddress1] [varchar](80) COLLATE Thai_CI_AS NULL,
	[EAddress2] [varchar](80) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tracking5]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tracking5](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[JRevise] [tinyint] NULL,
	[ConfirmDate] [datetime] NULL,
	[CPolicyCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[CustContactName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[QNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Revise] [smallint] NULL,
	[ManagerCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CSCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Description] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[TRemark] [varchar](250) COLLATE Thai_CI_AS NULL,
	[JobStatus] [tinyint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[InvNo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[InvTotal] [float] NULL,
	[InvProduct] [varchar](100) COLLATE Thai_CI_AS NULL,
	[InvCountry] [varchar](2) COLLATE Thai_CI_AS NULL,
	[InvFCountry] [varchar](2) COLLATE Thai_CI_AS NULL,
	[InvInterPort] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvProductQty] [float] NULL,
	[InvProductUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvCurUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvCurRate] [float] NULL,
	[ImExDate] [datetime] NULL,
	[BLNo] [varchar](40) COLLATE Thai_CI_AS NULL,
	[BookingNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ClearPort] [varchar](5) COLLATE Thai_CI_AS NULL,
	[ClearPortNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ClearDate] [datetime] NULL,
	[LoadDate] [datetime] NULL,
	[ForwarderCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AgentCode] [varchar](5) COLLATE Thai_CI_AS NULL,
	[VesselName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ETDDate] [datetime] NULL,
	[ETADate] [datetime] NULL,
	[ETTime] [datetime] NULL,
	[FNetPrice] [varchar](50) COLLATE Thai_CI_AS NULL,
	[BNetPrice] [float] NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelProveDate] [datetime] NULL,
	[CancelProveTime] [datetime] NULL,
	[CloseJobDate] [datetime] NULL,
	[CloseJobTime] [datetime] NULL,
	[CloseJobBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DeclareType] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DeclareNumber] [varchar](20) COLLATE Thai_CI_AS NULL,
	[DeclareStatus] [varchar](1) COLLATE Thai_CI_AS NULL,
	[TyAuthorSp] [varchar](2) COLLATE Thai_CI_AS NULL,
	[Ty19BIS] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TyClearTax] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TyClearTaxReson] [varchar](50) COLLATE Thai_CI_AS NULL,
	[EstDeliverDate] [datetime] NULL,
	[EstDeliverTime] [datetime] NULL,
	[TotalContainer] [varchar](50) COLLATE Thai_CI_AS NULL,
	[DutyDate] [datetime] NULL,
	[DutyAmount] [float] NULL,
	[DutyCustPayOther] [varchar](30) COLLATE Thai_CI_AS NULL,
	[DutyCustPayChqAmt] [float] NULL,
	[DutyCustPayBankAmt] [float] NULL,
	[DutyCustPayEPAYAmt] [float] NULL,
	[DutyCustPayCardAmt] [float] NULL,
	[DutyCustPayCashAmt] [float] NULL,
	[DutyCustPayOtherAmt] [float] NULL,
	[DutyLtdPayOther] [varchar](30) COLLATE Thai_CI_AS NULL,
	[DutyLtdPayChqAmt] [float] NULL,
	[DutyLtdPayEPAYAmt] [float] NULL,
	[DutyLtdPayCashAmt] [float] NULL,
	[DutyLtdPayOtherAmt] [float] NULL,
	[ConfirmChqDate] [datetime] NULL,
	[ShippingEmp] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ShippingCmd] [varchar](70) COLLATE Thai_CI_AS NULL,
	[TotalGW] [float] NULL,
	[GWUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[TSRequest] [tinyint] NULL,
	[ShipmentType] [tinyint] NULL,
	[ReadyToClearDate] [datetime] NULL,
	[Commission] [int] NULL,
	[CommPayTo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ProjectName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[MVesselName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TotalNW] [float] NULL,
	[Measurement] [varchar](20) COLLATE Thai_CI_AS NULL,
	[CustRefNO] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TotalQty] [varchar](50) COLLATE Thai_CI_AS NULL,
	[HAWB] [varchar](50) COLLATE Thai_CI_AS NULL,
	[MAWB] [varchar](50) COLLATE Thai_CI_AS NULL,
	[consigneecode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[privilegests] [varchar](255) COLLATE Thai_CI_AS NULL,
	[CustID] [varchar](20) COLLATE Thai_CI_AS NULL,
	[Title] [varchar](15) COLLATE Thai_CI_AS NULL,
	[NameThai] [varchar](255) COLLATE Thai_CI_AS NULL,
	[NameEng] [varchar](255) COLLATE Thai_CI_AS NULL,
	[AreaName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[CSName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[SalesCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ConsigneeName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ForwarderName] [varchar](120) COLLATE Thai_CI_AS NULL,
	[AgentName] [varchar](120) COLLATE Thai_CI_AS NULL,
	[TAddress1] [varchar](80) COLLATE Thai_CI_AS NULL,
	[TAddress2] [varchar](80) COLLATE Thai_CI_AS NULL,
	[EAddress1] [varchar](80) COLLATE Thai_CI_AS NULL,
	[EAddress2] [varchar](80) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tracking6]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tracking6](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[JRevise] [tinyint] NULL,
	[ConfirmDate] [datetime] NULL,
	[CPolicyCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[CustContactName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[QNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Revise] [smallint] NULL,
	[ManagerCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CSCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Description] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[TRemark] [varchar](250) COLLATE Thai_CI_AS NULL,
	[JobStatus] [tinyint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[InvNo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[InvTotal] [float] NULL,
	[InvProduct] [varchar](100) COLLATE Thai_CI_AS NULL,
	[InvCountry] [varchar](2) COLLATE Thai_CI_AS NULL,
	[InvFCountry] [varchar](2) COLLATE Thai_CI_AS NULL,
	[InvInterPort] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvProductQty] [float] NULL,
	[InvProductUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvCurUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvCurRate] [float] NULL,
	[ImExDate] [datetime] NULL,
	[BLNo] [varchar](40) COLLATE Thai_CI_AS NULL,
	[BookingNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ClearPort] [varchar](5) COLLATE Thai_CI_AS NULL,
	[ClearPortNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ClearDate] [datetime] NULL,
	[LoadDate] [datetime] NULL,
	[ForwarderCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AgentCode] [varchar](5) COLLATE Thai_CI_AS NULL,
	[VesselName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ETDDate] [datetime] NULL,
	[ETADate] [datetime] NULL,
	[ETTime] [datetime] NULL,
	[FNetPrice] [varchar](50) COLLATE Thai_CI_AS NULL,
	[BNetPrice] [float] NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelProveDate] [datetime] NULL,
	[CancelProveTime] [datetime] NULL,
	[CloseJobDate] [datetime] NULL,
	[CloseJobTime] [datetime] NULL,
	[CloseJobBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DeclareType] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DeclareNumber] [varchar](20) COLLATE Thai_CI_AS NULL,
	[DeclareStatus] [varchar](1) COLLATE Thai_CI_AS NULL,
	[TyAuthorSp] [varchar](2) COLLATE Thai_CI_AS NULL,
	[Ty19BIS] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TyClearTax] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TyClearTaxReson] [varchar](50) COLLATE Thai_CI_AS NULL,
	[EstDeliverDate] [datetime] NULL,
	[EstDeliverTime] [datetime] NULL,
	[TotalContainer] [varchar](50) COLLATE Thai_CI_AS NULL,
	[DutyDate] [datetime] NULL,
	[DutyAmount] [float] NULL,
	[DutyCustPayOther] [varchar](30) COLLATE Thai_CI_AS NULL,
	[DutyCustPayChqAmt] [float] NULL,
	[DutyCustPayBankAmt] [float] NULL,
	[DutyCustPayEPAYAmt] [float] NULL,
	[DutyCustPayCardAmt] [float] NULL,
	[DutyCustPayCashAmt] [float] NULL,
	[DutyCustPayOtherAmt] [float] NULL,
	[DutyLtdPayOther] [varchar](30) COLLATE Thai_CI_AS NULL,
	[DutyLtdPayChqAmt] [float] NULL,
	[DutyLtdPayEPAYAmt] [float] NULL,
	[DutyLtdPayCashAmt] [float] NULL,
	[DutyLtdPayOtherAmt] [float] NULL,
	[ConfirmChqDate] [datetime] NULL,
	[ShippingEmp] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ShippingCmd] [varchar](70) COLLATE Thai_CI_AS NULL,
	[TotalGW] [float] NULL,
	[GWUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[TSRequest] [tinyint] NULL,
	[ShipmentType] [tinyint] NULL,
	[ReadyToClearDate] [datetime] NULL,
	[Commission] [int] NULL,
	[CommPayTo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ProjectName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[MVesselName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TotalNW] [float] NULL,
	[Measurement] [varchar](20) COLLATE Thai_CI_AS NULL,
	[CustRefNO] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TotalQty] [varchar](50) COLLATE Thai_CI_AS NULL,
	[HAWB] [varchar](50) COLLATE Thai_CI_AS NULL,
	[MAWB] [varchar](50) COLLATE Thai_CI_AS NULL,
	[consigneecode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[privilegests] [varchar](255) COLLATE Thai_CI_AS NULL,
	[CustID] [varchar](20) COLLATE Thai_CI_AS NULL,
	[Title] [varchar](15) COLLATE Thai_CI_AS NULL,
	[NameThai] [varchar](255) COLLATE Thai_CI_AS NULL,
	[NameEng] [varchar](255) COLLATE Thai_CI_AS NULL,
	[AreaName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[CSName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[SalesCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ConsigneeName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ForwarderName] [varchar](120) COLLATE Thai_CI_AS NULL,
	[AgentName] [varchar](120) COLLATE Thai_CI_AS NULL,
	[TAddress1] [varchar](80) COLLATE Thai_CI_AS NULL,
	[TAddress2] [varchar](80) COLLATE Thai_CI_AS NULL,
	[EAddress1] [varchar](80) COLLATE Thai_CI_AS NULL,
	[EAddress2] [varchar](80) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tracking7]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tracking7](
	[BranchCode] [varchar](3) COLLATE Thai_CI_AS NULL,
	[JNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[JRevise] [tinyint] NULL,
	[ConfirmDate] [datetime] NULL,
	[CPolicyCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) COLLATE Thai_CI_AS NULL,
	[CustBranch] [varchar](4) COLLATE Thai_CI_AS NULL,
	[CustContactName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[QNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[Revise] [smallint] NULL,
	[ManagerCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CSCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[Description] [varchar](4000) COLLATE Thai_CI_AS NULL,
	[TRemark] [varchar](250) COLLATE Thai_CI_AS NULL,
	[JobStatus] [tinyint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[InvNo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[InvTotal] [float] NULL,
	[InvProduct] [varchar](100) COLLATE Thai_CI_AS NULL,
	[InvCountry] [varchar](2) COLLATE Thai_CI_AS NULL,
	[InvFCountry] [varchar](2) COLLATE Thai_CI_AS NULL,
	[InvInterPort] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvProductQty] [float] NULL,
	[InvProductUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvCurUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[InvCurRate] [float] NULL,
	[ImExDate] [datetime] NULL,
	[BLNo] [varchar](40) COLLATE Thai_CI_AS NULL,
	[BookingNo] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ClearPort] [varchar](5) COLLATE Thai_CI_AS NULL,
	[ClearPortNo] [varchar](15) COLLATE Thai_CI_AS NULL,
	[ClearDate] [datetime] NULL,
	[LoadDate] [datetime] NULL,
	[ForwarderCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AgentCode] [varchar](5) COLLATE Thai_CI_AS NULL,
	[VesselName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[ETDDate] [datetime] NULL,
	[ETADate] [datetime] NULL,
	[ETTime] [datetime] NULL,
	[FNetPrice] [varchar](50) COLLATE Thai_CI_AS NULL,
	[BNetPrice] [float] NULL,
	[CancelReson] [varchar](100) COLLATE Thai_CI_AS NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CancelProve] [varchar](10) COLLATE Thai_CI_AS NULL,
	[CancelProveDate] [datetime] NULL,
	[CancelProveTime] [datetime] NULL,
	[CloseJobDate] [datetime] NULL,
	[CloseJobTime] [datetime] NULL,
	[CloseJobBy] [varchar](10) COLLATE Thai_CI_AS NULL,
	[DeclareType] [varchar](3) COLLATE Thai_CI_AS NULL,
	[DeclareNumber] [varchar](20) COLLATE Thai_CI_AS NULL,
	[DeclareStatus] [varchar](1) COLLATE Thai_CI_AS NULL,
	[TyAuthorSp] [varchar](2) COLLATE Thai_CI_AS NULL,
	[Ty19BIS] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TyClearTax] [varchar](2) COLLATE Thai_CI_AS NULL,
	[TyClearTaxReson] [varchar](50) COLLATE Thai_CI_AS NULL,
	[EstDeliverDate] [datetime] NULL,
	[EstDeliverTime] [datetime] NULL,
	[TotalContainer] [varchar](50) COLLATE Thai_CI_AS NULL,
	[DutyDate] [datetime] NULL,
	[DutyAmount] [float] NULL,
	[DutyCustPayOther] [varchar](30) COLLATE Thai_CI_AS NULL,
	[DutyCustPayChqAmt] [float] NULL,
	[DutyCustPayBankAmt] [float] NULL,
	[DutyCustPayEPAYAmt] [float] NULL,
	[DutyCustPayCardAmt] [float] NULL,
	[DutyCustPayCashAmt] [float] NULL,
	[DutyCustPayOtherAmt] [float] NULL,
	[DutyLtdPayOther] [varchar](30) COLLATE Thai_CI_AS NULL,
	[DutyLtdPayChqAmt] [float] NULL,
	[DutyLtdPayEPAYAmt] [float] NULL,
	[DutyLtdPayCashAmt] [float] NULL,
	[DutyLtdPayOtherAmt] [float] NULL,
	[ConfirmChqDate] [datetime] NULL,
	[ShippingEmp] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ShippingCmd] [varchar](70) COLLATE Thai_CI_AS NULL,
	[TotalGW] [float] NULL,
	[GWUnit] [varchar](3) COLLATE Thai_CI_AS NULL,
	[TSRequest] [tinyint] NULL,
	[ShipmentType] [tinyint] NULL,
	[ReadyToClearDate] [datetime] NULL,
	[Commission] [int] NULL,
	[CommPayTo] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ProjectName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[MVesselName] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TotalNW] [float] NULL,
	[Measurement] [varchar](20) COLLATE Thai_CI_AS NULL,
	[CustRefNO] [varchar](50) COLLATE Thai_CI_AS NULL,
	[TotalQty] [varchar](50) COLLATE Thai_CI_AS NULL,
	[HAWB] [varchar](50) COLLATE Thai_CI_AS NULL,
	[MAWB] [varchar](50) COLLATE Thai_CI_AS NULL,
	[consigneecode] [varchar](50) COLLATE Thai_CI_AS NULL,
	[privilegests] [varchar](255) COLLATE Thai_CI_AS NULL,
	[CustID] [varchar](20) COLLATE Thai_CI_AS NULL,
	[Title] [varchar](15) COLLATE Thai_CI_AS NULL,
	[NameThai] [varchar](255) COLLATE Thai_CI_AS NULL,
	[NameEng] [varchar](255) COLLATE Thai_CI_AS NULL,
	[AreaName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[CSName] [varchar](70) COLLATE Thai_CI_AS NULL,
	[SalesCode] [varchar](10) COLLATE Thai_CI_AS NULL,
	[ConsigneeName] [varchar](100) COLLATE Thai_CI_AS NULL,
	[ForwarderName] [varchar](120) COLLATE Thai_CI_AS NULL,
	[AgentName] [varchar](120) COLLATE Thai_CI_AS NULL,
	[TAddress1] [varchar](80) COLLATE Thai_CI_AS NULL,
	[TAddress2] [varchar](80) COLLATE Thai_CI_AS NULL,
	[EAddress1] [varchar](80) COLLATE Thai_CI_AS NULL,
	[EAddress2] [varchar](80) COLLATE Thai_CI_AS NULL,
	[SupportBy] [varchar](10) COLLATE Thai_CI_AS NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tracking8]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tracking8](
	[JobType] [tinyint] NULL,
	[ShippingEmp] [varchar](10) COLLATE Thai_CI_AS NULL,
	[AvgPoint] [int] NULL,
	[JobNo] [int] NULL,
	[TotalDay] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[qJob_BillDetail]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qJob_BillDetail]
AS
SELECT        dbo.Job_BillingHeader.BranchCode, dbo.Job_BillingHeader.DocNo, dbo.Job_BillingHeader.DocDate, dbo.Job_BillingHeader.JobNo, dbo.Job_BillingHeader.JobBillAmt, dbo.Job_BillingHeader.CustCode, 
                         dbo.Job_BillingHeader.CustBranch, dbo.Job_BillingHeader.BillToCustCode, dbo.Job_BillingHeader.BillToCustBranch, dbo.Job_BillingHeader.ContactName, dbo.Job_BillingHeader.EmpCode, dbo.Job_BillingHeader.PrintedBy, 
                         dbo.Job_BillingHeader.PrintedDate, dbo.Job_BillingHeader.PrintedTime, dbo.Job_BillingHeader.RefNo, dbo.Job_BillingHeader.VATRate, dbo.Job_BillingHeader.Tavi50Rate1, dbo.Job_BillingHeader.Tavi50Rate2, 
                         dbo.Job_BillingHeader.TaxInvNo, dbo.Job_BillingHeader.TaxInvDate, dbo.Job_BillingHeader.TotalAdvance, dbo.Job_BillingHeader.TotalCharge, dbo.Job_BillingHeader.TotalIsTaxCharge, dbo.Job_BillingHeader.TotalIs50Tavi1, 
                         dbo.Job_BillingHeader.TotalIs50Tavi2, dbo.Job_BillingHeader.TotalVAT, dbo.Job_BillingHeader.Total50Tavi1, dbo.Job_BillingHeader.Total50Tavi2, dbo.Job_BillingHeader.TotalCustAdv, dbo.Job_BillingHeader.TotalNet, 
                         dbo.Job_BillingHeader.BillDate, dbo.Job_BillingHeader.BillTime, dbo.Job_BillingHeader.BillAcceptNo, dbo.Job_BillingHeader.PayDate, dbo.Job_BillingHeader.PayTime, dbo.Job_BillingHeader.Remark1, 
                         dbo.Job_BillingHeader.Remark2, dbo.Job_BillingHeader.Remark3, dbo.Job_BillingHeader.Remark4, dbo.Job_BillingHeader.Remark5, dbo.Job_BillingHeader.Remark6, dbo.Job_BillingHeader.Remark7, 
                         dbo.Job_BillingHeader.Remark8, dbo.Job_BillingHeader.Remark9, dbo.Job_BillingHeader.Remark10, dbo.Job_BillingHeader.CancelReson, dbo.Job_BillingHeader.CancelProve, dbo.Job_BillingHeader.CancelDate, 
                         dbo.Job_BillingHeader.CancelTime, dbo.Job_BillingHeader.PaidFlag, dbo.Job_BillingHeader.ShippingRemark, dbo.Job_BillingHeader.CurrencyCode, dbo.Job_BillingHeader.ExchangeRate, dbo.Job_BillingHeader.ForeignAmt, 
                         dbo.Job_BillingDetail.ItemNo, dbo.Job_BillingDetail.SICode, dbo.Job_BillingDetail.SDescription, dbo.Job_BillingDetail.ExpSlipNO, dbo.Job_BillingDetail.SRemark, dbo.Job_BillingDetail.QtyUnit, 
                         dbo.Job_BillingDetail.IsTaxCharge, dbo.Job_BillingDetail.Is50Tavi, dbo.Job_BillingDetail.Rate50Tavi, dbo.Job_BillingDetail.AmtAdvance, dbo.Job_BillingDetail.AmtCharge, dbo.Job_Order.InvNo, dbo.Job_Order.InvProduct, 
                         dbo.Job_Order.VesselName, dbo.Job_Order.ETADate, dbo.Job_Order.ETDDate, dbo.Mas_Company.Title, dbo.Mas_Company.NameThai, dbo.Mas_Company.NameEng, dbo.Mas_Company.TAddress1, 
                         dbo.Mas_Company.TAddress2, dbo.Mas_Company.EAddress1, dbo.Mas_Company.EAddress2, dbo.Job_Order.DeclareNumber, dbo.Job_BillingDetail.ForeignAmt AS DForeignAmt, 
                         dbo.Job_BillingDetail.CurrencyCode AS DCurrencyCode, dbo.Job_BillingDetail.ExchangeRate AS DExchangeRate, dbo.Job_BillingDetail.DiscountPerc, dbo.Job_BillingDetail.AmtDiscount, dbo.Job_BillingDetail.ForeignDisc, 
                         dbo.Job_BillingDetail.FUnitPrice, dbo.Job_BillingDetail.FQty, dbo.Job_BillingDetail.FTotalAmt, dbo.Mas_Company.TaxNumber, dbo.Job_BillingDetail.CurrencyCodeCredit, dbo.Job_BillingDetail.ExchangeRateCredit, 
                         dbo.Job_BillingDetail.ForeignAmtCredit, dbo.Job_SrvSingle.ProcessDesc, dbo.Job_SrvSingle.GLAccountCodeSales, dbo.Job_SrvSingle.GLAccountCodeCost, dbo.Job_Order.BLNo, dbo.Job_Order.BookingNo, 
                         dbo.Job_Order.ClearPortNo, dbo.Job_Order.InvTotal, dbo.Job_Order.InvCountry, dbo.Job_Order.InvFCountry, dbo.Job_Order.InvInterPort, dbo.Job_Order.InvProductQty, dbo.Job_Order.InvProductUnit, dbo.Job_Order.InvCurUnit, 
                         dbo.Job_Order.InvCurRate, dbo.Job_Order.ImExDate, dbo.Job_Order.ClearPort, dbo.Job_Order.ForwarderCode, dbo.Job_Order.AgentCode, dbo.Job_Order.LoadDate, dbo.Job_Order.ClearDate, dbo.Job_Order.TotalContainer, 
                         dbo.Job_Order.ShippingCmd, dbo.Job_Order.TotalGW, dbo.Job_Order.GWUnit, dbo.Job_Order.ProjectName, dbo.Job_Order.MVesselName, dbo.Job_Order.Commission, dbo.Job_Order.TotalNW, dbo.Job_Order.Measurement, 
                         dbo.Job_Order.CustRefNO, dbo.Job_Order.TotalQty, dbo.Job_Order.HAWB, dbo.Job_Order.MAWB, dbo.Mas_User.TName AS EmpName
FROM            dbo.Mas_User RIGHT OUTER JOIN
                         dbo.Job_BillingHeader ON dbo.Mas_User.UserID = dbo.Job_BillingHeader.EmpCode LEFT OUTER JOIN
                         dbo.Job_SrvSingle INNER JOIN
                         dbo.Job_BillingDetail ON dbo.Job_SrvSingle.SICode = dbo.Job_BillingDetail.SICode ON dbo.Job_BillingHeader.BranchCode = dbo.Job_BillingDetail.BranchCode AND 
                         dbo.Job_BillingHeader.DocNo = dbo.Job_BillingDetail.DocNo LEFT OUTER JOIN
                         dbo.Job_Order ON dbo.Job_BillingHeader.BranchCode = dbo.Job_Order.BranchCode AND dbo.Job_BillingHeader.JobNo = dbo.Job_Order.JNo LEFT OUTER JOIN
                         dbo.Mas_Company ON dbo.Job_BillingHeader.BillToCustCode = dbo.Mas_Company.CustCode AND dbo.Job_BillingHeader.BillToCustBranch = dbo.Mas_Company.Branch



GO
/****** Object:  View [dbo].[qJob_DebitNoteSub]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qJob_DebitNoteSub]
AS
SELECT     dbo.Job_DebitNote.BranchCode, dbo.Job_DebitNote.DocNo, dbo.Job_DebitNote.DocDate, dbo.Job_DebitNote.InvNo, dbo.Job_DebitNote.EmpCode, 
                      dbo.Job_DebitNote.ApproveBy, dbo.Job_DebitNote.ApproveDate, dbo.Job_DebitNote.ApproveTime, dbo.Job_DebitNote.Remark, 
                      dbo.Job_DebitNote.VatRate, dbo.Job_DebitNote.VatAmt, dbo.Job_DebitNote.TotalNet, dbo.Job_DebitNote.VatInclude, dbo.Job_DebitNote.IsCreditNote, 
                      dbo.Job_DebitNoteSub.ItemNo, dbo.Job_DebitNoteSub.BillingNo, dbo.Job_DebitNoteSub.SICode, dbo.Job_DebitNoteSub.SDescription, 
                      dbo.Job_DebitNoteSub.OriginalAmt, dbo.Job_DebitNoteSub.CorrectAmt, dbo.Job_DebitNoteSub.DiffAmt, dbo.Job_DebitNoteSub.CurrencyCode, 
                      dbo.Job_DebitNoteSub.ExchangeRate, dbo.Job_DebitNoteSub.ForeignAmt, dbo.Job_BillingHeader.CustCode, dbo.Job_BillingHeader.CustBranch, 
                      dbo.Job_BillingHeader.JobNo, dbo.Job_BillingHeader.BillAcceptNo, dbo.Job_BillingHeader.BillDate, dbo.Job_BillingHeader.TaxInvNo, 
                      dbo.Job_BillingHeader.TaxInvDate, dbo.Mas_Company.NameThai, dbo.Mas_Company.NameEng, dbo.Mas_Company.TAddress1, 
                      dbo.Mas_Company.TAddress2, dbo.Mas_Company.EAddress1, dbo.Mas_Company.EAddress2, dbo.Mas_Company.TaxNumber
FROM         dbo.Mas_Company RIGHT OUTER JOIN
                      dbo.Job_BillingHeader ON dbo.Mas_Company.CustCode = dbo.Job_BillingHeader.CustCode AND 
                      dbo.Mas_Company.Branch = dbo.Job_BillingHeader.CustBranch RIGHT OUTER JOIN
                      dbo.Job_DebitNoteSub RIGHT OUTER JOIN
                      dbo.Job_DebitNote ON dbo.Job_DebitNoteSub.BranchCode = dbo.Job_DebitNote.BranchCode AND 
                      dbo.Job_DebitNoteSub.DocNo = dbo.Job_DebitNote.DocNo ON dbo.Job_BillingHeader.DocNo = dbo.Job_DebitNoteSub.BillingNo


GO
/****** Object:  View [dbo].[qJob_Order]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qJob_Order]
AS
SELECT        a.BranchCode, a.JNo, a.JRevise, a.ConfirmDate, a.CPolicyCode, a.DocDate, a.CustCode, a.CustBranch, a.CustContactName, a.QNo, a.Revise, a.ManagerCode, a.CSCode, a.Description, a.TRemark, a.JobStatus, a.JobType, 
                         a.ShipBy, a.InvNo, a.InvTotal, a.InvProduct, a.InvCountry, a.InvFCountry, a.InvInterPort, a.InvProductQty, a.InvProductUnit, a.InvCurUnit, a.InvCurRate, a.ImExDate, a.BLNo, a.BookingNo, a.ClearPort, a.ClearPortNo, a.ClearDate, 
                         a.LoadDate, a.ForwarderCode, a.AgentCode, a.VesselName, a.ETDDate, a.ETADate, a.ETTime, a.FNetPrice, a.BNetPrice, a.CancelReson, a.CancelDate, a.CancelTime, a.CancelProve, a.CancelProveDate, a.CancelProveTime, 
                         a.CloseJobDate, a.CloseJobTime, a.CloseJobBy, a.DeclareType, a.DeclareNumber, a.DeclareStatus, a.TyAuthorSp, a.Ty19BIS, a.TyClearTax, a.TyClearTaxReson, a.EstDeliverDate, a.EstDeliverTime, a.TotalContainer, 
                         a.DutyDate, a.DutyAmount, a.DutyCustPayOther, a.DutyCustPayChqAmt, a.DutyCustPayBankAmt, a.DutyCustPayEPAYAmt, a.DutyCustPayCardAmt, a.DutyCustPayCashAmt, a.DutyCustPayOtherAmt, a.DutyLtdPayOther, 
                         a.DutyLtdPayChqAmt, a.DutyLtdPayEPAYAmt, a.DutyLtdPayCashAmt, a.DutyLtdPayOtherAmt, a.ConfirmChqDate, a.ShippingEmp, a.ShippingCmd, a.TotalGW, a.GWUnit, a.TSRequest, a.ShipmentType, a.ReadyToClearDate, 
                         a.Commission, a.CommPayTo, a.ProjectName, a.MVesselName, a.TotalNW, a.Measurement, a.CustRefNO, a.TotalQty, a.HAWB, a.MAWB, a.consigneecode, a.privilegests, a.CustCode + '-' + a.CustBranch AS CustID, b.Title, 
                         b.NameThai, b.NameEng, d.AreaName, e.TName AS CSName, b.ManagerCode AS SalesCode, f.NameEng AS ConsigneeName, g.TName AS ForwarderName, dbo.Mas_Vender.TName AS AgentName, b.TAddress1, b.TAddress2, 
                         b.EAddress1, b.EAddress2
FROM            dbo.Job_Order AS a LEFT OUTER JOIN
                         dbo.Mas_Vender ON a.AgentCode = dbo.Mas_Vender.VenCode LEFT OUTER JOIN
                         dbo.Mas_Vender AS g ON a.ForwarderCode = g.VenCode LEFT OUTER JOIN
                         dbo.Mas_Company AS b ON a.CustCode = b.CustCode AND a.CustBranch = b.Branch LEFT OUTER JOIN
                         dbo.Mas_Consignee AS f ON a.consigneecode = f.Code AND b.TaxNumber = f.TaxNumber LEFT OUTER JOIN
                         dbo.Mas_RFARS AS d ON a.ClearPort = d.AreaCode LEFT OUTER JOIN
                         dbo.Mas_User AS e ON a.CSCode = e.UserID


GO
/****** Object:  View [dbo].[qJob_BillBalance]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[qJob_BillBalance]
as

with da as
(
select a.BranchCode as InvBranch,a.DocNo,a.DocDate as InvDate,a.BillAcceptNo,a.TaxInvNo,
a.JobNo,a.BillDate,a.TaxInvDate,a.CancelReson as InvCancelReason,a.CancelProve as InvCancelAppr
,a.TotalNet,a.TotalCharge,a.TotalAdvance,a.TotalIsTaxCharge,
a.Total50Tavi1+a.Total50Tavi2 as Total50Tavi,
a.TotalVAT,a.TotalCustAdv,a.TotalCharge+a.TotalVAT as TotalVATCharge,
isnull(b.TotalPaid,0) as TotalPaid,isnull(c.TotalChqRcv,0) as TotalChqRcv
,isnull(d.directpaytotal,0) as TotalDirect,isnull(e.AdjustAmt,0) as TotalAdj,
isnull(e.CNNo,'') as CNNo,b.RCVDate,
case when substring(a.DocNo,2,1)='F' then 'Freight' else
(case when substring(a.DocNo,2,1)='T' then 'Transport' else 'Service' end) end 
as InvType
from Job_BillingHeader a
left join
(
	select hd.BranchCode,dt.DocNo,sum(dt.PaidAmount) as TotalPaid,Max(hd.VoucherDate) as RCVDate 
	from Job_CashControlDoc dt inner join Job_CashControl hd on hd.BranchCode=dt.BranchCode
	and hd.ControlNo=dt.ControlNo
	where dt.DocType='INV' and not hd.CancelProve<>''
	group by hd.BranchCode,dt.DocNo 
) b
on a.BranchCode=b.BranchCode And a.DocNo=b.DocNo 
left join 
(
	select b.BranchCode,b.BillingNo,Sum(b.PayAmount) as TotalChqRcv from Job_CustAdvChqSub b inner join Job_CustAdvChq a on a.BranchCode=b.BranchCode and a.RefNo=b.RefNo  Where Not a.CancelBy<>'' and b.SICode='' And b.BillFlag='N'
	group by b.BranchCode,b.BillingNo 
) c
on a.BranchCode=b.BranchCode and a.DocNo=c.BillingNo
left join
(
	select branchCode,docno,sum(amtCharge+amtadvance) as DirectPayTotal from qJob_billdetail where substring(SRemark,1,1)='*' group by branchCode,docno
) d
on a.BranchCode=b.BranchCode and a.DocNo=d.DocNo
left join 
(
	select a.BranchCode,a.BillingNo,Sum(a.DiffAmt+
	(case when b.IsTaxCharge=1 then a.DiffAmt*(b.VATRate*0.01) else 0 end)-
	(case when b.Is50Tavi=1 then a.DiffAmt*(b.Rate50Tavi*0.01) else 0 end)) as AdjustAmt
	,max(a.docno) as CNNo
	from qJob_DebitNoteSub a
	inner join qJob_BillDetail b
	on a.BillingNo=b.DocNo and a.SICode=b.SICode 
	group by a.BranchCode,a.BillingNo
) e
on a.BranchCode=b.BranchCode and a.DocNo=e.BillingNo
where a.TotalNet>0
)
select da.*,job.*,da.TotalVATCharge-da.TotalAdj+da.TotalAdvance-da.TotalCustAdv as TotalBill,
da.TotalAdvance-da.TotalCustAdv as AdvBalance,
da.TotalPaid+da.TotalChqRcv+da.TotalDirect as TotalPayment,
da.TotalNet-da.TotalAdj-da.TotalPaid-da.TotalChqRcv-da.TotalDirect as Balance 
from da inner join qJob_Order job on da.JobNo=job.JNo 
GO
/****** Object:  View [dbo].[vJOB_DocAmount]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vJOB_DocAmount] as SELECT DocNo,SUM(PaidAmount) AS DocAmount FROM dbo.Job_CashControlDoc GROUP BY DocNo

GO
/****** Object:  View [dbo].[qJob_BillHeader]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_BillHeader]
AS
SELECT     a.BranchCode, a.DocNo, a.DocDate, a.JobNo, a.JobBillAmt, a.CustCode, a.CustBranch, a.BillToCustCode, a.BillToCustBranch, a.ContactName, a.EmpCode, 
                      a.PrintedBy, a.PrintedDate, a.PrintedTime, a.RefNo, a.VATRate, a.Tavi50Rate1, a.Tavi50Rate2, a.TaxInvNo, a.TaxInvDate, a.TotalAdvance, a.TotalCharge, 
                      a.TotalIsTaxCharge, a.TotalIs50Tavi1, a.TotalIs50Tavi2, a.TotalVAT, a.Total50Tavi1, a.Total50Tavi2, a.TotalCustAdv, a.TotalNet, a.BillDate, a.BillTime, a.BillAcceptNo, 
                      a.PayDate, a.PayTime, a.Remark1, a.Remark2, a.Remark3, a.Remark4, a.Remark5, a.Remark6, a.Remark7, a.Remark8, a.Remark9, a.Remark10, a.CancelReson, 
                      a.CancelProve, a.CancelDate, a.CancelTime, a.PaidFlag, a.ShippingRemark, a.CurrencyCode, a.ExchangeRate, a.ForeignAmt, b.BrName AS BranchName, 
                      a.CustCode + '-' + a.CustBranch AS CustID, c.NameThai AS CustTName, c.NameEng AS CustEName, c.LevelGrade, c.CreditLimit, d.JobType, d.ShipBy, d.JobStatus, 
                      d.DocDate AS JobDate, e.DocAmount AS RcvAmount, d.DutyDate
FROM         dbo.Job_BillingHeader AS a LEFT OUTER JOIN
                      dbo.Mas_Branch AS b ON a.BranchCode = b.Code LEFT OUTER JOIN
                      dbo.Mas_Company AS c ON a.CustCode = c.CustCode AND a.CustBranch = c.Branch LEFT OUTER JOIN
                      dbo.Job_Order AS d ON a.BranchCode = d.BranchCode AND a.JobNo = d.JNo LEFT OUTER JOIN
                      dbo.vJOB_DocAmount AS e ON a.DocNo = e.DocNo

GO
/****** Object:  View [dbo].[qJob_BillAnnSub]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_BillAnnSub] as SELECT a.*,b.ItemNo,b.BillNo,b.AmtAdvance,b.AmtChargeNoVAT,b.AmtChargeVAT,b.AmtWH1,b.AmtWH3,b.AmtVAT,b.AmtTotal,c.DocDate AS BillDate,c.JobNo,d.InvNo,d.InvProduct,d.InvProductQty,d.InvProductUnit,d.BLNo,d.DeclareNumber,d.TotalGW,d.TotalNW,d.GWUnit,d.DocDate AS JobDate,c.CustTName,c.CustEName,d.CustRefNO,c.TaxInvNo,d.JobStatus,c.Remark1,c.Remark2,c.Remark3,c.Remark4,c.Remark5,c.Remark6,c.Remark7,c.Remark8,c.Remark9,c.Remark10,b.ReceiptDate,b.ReceiptNo,c.RcvAmount,c.dutydate FROM dbo.Job_BillAnn a LEFT JOIN dbo.Job_BillAnnSub b LEFT JOIN dbo.qJob_BillHeader c ON b.BillNo = c.DocNo AND b.BranchCode = c.BranchCode ON a.DocNO = b.DocNO AND a.BranchCode = b.BranchCode LEFT JOIN dbo.Job_Order d ON c.BranchCode = d.BranchCode AND c.JobNo = d.JNo

GO
/****** Object:  View [dbo].[qJob_CashControl]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_CashControl] AS 
SELECT Job_CashControl.*, Job_CashControlSub.ItemNo, Job_CashControlSub.PRVoucher, Job_CashControlSub.PRType, Job_CashControlSub.ChqNo, Job_CashControlSub.BookCode, Job_CashControlSub.BankCode, Job_CashControlSub.BankBranch, Mas_BankCode.BName AS BankName, Mas_BookAccount.BookName, Mas_BookAccount.BankCode AS BookBank, Mas_BookAccount.BankBranch AS BookBankBranch, Job_CashControlSub.ChqDate, Job_CashControlSub.CashAmount, Job_CashControlSub.ChqAmount, Job_CashControlSub.CreditAmount, Job_CashControlSub.IsLocal, Job_CashControlSub.ChqStatus, Job_CashControlSub.TRemark AS SRemark, Job_CashControlSub.PayChqTo, Mas_Branch.BrName, Mas_User.TName AS UserName
FROM ((((Job_CashControl LEFT JOIN Job_CashControlSub ON (Job_CashControl.ControlNo=Job_CashControlSub.ControlNo) AND (Job_CashControl.BranchCode=Job_CashControlSub.BranchCode)) LEFT JOIN Mas_BookAccount ON (Job_CashControlSub.BranchCode=Mas_BookAccount.BranchCode) AND (Job_CashControlSub.BookCode=Mas_BookAccount.BookCode)) LEFT JOIN Mas_Branch ON Job_CashControl.BranchCode=Mas_Branch.Code) LEFT JOIN Mas_BankCode ON Job_CashControlSub.BankCode=Mas_BankCode.Code) LEFT JOIN Mas_User ON Job_CashControl.RecUser=Mas_User.UserID

GO
/****** Object:  View [dbo].[qJob_Tracking]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qJob_Tracking]
AS
SELECT 'สาขา' AS BranchCode,
'หมายเลขงาน' AS JNo,
'รหัสลูกค้า' AS CustCode,
'สาขา' AS CustBranch,
'ชื่อลูกค้า' AS CustName,
'CS' AS CSCode,
'Shipping' AS ShippingCode,
'สถานะ' AS JobStatus,
'รหัสประเภทงาน' AS JobType,
'รหัสประเภทขนส่ง' AS ShipBy,
'วันที่เปิดJOB' AS OpenDate,
'วันที่ยืนยัน' AS CustConfirmDate,
'วันนำเข้าส่งออก' AS TransportDate,
'ETD' AS ETD,
'ETA' AS ETA,
'วันปิดงาน' AS CloseJob,
'วันตรวจปล่อย' AS ReleaseDate,
'วันโหลดของ' AS Loading,
'วันส่งของ' AS Delivery,
'เลขที่ใบเบิก' AS AdvNo,
'วันที่เบิกเงิน' AS AdvDate,
'วันที่จ่ายเงิน' AS AdvPayDate,
'Voucherเบิก' AS VoucherAdv,
'ระยะเวลาเบิก-จ่าย' AS AdvDayPass,
'ยอดเบิก' AS AdvTotal,
'ใบปิดคชจ' AS ClearingNO,
'วันที่ปิดคชจ' AS ClearingDate,
'ระยะเวลาเบิก-ปิด' AS ClrDayPass,
'วันที่รับเคลียร์เงิน' AS ClrRcvDate,
'Voucherปิด' AS VoucherClr,
'ระยะเวลาปิด-รับเคลียร์' AS ClrRcvPass,
'ยอดค่าใช้จ่าย' AS ClrTotal,
'ยอดเคลียร์เงิน' AS ClrBal,
'เลขที่ใบแจ้งหนี้' AS InvNo,
'วันที่แจ้งหนี้' AS InvDate,
'ระยะเวลารับเคลียร์-แจ้งหนี้' AS InvDayPass,
'เลขที่ใบวางบิล' AS BillAcceptNo,
'วันที่วางบิล' AS BillingDate,
'ระยะเวลาแจ้งหนี้-วางบิล' AS BillDayPass,
'เลขที่ใบเสร็จ' AS TaxInvNo,
'วันที่ใบเสร็จ' AS TaxInvDate,
'ระยะเวลาวางบิล-ใบเสร็จ' AS TaxInvDayPass,
'เลขที่RV' AS RcvVoucher,
'วันที่RV' AS RcvDate,
'ระยะเวลาใบเสร็จ-รับเงิน' AS RcvIncPass,
'รับเข้าเลขที่บัญชี' AS BookAccount,
'วันที่รับเข้าบัญชี' AS TransDate,
'รหัสค่าบริการ' AS SICode,
'คำอธิบาย' AS SDescription,
'ต้นทุนคชจ' AS AdvCost,
'คชจเก็บได้' AS AdvBill,
'คฃจแจ้งหนี้แล้ว' AS AdvInv,
'ค่าบริการ' AS ServBill,
'ค่าบริการแจ้งหนี้' AS ServInv
union
SELECT j.BranchCode, j.JNo, 
--Job data
j.CustCode, j.CustBranch,j.NameThai,j.CSCode,
j.ShippingEmp, 
dbo.GetJobStatus(Convert(varchar,j.JobStatus)) as JobStatus, 
dbo.GetJobType(Convert(varchar,j.JobType)) as JobType,
dbo.GetShipBy(Convert(varchar, j.ShipBy)) as ShipBy,
Convert(varchar,j.DocDate,103) as OpenDate, Convert(varchar,j.ConfirmDate,103) as CustConfirmDate, 
Convert(varchar,j.ImExDate,103) as TransportDate, Convert(varchar,j.ETDDate,103) as ETD,Convert(varchar, j.ETADate,103) as ETA, 
Convert(varchar,j.CloseJobDate,103) as CloseJob,Convert(varchar, j.DutyDate,103) as ReleaseDate, 
Convert(varchar,j.LoadDate,103) as Loading,Convert(varchar, j.EstDeliverDate,103) as Delivery, 
--Advance Data
a.AdvNo,Convert(varchar, a.AdvDate,103) as AdvDate, Convert(varchar,a.PaymentDate,103) as AdvPayDate,
a.PaymentRef AS VoucherAdv,Convert(varchar,DATEDIFF(D, j.DocDate,a.PaymentDate)) AS AdvDayPass,
Convert(varchar,a.TotalAdvance + a.TotalVAT - a.Total50Tavi) AS AdvTotal,
--Clearing Data
d.ClearingNO, Convert(varchar,c.ClrDate,103) as ClearingDate, Convert(varchar,DATEDIFF(D, a.PaymentDate, c.ClrDate)) AS ClrDayPass,
Convert(varchar,c.ReceiveDate,103) as ClrRcvDate,ReceiveRef AS VoucherClr, Convert(varchar,DATEDIFF(D,c.ClrDate,c.ReceiveDate)) as ClrRcvPass,
Convert(varchar,c.TotalExpense) AS ClrTotal, Convert(varchar,c.AdvTotal - c.TotalExpense) AS ClrBal, 
--Costing and Billing Data
d.DNNo AS InvNo, Convert(varchar,d.InvDate,103) as InvDate, Convert(varchar,DATEDIFF(D, c.ReceiveDate, d.InvDate)) AS InvDayPass, 
d.BillAcceptNo, Convert(varchar,b.DocDate,103) AS BillingDate, Convert(varchar,DATEDIFF(D, d.InvDate, b.DocDate)) AS BillDayPass, 
d.TaxInvNo,Convert(varchar,d.TaxInvDate,103) as TaxInvDate,Convert(varchar,DATEDIFF(D,b.DocDate,d.TaxInvDate)) as TaxInvDayPass,
--Receiving Data
v.PRVoucher as RcvVoucher,Convert(varchar,v.VoucherDate,103) as RcvDate,Convert(varchar,DATEDIFF(D,b.DocDate,v.VoucherDate)) as RcvIncPass,
v.BookCode,convert(varchar,v.ChqDate,103),
d.SICode,d.SDescription, Convert(varchar,i.AdvCost) as CostExp, Convert(varchar,i.AdvBill) as BillExp, Convert(varchar,i.AdvInv) as InvExp,
Convert(varchar, s.ServBill) as BillServ,Convert(varchar, s.ServInv) as InvServ
FROM dbo.qJob_Order AS j 
LEFT JOIN (
     SELECT DISTINCT b.BranchCode, b.JNo, b.ClearingNO, b.DNNo,c.TaxInvNo as TaxInvNo,c.TaxInvDate as TaxInvDate,  c.DocDate AS InvDate, b.SICode, b.SDescription,c.BillAcceptNo
     FROM dbo.Job_Detail AS b LEFT OUTER JOIN dbo.Job_ClearDetail AS e ON b.BranchCode = e.BranchCode AND b.ClearingNO = e.ClrNo AND b.SICode = e.SICode AND b.RSlipNO = e.SlipNO 
     LEFT OUTER JOIN dbo.Job_BillingHeader AS c ON b.BranchCode = c.BranchCode AND b.DNNo = c.DocNo
) as d on j.BranchCode=d.BranchCode and j.JNo=d.JNo 
LEFT JOIN dbo.Job_ClearHeader AS c ON d.BranchCode = c.BranchCode AND d.ClearingNO = c.ClrNo AND c.DocStatus <> 99 
LEFT JOIN dbo.Job_AdvHeader AS a ON d.BranchCode = a.BranchCode AND d.JNo = a.JNo AND a.DocStatus <> 99 AND a.AdvNo = c.AdvRefNo 
LEFT JOIN (
     SELECT b.BranchCode, b.JNo, b.ClearingNO, b.DNNo, b.SICode, SUM(b.BCost) AS AdvCost, SUM(b.BPrice) AS AdvBill, SUM(f.AmtAdvance) AS AdvInv
     FROM dbo.Job_Detail AS b LEFT JOIN dbo.Job_BillingHeader AS e ON b.BranchCode = e.BranchCode AND b.DNNo = e.DocNo AND NOT (ISNULL(e.CancelProve, '') <> '') LEFT JOIN 
          dbo.Job_BillingDetail AS f ON b.BranchCode = f.BranchCode AND b.DNNo = f.DocNo AND b.SICode = f.SICode --AND b.BPrice > 0 AND f.AmtAdvance > 0
     GROUP BY b.BranchCode, b.JNo, b.ClearingNO, b.DNNo, b.SICode
) AS i ON d.BranchCode = i.BranchCode AND d.JNo = i.JNo AND d.ClearingNO = i.ClearingNO AND d.SICode = i.SICode AND d.DNNo = i.DNNo
LEFT JOIN dbo.qJob_BillAnnSub AS b ON d.BranchCode = b.BranchCode AND d.DNNo = b.BillNo
LEFT JOIN (
     SELECT b.BranchCode, b.JNo, b.DNNo, e.DocDate, b.SICode, SUM(b.BPrice) AS ServBill, SUM(f.AmtCharge) AS ServInv
     FROM dbo.Job_Detail AS b INNER JOIN dbo.Job_BillingHeader AS e ON b.BranchCode = e.BranchCode AND b.DNNo = e.DocNo AND NOT (ISNULL(e.CancelProve, '') <> '') INNER JOIN
     dbo.Job_BillingDetail AS f ON b.BranchCode = f.BranchCode AND b.DNNo = f.DocNo AND b.SICode = f.SICode AND b.BPrice > 0 AND f.AmtCharge > 0
     GROUP BY b.BranchCode, b.JNo, b.DNNo, e.DocDate, b.SICode
) AS s ON d.BranchCode = s.BranchCode AND d.JNo = s.JNo AND d.DNNo = s.DNNo AND d.SICode = s.SICode
LEFT JOIN dbo.qJob_CashControl v on d.BranchCode=v.BranchCode and d.DNNo=v.PayChqTo and d.DNNo=s.DNNo and NOT v.CancelProve<>''

GO
/****** Object:  View [dbo].[qJob_ClearDetail]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_ClearDetail] AS 
SELECT Job_ClearHeader.*, Job_ClearDetail.ItemNo, Job_ClearDetail.LinkItem, Job_ClearDetail.STCode, Job_ClearDetail.SICode, Job_ClearDetail.SDescription, Job_ClearDetail.VenderCode, Job_ClearDetail.Qty, Job_ClearDetail.UnitCode, Job_ClearDetail.CurrencyCode, Job_ClearDetail.CurRate, Job_ClearDetail.ChargeVAT, Job_ClearDetail.UnitPrice, Job_ClearDetail.FPrice, Job_ClearDetail.BPrice, Job_ClearDetail.QUnitPrice, Job_ClearDetail.QFPrice, Job_ClearDetail.QBPrice, Job_ClearDetail.UnitCost, Job_ClearDetail.FCost, Job_ClearDetail.BCost, Job_ClearDetail.Tax50Tavi, Job_ClearDetail.AdvNO, Job_ClearDetail.AdvAmount, Job_ClearDetail.UsedAmount, Job_ClearDetail.IsQuoItem, Job_ClearDetail.SlipNO, Job_ClearDetail.Remark, Job_ClearDetail.AirQtyStep, Job_ClearDetail.StepSub, Job_Order.CustCode, Job_Order.CustBranch, Mas_User.TName AS CSName, Mas_Company.NameThai AS CustName, Job_ClearDetail.Pay50TaviTo, Job_ClearDetail.NO50Tavi, Job_ClearDetail.Date50Tavi, Job_ClearDetail.VenderBillingNo, Job_ClearDetail.IsDuplicate, Job_ClearDetail.IsLtdAdv50Tavi, Job_ClearDetail.JobNo
FROM (((Job_ClearHeader LEFT JOIN Job_ClearDetail ON (Job_ClearHeader.ClrNo = Job_ClearDetail.ClrNo) AND (Job_ClearHeader.BranchCode = Job_ClearDetail.BranchCode)) LEFT JOIN Job_Order ON (Job_ClearHeader.JNo = Job_Order.JNo) AND (Job_ClearHeader.BranchCode = Job_Order.BranchCode)) LEFT JOIN Mas_User ON Job_ClearHeader.EmpCode = Mas_User.UserID) LEFT JOIN Mas_Company ON (Job_Order.CustBranch = Mas_Company.Branch) AND (Job_Order.CustCode = Mas_Company.CustCode)

GO
/****** Object:  View [dbo].[qJob_TrackingSum]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_TrackingSum]
as
SELECT 'สาขา' AS BranchCode,
'หมายเลขงาน' AS JNo,
'รหัสลูกค้า' AS CustCode,
'สาขา' AS CustBranch,
'ชื่อลูกค้า' AS CustName,
'CS' AS CSCode,
'Shipping' as ShippingCode,
'สถานะ' AS JobStatus,
'รหัสประเภทงาน' AS JobType,
'รหัสประเภทขนส่ง' AS ShipBy,
'วันที่เปิดJOB' AS OpenDate,
'วันที่ยืนยัน' AS CustConfirmDate,
'วันนำเข้าส่งออก' AS TransportDate,
'ETD' AS ETD,
'ETA' AS ETA,
'วันปิด' AS CloseJob,
'วันตรวจปล่อย' AS ReleaseDate,
'วันโหลด' AS Loading,
'วันส่งของ' AS Delivery,
'ใบเบิกเลขที่' AS AdvNo,
'วันที่เบิกเงิน' AS AdvDate,
'วันที่จ่ายเงิน' AS AdvPayDate,
'Voucherเบิก' AS VoucherAdv,
'ระยะเวลาเบิก-จ่าย' AS AdvDayPass,
'ยอดเบิก' AS AdvTotal,
'ใบปิดเลขที่' AS ClearingNO,
'วันที่ใบปิด' AS ClearingDate,
'ระยะเวลาเบิก-ปิด' AS ClrDayPass,
'วันที่รับเคลียร์' AS ClrRcvDate,
'Voucherปิด' AS VoucherClr,
'ระยะเวลาปิด-เคลียร์' AS ClrRcvPass,
'ยอดค่าใช้จ่าย' AS ClrTotal,
'เคลียร์จากใบเบิก' AS ClrType1,
'เคลียร์เพิ่มเติม' AS ClrType2,
'เคลียร์ไม่มีใบเบิก' AS ClrType3,
'เคลียร์ค่าขอคืนอากร' AS ClrType4,
'ยอดเคลียร์เงิน' AS ClrBal,
'ใบแจ้งหนี้เลขที่' AS InvNo,
'วันที่ใบแจ้งหนี้' AS InvDate,
'ระยะเวลาเคลียร์-ใบแจ้งหนี้' AS InvDayPass,
'ใบวางบิลเลขที่' AS BillAcceptNo,
'วันที่ใบวางบิล' AS BillingDate,
'ระยะเวลาใบแจ้งหนี้-ใบวางบิล' AS BillDayPass,
'ใบเสร็จเลขที่' AS TaxInvNo,
'วันที่ใบเสร็จรับเงิน' AS TaxInvDate,
'ระยะเวลาวางบิล-รับเงิน' AS TaxInvDayPass,
'เลขที่RV' AS RcvVoucher,
'วันที่RV' AS RcvDate,
'ระยะเวลา' AS RcvIncPass,
'รับเข้าบัญชี' AS BookAccount,
'วันที่เข้าบัญชี' AS TransDate,
'ต้นทุนคชจ' AS AdvCost,
'คชจเก็บได้' AS AdvBill,
'คฃจแจ้งหนี้แล้ว' AS AdvInv,
'ค่าบริการ' AS ServBill,
'ค่าบริการแจ้งหนี้' AS ServInv,
'ภาษีมูลค่าเพิ่ม' AS VatInv,
'รวมยอดแจ้งหนี้' AS TotalInv,
'กำไรขาดทุน' AS Profit
union
SELECT j.BranchCode, j.JNo, 
--Job data
j.CustCode, j.CustBranch,j.NameThai,j.CSCode,j.ShippingEmp, 
dbo.GetJobStatus(Convert(varchar,j.JobStatus)) as JobStatus, 
dbo.GetJobType(Convert(varchar,j.JobType)) as JobType,
dbo.GetShipBy(Convert(varchar, j.ShipBy)) as ShipBy,
Convert(varchar,j.DocDate,103) as OpenDate, Convert(varchar,j.ConfirmDate,103) as CustConfirmDate, 
Convert(varchar,j.ImExDate,103) as TransportDate, Convert(varchar,j.ETDDate,103) as ETD,Convert(varchar, j.ETADate,103) as ETA, 
Convert(varchar,j.CloseJobDate,103) as CloseJob,Convert(varchar, j.DutyDate,103) as ReleaseDate, 
Convert(varchar,j.LoadDate,103) as Loading,Convert(varchar, j.EstDeliverDate,103) as Delivery,
--Advance Data
AdvNo=STUFF((SELECT ','+AdvNo from Job_AdvHeader where DocStatus<>99 And JNo=j.JNo FOR XML PATH('')),1,1,''),
a.AdvDate,Convert(varchar,a.AdvPayDate,103) as PaymentDate,
VoucherAdv=STUFF((SELECT DISTINCT ','+PaymentRef from Job_AdvHeader where DocStatus in(3,4) And JNo=j.JNo And PaymentRef<>'' FOR XML PATH('')),1,1,''),
Convert(varchar,DATEDIFF(D, j.DocDate,a.AdvPayDate)) AS AdvDayPass,a.AdvTotal,
--Clearing Data
ClearingNo=STUFF((SELECT DISTINCT ','+ClrNo FROM qJob_ClearDetail WHERE JNo=j.JNo And DocStatus IN(2,3) FOR XML PATH('')),1,1,''),
Convert(varchar,c.ClearingDate,103) as ClrDate,
Convert(varchar,DATEDIFF(D, a.AdvPayDate, c.ClearingDate)) AS ClrDayPass,
Convert(varchar,c.ClrRcvDate,103) as ClrRcvDate,
VoucherClr=STUFF((SELECT DISTINCT ','+ReceiveRef FROM qJob_ClearDetail WHERE JNo=j.JNo And DocStatus IN(2,3) And ReceiveRef<>'' FOR XML PATH('')),1,1,''),
Convert(varchar,DATEDIFF(D,c.ClearingDate,c.ClrRcvDate)) as ClrRcvPass,
c.ClrTotal,c.ClrBal1,c.ClrBal2,c.ClrBal3,c.ClrBal4,c.ClrBal,
--Billing Data
DNNo=STUFF((SELECT ','+DocNo from Job_BillingHeader where Not CancelProve<>'' And JobNo=j.JNo FOR XML PATH('')),1,1,''),
Convert(varchar,i.InvDate,103) as InvDate,
Convert(varchar,DATEDIFF(D, c.ClrRcvDate, i.InvDate)) AS InvDayPass, 
BillAcceptNo=STUFF((SELECT DISTINCT ','+BillAcceptNo FROM Job_BillingHeader where Not CancelProve<>'' And JobNo=j.JNo And BillAcceptNo<>'' FOR XML PATH('')),1,1,''),
Convert(varchar,i.BillDate,103) as BillingDate,i.BillDayPass,
TaxInvNo=STUFF((SELECT DISTINCT ','+TaxInvNo FROM Job_BillingHeader where Not CancelProve<>'' And JobNo=j.JNo And TaxInvNo<>'' FOR XML PATH('')),1,1,''),
Convert(varchar,i.taxInvDate,103) as TaxInvDate,i.TaxInvDayPass,
--Receive Data
RCVVoucher=STUFF((SELECT DISTINCT ','+PRVoucher FROM qJob_CashControl
					 WHERE Not CancelProve<>'' And ControlNo in(SELECT a.ControlNo from Job_CashControlDoc a inner join Job_Billingheader b
					 on a.BranchCode=b.BranchCode and a.DocNo=b.DocNo where b.JobNo=j.JNo and PRVoucher<>'') FOR XML PATH('')),1,1,''),
Convert(varchar,v.RcvDate,103) as RcvDate,
Convert(varchar,DATEDIFF(D,i.BillDate,v.RcvDate)) as RcvIncPass,					 
v.BookBank as BookCode,
convert(varchar,v.ChqDate,103) as ChqDate,
Convert(varchar,d.CostExp) as CostExp,
Convert(varchar,d.BillExp) as BillExp,
Convert(varchar,i.InvExp) as InvExp,
Convert(varchar,d.BillServ) as BillServ,
Convert(varchar,i.InvChg) as InvServ,
Convert(varchar,i.InvVat) as InvVat,
Convert(varchar,i.InvTotal) as Invtotal,
Convert(varchar,(ISNULL(d.BillExp,0)+ISNULL(d.BillServ,0))-ISNULL(d.CostExp,0)) as Profit 
from qJob_Order j
LEFT JOIN 
(
	SELECT BranchCode,JNo,Count(AdvNo) as CountAdv,
	Convert(varchar, Min(AdvDate),103) as AdvDate, Max(PaymentDate) as AdvPayDate,	
	Convert(varchar,SUM(TotalAdvance + TotalVAT - Total50Tavi)) AS AdvTotal
	FROM Job_AdvHeader WHERE DocStatus IN(3,4) 
	GROUP BY BranchCode,JNo
) a ON j.BranchCode=a.BranchCode and j.JNo=a.JNo 
LEFT JOIN
(
	SELECT BranchCode,JNo,Count(ClrNo) as CountClr,
	Min(ClrDate) as ClearingDate,
	Min(ReceiveDate) as ClrRcvDate,
    Convert(varchar,Sum(TotalExpense)) AS ClrTotal, 
Convert(varchar,Sum(case when cleartype=1 then AdvTotal - TotalExpense else 0 end)) AS ClrBal1,
Convert(varchar,Sum(case when cleartype=2 then AdvTotal - TotalExpense else 0 end)) AS ClrBal2,
Convert(varchar,Sum(case when cleartype=3 then AdvTotal - TotalExpense else 0 end)) AS ClrBal3,
Convert(varchar,Sum(case when cleartype=4 then AdvTotal - TotalExpense else 0 end)) AS ClrBal4,
Convert(varchar,Sum(AdvTotal - TotalExpense)) AS ClrBal
	FROM Job_ClearHeader WHERE DocStatus IN(2,3)
	GROUP BY BranchCode,JNo
) c ON j.BranchCode=c.BranchCode and j.JNo=c.JNo
LEFT JOIN 
(
	SELECT BranchCode,JobNo as JNo,Min(DocDate) as InvDate,
	Convert(varchar,Sum(TotalAdvance)) as InvExp,
	Convert(varchar,Sum(TotalCharge)) as InvChg,
	Convert(varchar,Sum(TotalCharge+TotalVAT)) as InvServ,
	Sum(TotalAdvance+TotalCharge+TotalVAT) as InvTotal,
	Convert(varchar,Sum(TotalNet)) as InvNet,
	Convert(varchar,Sum(TotalVat)) as InvVat,
	Convert(varchar,Sum(Total50Tavi1+Total50Tavi2)) as InvTax,
	Convert(varchar,Sum(TotalcustAdv)) as InvCustAdv,
	Max(BillDate) as BillDate,
	Convert(varchar,DATEDIFF(D, Min(DocDate), Max(BillDate))) as BillDayPass,
	Max(TaxInvDate) as TaxInvDate,
	Convert(varchar,DATEDIFF(D,Max(BillDate),Max(TaxInvDate))) as TaxInvDayPass
	FROM Job_BillingHeader 
	WHERE Not CancelProve<>''
	GROUP BY BranchCode,JobNo
) i on j.BranchCode=i.BranchCode and j.jno=i.jno
left join
(
    SELECT a.BranchCode,b.JobNo as JNo,
	Max(a.VoucherDate) as RcvDate,
	Max(a.BookCode) as BookBank,
	Max(a.ChqDate) as ChqDate
	From qJob_CashControl a inner join Job_CashControlDoc c
	on a.BranchCode=c.BranchCode and a.controlno=c.controlNo
	inner join job_billingheader b on a.BranchCode=b.BranchCode
	and c.DocNo=b.DocNo where Not b.CancelProve<>'' and Not a.CancelProve<>''
	group by a.BranchCode,b.JobNo
) v on j.BranchCode=v.BranchCode and j.JNo=v.JNo
left join
(
	SELECT BranchCode,JNo,Sum(case when BCost>0 then BCost else 0 end) as CostExp,
	Sum(Case when BCost>0 and BPrice>0 and ClearingNo<>'' then BPrice else 0 end) as BillExp,
	Sum(Case when BCost=0 and BPrice>0 and Not ClearingNo<>'' then BPrice else 0 end) as BillServ
	from Job_Detail 
	group by BranchCode,JNo
) d on j.BranchCode=d.BranchCode and j.JNo=d.JNo
GO
/****** Object:  View [dbo].[qrpt_TaxInvFristStep]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qrpt_TaxInvFristStep]
AS
SELECT     BranchCode, TaxInvNo, ISNULL(SUM(AmtAdvance), 0) AS Reimbuse, ISNULL(SUM(AmtCharge), 0) AS Services, ISNULL(IsTaxCharge, 0) 
                      AS IsTaxCharge, ISNULL(VATRate, 0) AS VATRate, ISNULL(Is50Tavi, 0) AS Is50Tavi, ISNULL(Rate50Tavi, 0) AS Rate50Tavi, ProcessDesc, 
                      CancelReson
FROM         dbo.qJob_BillDetail
GROUP BY BranchCode, AmtCharge, IsTaxCharge, VATRate, Is50Tavi, Rate50Tavi, TaxInvNo, ProcessDesc, CancelReson



GO
/****** Object:  View [dbo].[qrpt_TaxInvSecondStep]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qrpt_TaxInvSecondStep]
AS
SELECT     BranchCode, TaxInvNo, DocNo, ISNULL(SUM(AmtAdvance), 0) AS Reimbuse, ISNULL(SUM(AmtCharge), 0) AS Services, ISNULL(IsTaxCharge, 0) 
                      AS IsTaxCharge, ISNULL(VATRate, 0) AS VATRate, ISNULL(Is50Tavi, 0) AS Is50Tavi, ISNULL(Rate50Tavi, 0) AS Rate50Tavi, ProcessDesc, 
                      CancelReson
FROM         dbo.qJob_BillDetail
GROUP BY BranchCode, AmtCharge, IsTaxCharge, VATRate, Is50Tavi, Rate50Tavi, TaxInvNo, ProcessDesc, CancelReson, DocNo



GO
/****** Object:  View [dbo].[qrpt_TaxInvThirdStep]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[qrpt_TaxInvThirdStep]
AS
SELECT     BranchCode, DocNo, DocDate, JobNo, JobBillAmt, CustCode, CustBranch, BillToCustCode, BillToCustBranch, ContactName, EmpCode, PrintedBy, 
                      PrintedDate, PrintedTime, RefNo, VATRate, Tavi50Rate1, Tavi50Rate2, TaxInvNo, TaxInvDate, TotalAdvance, TotalCharge, TotalIsTaxCharge, 
                      TotalIs50Tavi1, TotalIs50Tavi2, TotalVAT, Total50Tavi1, Total50Tavi2, TotalCustAdv, TotalNet, BillDate, BillTime, BillAcceptNo, PayDate, PayTime, 
                      Remark1, Remark2, Remark3, Remark4, Remark5, Remark6, Remark7, Remark8, Remark9, Remark10, CancelReson, CancelProve, CancelDate, 
                      CancelTime, PaidFlag, ShippingRemark, CurrencyCode, ExchangeRate, ForeignAmt, BranchName, CustID, CustTName, CustEName, LevelGrade, 
                      CreditLimit, JobType, ShipBy, JobStatus, JobDate, RcvAmount, dutydate,
                          (SELECT     ISNULL(SUM(Reimbuse), 0) AS Reimbuse
                            FROM          dbo.qrpt_TaxInvSecondStep
                            WHERE      (TaxInvNo = dbo.qJob_BillHeader.TaxInvNo) AND (ProcessDesc = 'ADV') AND (DocNo = dbo.qJob_BillHeader.DocNo)) AS AdvGrp,
                          (SELECT     ISNULL(SUM(Services), 0) AS Reimbuse
                            FROM          dbo.qrpt_TaxInvSecondStep AS qrpt_TaxInvSecondStep_4
                            WHERE      (TaxInvNo = dbo.qJob_BillHeader.TaxInvNo) AND (IsTaxCharge = '0') AND (ProcessDesc = 'FRT') AND 
                                                   (DocNo = dbo.qJob_BillHeader.DocNo)) AS FrtNoVat,
                          (SELECT     ISNULL(SUM(Services), 0) AS Reimbuse
                            FROM          dbo.qrpt_TaxInvSecondStep AS qrpt_TaxInvSecondStep_3
                            WHERE      (TaxInvNo = dbo.qJob_BillHeader.TaxInvNo) AND (IsTaxCharge = '1') AND (ProcessDesc = 'FRT') AND 
                                                   (DocNo = dbo.qJob_BillHeader.DocNo)) AS FrtVat,
                          (SELECT     ISNULL(SUM(Services), 0) AS Reimbuse
                            FROM          dbo.qrpt_TaxInvSecondStep AS qrpt_TaxInvSecondStep_2
                            WHERE      (TaxInvNo = dbo.qJob_BillHeader.TaxInvNo) AND (ProcessDesc = 'SRV') AND (DocNo = dbo.qJob_BillHeader.DocNo)) 
                      AS SRVCharge
FROM         dbo.qJob_BillHeader


GO
/****** Object:  View [dbo].[Q_ProfitSales]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Q_ProfitSales]
AS
SELECT     dbo.qJob_BillDetail.GLAccountCodeSales, dbo.qJob_BillDetail.ProcessDesc, ROUND(SUM(dbo.qJob_BillDetail.AmtCharge), 2) AS SrvCharge, 
                      ROUND(SUM(dbo.qJob_BillDetail.AmtAdvance), 2) AS SrvAdvance, ROUND(SUM(dbo.qJob_BillDetail.AmtCharge + dbo.qJob_BillDetail.AmtAdvance), 2) AS TotalAmt, 
                      dbo.Job_Order.JNo
FROM         dbo.Job_Order INNER JOIN
                      dbo.qJob_BillDetail ON dbo.Job_Order.BranchCode = dbo.qJob_BillDetail.BranchCode AND dbo.Job_Order.JNo = dbo.qJob_BillDetail.JobNo
WHERE     (dbo.qJob_BillDetail.GLAccountCodeSales IS NOT NULL) AND (dbo.qJob_BillDetail.CancelReson = '') OR
                      (dbo.qJob_BillDetail.CancelReson IS NULL)
GROUP BY dbo.qJob_BillDetail.GLAccountCodeSales, dbo.qJob_BillDetail.ProcessDesc, dbo.Job_Order.JNo

GO
/****** Object:  View [dbo].[qJob_Detail]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_Detail]
AS
SELECT     dbo.Mas_Branch.Code AS BRCode, dbo.Mas_Branch.BrName, dbo.Job_Order.BranchCode, dbo.Job_Order.JNo, dbo.Job_Order.JRevise, dbo.Job_Order.ConfirmDate, 
                      dbo.Job_Order.CPolicyCode, dbo.Job_Order.DocDate, dbo.Job_Order.CustCode, dbo.Job_Order.CustBranch, dbo.Job_Order.CustContactName, dbo.Job_Order.QNo, 
                      dbo.Job_Order.Revise, dbo.Job_Order.ManagerCode, dbo.Job_Order.CSCode, dbo.Job_Order.Description, dbo.Job_Order.TRemark, dbo.Job_Order.JobStatus, 
                      dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, dbo.Job_Order.InvNo, dbo.Job_Order.InvTotal, dbo.Job_Order.InvProduct, dbo.Job_Order.InvCountry, 
                      dbo.Job_Order.InvFCountry, dbo.Job_Order.InvInterPort, dbo.Job_Order.InvProductQty, dbo.Job_Order.InvProductUnit, dbo.Job_Order.InvCurUnit, 
                      dbo.Job_Order.InvCurRate, dbo.Job_Order.ImExDate, dbo.Job_Order.BLNo, dbo.Job_Order.BookingNo, dbo.Job_Order.ClearPort, dbo.Job_Order.ClearPortNo, 
                      dbo.Job_Order.ClearDate, dbo.Job_Order.LoadDate, dbo.Job_Order.ForwarderCode, dbo.Job_Order.AgentCode, dbo.Job_Order.VesselName, dbo.Job_Order.ETDDate, 
                      dbo.Job_Order.ETADate, dbo.Job_Order.ETTime, dbo.Job_Order.FNetPrice, dbo.Job_Order.BNetPrice, dbo.Job_Order.CancelReson, dbo.Job_Order.CancelDate, 
                      dbo.Job_Order.CancelTime, dbo.Job_Order.CancelProve, dbo.Job_Order.CancelProveDate, dbo.Job_Order.CancelProveTime, dbo.Job_Order.CloseJobDate, 
                      dbo.Job_Order.CloseJobTime, dbo.Job_Order.CloseJobBy, dbo.Job_Order.DeclareType, dbo.Job_Order.DeclareNumber, dbo.Job_Order.DeclareStatus, 
                      dbo.Job_Order.TyAuthorSp, dbo.Job_Order.Ty19BIS, dbo.Job_Order.TyClearTax, dbo.Job_Order.TyClearTaxReson, dbo.Job_Order.EstDeliverDate, 
                      dbo.Job_Order.EstDeliverTime, dbo.Job_Order.TotalContainer, dbo.Job_Order.DutyDate, dbo.Job_Order.DutyAmount, dbo.Job_Order.DutyCustPayOther, 
                      dbo.Job_Order.DutyCustPayChqAmt, dbo.Job_Order.DutyCustPayBankAmt, dbo.Job_Order.DutyCustPayEPAYAmt, dbo.Job_Order.DutyCustPayCardAmt, 
                      dbo.Job_Order.DutyCustPayCashAmt, dbo.Job_Order.DutyCustPayOtherAmt, dbo.Job_Order.DutyLtdPayOther, dbo.Job_Order.DutyLtdPayChqAmt, 
                      dbo.Job_Order.DutyLtdPayEPAYAmt, dbo.Job_Order.DutyLtdPayCashAmt, dbo.Job_Order.DutyLtdPayOtherAmt, dbo.Job_Order.ConfirmChqDate, 
                      dbo.Job_Order.ShippingEmp, dbo.Job_Order.ShippingCmd, dbo.Job_Order.TotalGW, dbo.Job_Order.GWUnit, dbo.Job_Order.TSRequest, dbo.Job_Order.ShipmentType, 
                      dbo.Job_Order.ReadyToClearDate, dbo.Job_Order.Commission, dbo.Job_Order.CommPayTo, dbo.Job_Order.ProjectName, dbo.Job_Order.MVesselName, 
                      dbo.Job_Order.TotalNW, dbo.Job_Order.Measurement, dbo.Job_Order.CustRefNO, dbo.Job_Order.TotalQty, dbo.Job_Order.HAWB, dbo.Job_Order.MAWB, 
                      dbo.Job_Order.consigneecode, dbo.Job_Order.privilegests, dbo.Job_Detail.STCode, dbo.Job_Detail.SICode, dbo.Job_Detail.SDescription, dbo.Job_Detail.SRemark, 
                      dbo.Job_Detail.VenderCode, dbo.Job_Detail.VenderContact, dbo.Job_Detail.EmpCode, dbo.Job_Detail.Start, dbo.Job_Detail.CY, dbo.Job_Detail.Endding, 
                      dbo.Job_Detail.DNNo, dbo.Job_Detail.PdtType, dbo.Job_Detail.Qty, dbo.Job_Detail.UnitCode, dbo.Job_Detail.CurrencyCode, dbo.Job_Detail.CurRate, 
                      dbo.Job_Detail.FPrice, dbo.Job_Detail.BPrice, dbo.Job_Detail.QUnitPrice, dbo.Job_Detail.QFPrice, dbo.Job_Detail.QBPrice, dbo.Job_Detail.UnitCost, 
                      dbo.Job_Detail.FCost, dbo.Job_Detail.BCost, dbo.Job_Detail.Tax50Tavi, dbo.Job_Detail.BillExtn, dbo.Job_Detail.ChargeDate, dbo.Job_Detail.IsQuoItem, 
                      dbo.Job_Detail.ProductName, dbo.Job_Detail.AirQtyStep, dbo.Job_Detail.StepSub, dbo.Mas_Agent.TName AS AgentName, dbo.Mas_RFICC.CountryName, 
                      dbo.Mas_RFARS.AreaName, dbo.Mas_User.TName AS SalesName, dbo.Mas_Company.CustGroup, 
                      dbo.Mas_Company.Title + ' ' + dbo.Mas_Company.NameThai AS CustName, dbo.Mas_ServUnitType.IsCTNUnit, 
                      dbo.Job_Order.CustCode + '-' + dbo.Job_Order.CustBranch AS CustID, dbo.Job_Detail.RSlipNO, dbo.Job_Detail.ClearingNO, dbo.Job_SrvSingle.ProcessDesc, 
                      dbo.Job_SrvSingle.GLAccountCodeSales, dbo.Job_SrvSingle.GLAccountCodeCost
FROM         dbo.Job_SrvSingle INNER JOIN
                      dbo.Job_Detail ON dbo.Job_SrvSingle.SICode = dbo.Job_Detail.SICode RIGHT OUTER JOIN
                      dbo.Job_Order ON dbo.Job_Detail.JNo = dbo.Job_Order.JNo AND dbo.Job_Detail.BranchCode = dbo.Job_Order.BranchCode LEFT OUTER JOIN
                      dbo.Mas_Branch ON dbo.Job_Order.BranchCode = dbo.Mas_Branch.Code LEFT OUTER JOIN
                      dbo.Mas_User ON dbo.Job_Order.ManagerCode = dbo.Mas_User.UserID LEFT OUTER JOIN
                      dbo.Mas_Agent ON dbo.Job_Order.AgentCode = dbo.Mas_Agent.Code LEFT OUTER JOIN
                      dbo.Mas_Company ON dbo.Job_Order.CustBranch = dbo.Mas_Company.Branch AND dbo.Job_Order.CustCode = dbo.Mas_Company.CustCode LEFT OUTER JOIN
                      dbo.Mas_RFARS ON dbo.Job_Order.ClearPort = dbo.Mas_RFARS.AreaCode LEFT OUTER JOIN
                      dbo.Mas_RFICC ON dbo.Job_Order.InvCountry = dbo.Mas_RFICC.CountryCode LEFT OUTER JOIN
                      dbo.Mas_ServUnitType ON dbo.Job_Detail.UnitCode = dbo.Mas_ServUnitType.UnitType

GO
/****** Object:  View [dbo].[Q_ProfitCost]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Q_ProfitCost]
AS
SELECT     dbo.Job_SrvSingle.GLAccountCodeCost, dbo.Job_SrvSingle.ProcessDesc, ISNULL(SUM(dbo.qJob_Detail.UnitCost), 0) AS AdvCost, dbo.Job_Order.JNo, 
                      dbo.qJob_Detail.SICode
FROM         dbo.Job_Order INNER JOIN
                      dbo.qJob_Detail ON dbo.Job_Order.BranchCode = dbo.qJob_Detail.BranchCode AND dbo.Job_Order.JNo = dbo.qJob_Detail.JNo INNER JOIN
                      dbo.Job_SrvSingle ON dbo.qJob_Detail.SICode = dbo.Job_SrvSingle.SICode
GROUP BY dbo.Job_SrvSingle.GLAccountCodeCost, dbo.Job_SrvSingle.ProcessDesc, dbo.qJob_Detail.UnitCost, dbo.Job_Order.JNo, dbo.qJob_Detail.SICode

GO
/****** Object:  View [dbo].[Q_CostJoinProfit]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Q_CostJoinProfit]
AS
SELECT     dbo.Job_Order.BranchCode, dbo.Job_Order.JNo, CONVERT(date, dbo.Job_Order.DocDate) AS JobDate, dbo.Job_Order.CPolicyCode, dbo.Job_Order.CSCode, 
                      dbo.Job_Order.CustCode, dbo.Job_Order.CustBranch, Mas_Customers.TaxNumber AS CustTaxNumber, Mas_Customers.NameEng AS CustName, 
                      Mas_Consignee.CustCode AS ConsignCode, Mas_Consignee.Branch AS ConsignBranch, Mas_Consignee.TaxNumber AS ConsignTaxNumber, 
                      Mas_Consignee.NameEng AS ConsignName, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, CONVERT(date, dbo.Job_Order.ETDDate) 
                      AS ETDDate, CONVERT(date, dbo.Job_Order.ETADate) AS ETADate, dbo.Job_Order.MAWB, dbo.Job_Order.HAWB,
                          (SELECT     COUNT(JobBillAmt) AS BiilingAmt
                            FROM          dbo.Job_BillingHeader
                            WHERE      (JobNo = dbo.Job_Order.JNo) AND (BranchCode = dbo.Job_Order.BranchCode)) AS LastBiiling,
                          (SELECT     ISNULL(SUM(TotalAmt), 0) AS Dee
                            FROM          dbo.Q_ProfitSales AS Q_ProfitSales_1
                            WHERE      (GLAccountCodeSales = '50000') AND (JNo = dbo.Job_Order.JNo)) AS Sales_DS,
                          (SELECT     ISNULL(SUM(TotalAmt), 0) AS Dee
                            FROM          dbo.Q_ProfitSales AS Q_ProfitSales_2
                            WHERE      (GLAccountCodeSales = '50010') AND (JNo = dbo.Job_Order.JNo)) AS Sales_DSR,
                          (SELECT     ISNULL(SUM(TotalAmt), 0) AS Dee
                            FROM          dbo.Q_ProfitSales AS Q_ProfitSales_3
                            WHERE      (GLAccountCodeSales = '50020') AND (JNo = dbo.Job_Order.JNo)) AS Sales_OS,
                          (SELECT     ISNULL(SUM(TotalAmt), 0) AS Dee
                            FROM          dbo.Q_ProfitSales AS Q_ProfitSales_4
                            WHERE      (GLAccountCodeSales = '50030') AND (JNo = dbo.Job_Order.JNo)) AS Sales_OSR,
                          (SELECT     ISNULL(SUM(TotalAmt), 0) AS Dee
                            FROM          dbo.Q_ProfitSales AS Q_ProfitSales_1
                            WHERE      (JNo = dbo.Job_Order.JNo)) AS SubTotal_Sales,
                          (SELECT     ISNULL(SUM(AdvCost), 0) AS dsr
                            FROM          dbo.Q_ProfitCost
                            WHERE      (ProcessDesc = 'DS') AND (JNo = dbo.Job_Order.JNo)) AS Cost_DS,
                          (SELECT     ISNULL(SUM(AdvCost), 0) AS dsr
                            FROM          dbo.Q_ProfitCost AS Q_ProfitCost_5
                            WHERE      (ProcessDesc = 'DSR') AND (JNo = dbo.Job_Order.JNo)) AS Cost_DSR,
                          (SELECT     ISNULL(SUM(AdvCost), 0) AS dsr
                            FROM          dbo.Q_ProfitCost AS Q_ProfitCost_3
                            WHERE      (ProcessDesc = 'OS') AND (JNo = dbo.Job_Order.JNo)) AS Cost_OS,
                          (SELECT     ISNULL(SUM(AdvCost), 0) AS dsr
                            FROM          dbo.Q_ProfitCost AS Q_ProfitCost_2
                            WHERE      (ProcessDesc = 'OSR') AND (JNo = dbo.Job_Order.JNo)) AS Cost_OSR,
                          (SELECT     ISNULL(SUM(AdvCost), 0) AS Dee
                            FROM          dbo.Q_ProfitCost AS Q_ProfitCost_1
                            WHERE      (JNo = dbo.Job_Order.JNo)) AS SubTotal_Cost, CONVERT(date, dbo.Job_Order.ConfirmDate) AS ConfirmDate
FROM         dbo.Mas_Company AS Mas_Customers INNER JOIN
                      dbo.Job_Order ON Mas_Customers.CustCode = dbo.Job_Order.CustCode AND Mas_Customers.Branch = dbo.Job_Order.CustBranch INNER JOIN
                      dbo.Mas_Company AS Mas_Consignee ON dbo.Job_Order.consigneecode = Mas_Consignee.CustCode

GO
/****** Object:  View [dbo].[vAdv_Balance]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vAdv_Balance] AS SELECT  dbo.Job_AdvHeader.AdvNo, dbo.Job_AdvHeader.PaymentDate, dbo.Job_AdvHeader.PaymentBy,dbo.Job_AdvHeader.AdvCash,dbo.Job_AdvHeader.AdvChqCash,dbo.Job_AdvHeader.AdvChq,dbo.Job_AdvHeader.AdvCash + dbo.Job_AdvHeader.AdvChqCash + dbo.Job_AdvHeader.AdvChq AS TotalAdvance,SUM(ISNULL(dbo.qJob_ClearDetail.UsedAmount, 0)) AS TotalClear, dbo.qJob_ClearDetail.DocStatus FROM         dbo.qJob_ClearDetail RIGHT OUTER JOIN dbo.Job_AdvHeader ON dbo.qJob_ClearDetail.AdvNO = dbo.Job_AdvHeader.AdvNo WHERE     (dbo.Job_AdvHeader.DocStatus <> 99) GROUP BY dbo.Job_AdvHeader.AdvNo, dbo.Job_AdvHeader.PaymentDate,dbo.Job_AdvHeader.AdvCash , dbo.Job_AdvHeader.AdvChqCash ,dbo.Job_AdvHeader.AdvChq,dbo.Job_AdvHeader.PaymentBy,dbo.qJob_ClearDetail.DocStatus
GO
/****** Object:  View [dbo].[qGL_SetAR]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[qGL_SetAR]
as
with gl
as (
/*-------------------------------------------------------
???? ??????????????? ???????????
	Dr. 1130-01	?????????????     (qJob_TaxInvDetail.AmtCharge+qJob_TaxInvDetail.AmtVAT-qJob_TaxInvDetail.Amt50Tavi)
        Cr.4100-02	?????????????????????    (qJob_TaxInvDetail.AmtCharge-Amt50Tavi)
		   4100-15	??????????????    (qJob_TaxInvDetail.AmtCharge-Amt50Tavi) 
		   2135-00	???????    (qJob_TaxInvDetail.AmtVAT)
-------------------------------------------------------*/
	select DocNo as BillingNo,'1130-01' as GType,Sum(AmtCharge+(CASE WHEN IsTaxCharge=1 then AmtCharge*0.07 else 0 end)) as Amt,'D' as ACType,'S' as ARType 
	from qJob_BillDetail where SICode not in(SELECT SICode FROM Job_SrvSingle WHERE GLAccountCodeCost='4200-09') 
	and Not CancelProve<>''
	group by DocNo
	union
	select DocNo,'4100-02',SUM(AmtCharge),'C','S' from qJob_BillDetail where Not CancelProve<>''
	and SICode Not in (SELECT SICode FROM Job_SrvSingle WHERE GLAccountCodeCost IN('4200-09','4100-15'))
	group by DocNo
	union
	select DocNo,'4100-15',SUM(AmtCharge),'C','S' from qJob_BillDetail where Not CancelProve<>''
	and SICode in (SELECT SICode FROM Job_SrvSingle WHERE GLAccountCodeCost IN('4100-15')) 
	group by DocNo	
	union	
	select DocNo,'2135-00',Sum(AmtCharge*0.07),'C','S' from qJob_BillDetail where Not Cancelprove<>'' 
	And IsTaxCharge=1 And Amtcharge>0 
	and SICode not in(SELECT SICode FROM Job_SrvSingle WHERE GLAccountCodeCost='4200-09')
	group by DocNo
/*-----------------------------------------------------
  ???? ????????
	Dr. 1153-03 ?????????????????????    (qJob_TaxInvDetail.AmtCharge-qJob_TaxInvDetail.Amt50Tavi)
		1151-13	????????????????? ? ???????	 (qJob_TaxInvDetail.Amt50Tavi)
	    Cr. 4200-09	??????????????    (qJob_TaxInvDetail.AmtCharge)
-------------------------------------------------------*/
	union
	select DocNo,'1153-03',Sum(AmtCharge-(CASE WHEN Is50Tavi=1 THEN AmtCharge*0.01 ELSE 0 END)),'D','T' 
	from qJob_BillDetail where Not CancelProve<>'' And Amtcharge>0
	and SICode in(SELECT SICode FROM Job_SrvSingle WHERE GLAccountCodeCost='4200-09') 
	group by DocNo
	union
	select DocNo,'1151-13',SUM(AmtCharge*0.01),'D','T' from qJob_BillDetail 
	where Not CancelProve<>'' and Is50Tavi=1 
	And SICode in(SELECT SICode FROM Job_SrvSingle WHERE GLAccountCodeCost='4200-09') 
	group by DocNo
	union
	select DocNo,'4200-09',SUM(AmtCharge),'C','T' from qJob_BillDetail where Not CancelProve<>''
	and SICode in (SELECT SICode FROM Job_SrvSingle WHERE GLAccountCodeCost IN('4200-09'))
	group by DocNo	
/*-------------------------------------------------------
???? ????????????? ??? ????????????????? ???????????????????
	Dr. 1130-10	??????????????????????   (Job_BillingHeader.TotalAdvance-TotalCustAdv)
		1130-11	???????????????	   (Job_BillingHeader.TotalCustAdv)
		Cr. 1111-00	??????		   (Job_BillingHeader.TotalAdvance)
				
-------------------------------------------------------*/
	union
	select DocNo,'1130-11',SUM(TotalCustAdv),'D','S' from Job_BillingHeader where TotalCustAdv>0 
	And TotalAdvance >=TotalCustAdv 
	and Not CancelProve <>'' group by DocNo
	union
	select DocNo,'1130-10',SUM(TotalAdvance-TotalCustAdv),'D','S' from Job_BillingHeader where TotalAdvance>0 
	And TotalAdvance >=TotalCustAdv 
	and Not CancelProve <>'' group by DocNo
	union
	select DocNo,'1111-00',SUM(TotalAdvance),'C','S' from Job_BillingHeader where TotalAdvance>0 
	And TotalAdvance >=TotalCustAdv 
	and Not CancelProve <>'' group by DocNo
	union
	--?????????????????????????????????????????????????? ????????????????????
	select DocNo,'1130-01',SUM(TotalCustAdv*-1),'D','S' from Job_BillingHeader where TotalCustAdv>0 
	And TotalAdvance <TotalCustAdv and TotalCharge > TotalCustAdv 
	and Not CancelProve <>'' group by DocNo
	union
	select DocNo,'1130-11',SUM(TotalCustAdv),'D','S' from Job_BillingHeader where TotalCustAdv>0 
	And TotalAdvance <TotalCustAdv and TotalCharge > TotalCustAdv 
	and Not CancelProve <>'' group by DocNo
	---????????????????????????????????????????????
	union
	select DocNo,'1111-00',SUM(TotalCustAdv+TotalNet+Total50Tavi1+Total50Tavi2),'C','S' from Job_BillingHeader 
	where Not CancelProve<>'' And (TotalCharge+TotalAdvance)<TotalCustAdv and TotalCustAdv>TotalAdvance 
	group by DocNo
	union
	select DocNo,'1130-10',ABS(SUM(TotalNet+Total50Tavi1+Total50Tavi2)),'C','S' from Job_BillingHeader 
	where Not CancelProve<>'' and (TotalCharge+TotalAdvance)<TotalCustAdv and TotalCustAdv>TotalAdvance 
	group by docNo
	union
	select DocNo,'1130-11',SUM(TotalCustAdv),'D','S' from Job_BillingHeader where TotalCustAdv>TotalAdvance 
	And (TotalAdvance + TotalCharge) < TotalCustAdv 
	and Not CancelProve <>'' group by docNo

)
select t.BillingNo,t.GType,SUM(t.Amt) as Total,t.ACType,t.ARType
,sum(case when t.ACType='D' then t.Amt else 0 end) as DEBIT
,sum(case when t.ACType='C' then t.Amt else 0 end) as CREDIT
from
(
	select * from 
	 gl
) as t
where t.Amt<>0
group by t.BillingNo,t.GType,t.ACType,t.ARType 
having sum(t.Amt)<>0
GO
/****** Object:  View [dbo].[Q_TaxExport]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[Q_TaxExport]
AS
SELECT     dbo.Job_BillingHeader.BranchCode, dbo.Job_BillingHeader.DocNo as BillingNo, 
			CONVERT(date, dbo.Job_BillingHeader.DocDate) AS BillingDate, 
			dbo.Job_TaxInvoice.InvNo as TaxInvNo,
			CONVERT(date, dbo.Job_TaxInvoice.InvDate) AS TaxInvDate, 
                      dbo.Job_BillingHeader.CustCode, dbo.Job_BillingHeader.CustBranch, 
					  dbo.Mas_Company.TaxNumber, dbo.Mas_Company.NameThai, 
                      dbo.Job_BillingHeader.CancelReson, 
					  dbo.qGL_SetAR.GType, ROUND(ISNULL(dbo.qGL_SetAR.Total, 0), 2) AS NetAmt, 
					  dbo.qGL_SetAR.ACType, dbo.qGL_SetAR.ARType, 
					  ROUND(ISNULL(dbo.qGL_SetAR.DEBIT, 0), 2) AS DEBIT, 
					  ROUND(ISNULL(dbo.qGL_SetAR.CREDIT, 0), 2) AS CREDIT, 
					  dbo.MAS_GLACCOUNT.GLCostCode, dbo.MAS_GLACCOUNT.GLCostName,
					  dbo.Job_BillingHeader.JobNo 
FROM        dbo.qGL_SetAR INNER JOIN dbo.Job_BillingHeader 
			on dbo.qGL_SetAR.BillingNo=dbo.Job_BillingHeader.DocNo 
			INNER JOIN
                    dbo.Mas_Company ON dbo.Job_BillingHeader.CustCode = dbo.Mas_Company.CustCode AND 
                    dbo.Job_BillingHeader.CustBranch = dbo.Mas_Company.Branch INNER JOIN                      
                    dbo.MAS_GLACCOUNT ON dbo.qGL_SetAR.GType = dbo.MAS_GLACCOUNT.GLCostCode
			LEFT OUTER JOIN
                      dbo.Job_TaxInvoice ON dbo.Job_BillingHeader.TaxInvNo = dbo.Job_TaxInvoice.InvNo
WHERE dbo.qGL_SetAR.Total <>0
GO
/****** Object:  View [dbo].[Q_VouherStateTwo]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Q_VouherStateTwo]
AS
SELECT     dbo.qJob_CashControl.BranchCode, dbo.qJob_CashControl.ControlNo, dbo.qJob_CashControl.PRVoucher, dbo.Job_CashControlDoc.DocNo, 
                      dbo.qJob_CashControl.PRType, ROUND(ISNULL(dbo.qJob_CashControl.CashAmount, 0), 2) AS CashAmount, 
                      ROUND(ISNULL(dbo.qJob_CashControl.ChqAmount, 0), 2) AS ChqAmount, ROUND(ISNULL(dbo.qJob_CashControl.CreditAmount, 0), 2) AS CreditAmount, 
                      ROUND(ISNULL(dbo.qJob_CashControl.CashAmount + dbo.qJob_CashControl.ChqAmount + dbo.qJob_CashControl.CreditAmount, 0), 2) 
                      AS PaymentTotal, ROUND(ISNULL(dbo.Job_CashControlDoc.TotalAmount, 0), 2) AS TotalDocAmt
FROM         dbo.qJob_CashControl INNER JOIN
                      dbo.Job_CashControlDoc ON dbo.qJob_CashControl.BranchCode = dbo.Job_CashControlDoc.BranchCode AND 
                      dbo.qJob_CashControl.ControlNo = dbo.Job_CashControlDoc.ControlNo

GO
/****** Object:  View [dbo].[Q_PaymentRef]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Q_PaymentRef]
AS
SELECT     dbo.Job_CashControl.BranchCode, dbo.Job_CashControl.ControlNo, dbo.Job_CashControlSub.PRVoucher, dbo.Job_CashControl.VoucherDate, 
                      dbo.Job_CashControlDoc.DocNo, dbo.Job_CashControl.RecUser AS UserPvocher
FROM         dbo.Job_CashControl INNER JOIN
                      dbo.Job_CashControlSub ON dbo.Job_CashControl.BranchCode = dbo.Job_CashControlSub.BranchCode AND 
                      dbo.Job_CashControl.ControlNo = dbo.Job_CashControlSub.ControlNo INNER JOIN
                      dbo.Job_CashControlDoc ON dbo.Job_CashControlSub.BranchCode = dbo.Job_CashControlDoc.BranchCode AND 
                      dbo.Job_CashControlSub.ControlNo = dbo.Job_CashControlDoc.ControlNo


GO
/****** Object:  View [dbo].[Q_VouherStateOne]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Q_VouherStateOne]
AS
SELECT     [BranchCode] AS BranchCode, [ClrNo] AS DocNo, [ClrDate] AS DocDate, [EmpCode] AS UserCode, [JNo] AS JobNo, [CancelReson] AS IsDocCancel, 
                      AdvTotal AS AdvAmt, isnull(TotalExpense, 0) AS UsedAmt
FROM         [Job_ClearHeader]
UNION
SELECT     [BranchCode] AS BranchCode, [AdvNo] AS DocNo, [AdvDate] AS DocDate, [EmpCode] AS UserCode, [JNo] AS JobNo, [CancelReson] AS IsDocCancel, 
                      isnull((TotalAdvance+TotalVAT)-Total50Tavi,0) AS AdvAmt, 0 AS UsedAmt
FROM         [Job_AdvHeader]
UNION
SELECT     [BranchCode] AS BranchCode, [DocNo] AS DocNo, [DocDate] AS DocDate, [EmpCode] AS UserCode, [JobNo] AS JobNo, [CancelReson] AS IsDocCancel, 
                      0 AS AdvAmt, 0 AS UsedAmt
FROM         [Job_BillingHeader]

GO
/****** Object:  View [dbo].[Q_StatementAccount]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[Q_StatementAccount]
AS
SELECT        dbo.qJob_CashControl.BranchCode, dbo.qJob_CashControl.ControlNo, dbo.Q_PaymentRef.PRVoucher, CONVERT(date, dbo.Q_PaymentRef.VoucherDate) AS VoucherDate, CONVERT(date, dbo.Job_Order.ConfirmDate) 
                         AS JobStatusDate, CONVERT(date, dbo.Job_Order.DocDate) AS JobDate, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, dbo.Job_Order.CustBranch, dbo.Job_Order.CustCode, 
                         dbo.Q_VouherStateOne.JobNo, dbo.Q_PaymentRef.DocNo, dbo.Job_CashControlDoc.DocType, CONVERT(date, dbo.Q_VouherStateOne.DocDate) AS DocDate, dbo.Q_VouherStateOne.IsDocCancel, 
                         dbo.Q_PaymentRef.UserPvocher, dbo.qJob_CashControl.BookCode, dbo.qJob_CashControl.PRType, ROUND(ISNULL(SUM(dbo.Q_VouherStateOne.AdvAmt), 0), 2) AS AdvanceAmt, 
                         ROUND(ISNULL(SUM(dbo.Q_VouherStateOne.UsedAmt), 0), 2) AS ClearingAmt, ISNULL
                             ((SELECT        ISNULL(SUM(TotalDocAmt), 0) AS A
                                 FROM            dbo.Q_VouherStateTwo
                                 WHERE        (ControlNo = dbo.Q_PaymentRef.ControlNo) AND (DocNo = dbo.Q_PaymentRef.DocNo) AND (PRType = 'P')), 0) AS TotalPayMent, ISNULL
                             ((SELECT        ISNULL(SUM(TotalDocAmt), 0) AS A
                                 FROM            dbo.Q_VouherStateTwo AS Q_VouherStateTwo_1
                                 WHERE        (ControlNo = dbo.Q_PaymentRef.ControlNo) AND (DocNo = dbo.Q_PaymentRef.DocNo) AND (PRType = 'R')), 0) AS TotalRecieve, CONVERT(date, dbo.qJob_CashControl.ChqDate) AS DEPODate, 
                         dbo.Mas_BookAccount.BookName, dbo.Mas_BookAccount.BankCode, dbo.Mas_BookAccount.BankBranch, dbo.Mas_BookAccount.ACType
FROM            dbo.qJob_CashControl INNER JOIN
                         dbo.Q_PaymentRef ON dbo.qJob_CashControl.ControlNo = dbo.Q_PaymentRef.ControlNo AND dbo.qJob_CashControl.BranchCode = dbo.Q_PaymentRef.BranchCode INNER JOIN
                         dbo.Q_VouherStateOne ON dbo.Q_PaymentRef.BranchCode = dbo.Q_VouherStateOne.BranchCode AND dbo.Q_PaymentRef.DocNo = dbo.Q_VouherStateOne.DocNo INNER JOIN
                         dbo.Job_Order ON dbo.Q_VouherStateOne.BranchCode = dbo.Job_Order.BranchCode AND dbo.Q_VouherStateOne.JobNo = dbo.Job_Order.JNo INNER JOIN
                         dbo.Job_CashControlDoc ON dbo.Q_PaymentRef.BranchCode = dbo.Job_CashControlDoc.BranchCode AND dbo.Q_PaymentRef.DocNo = dbo.Job_CashControlDoc.DocNo INNER JOIN
                         dbo.Mas_BookAccount ON dbo.qJob_CashControl.BookCode = dbo.Mas_BookAccount.BookCode
WHERE        (dbo.qJob_CashControl.CancelReson = '')
GROUP BY dbo.qJob_CashControl.ControlNo, dbo.Q_PaymentRef.ControlNo, dbo.Q_PaymentRef.DocNo, dbo.qJob_CashControl.BranchCode, dbo.qJob_CashControl.ControlNo, dbo.Q_PaymentRef.PRVoucher, 
                         dbo.Q_PaymentRef.VoucherDate, dbo.Job_Order.ConfirmDate, dbo.qJob_CashControl.ChqDate, dbo.Job_Order.DocDate, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, dbo.Job_Order.CustBranch, 
                         dbo.Job_Order.CustCode, dbo.Q_VouherStateOne.JobNo, dbo.Q_PaymentRef.DocNo, dbo.Job_CashControlDoc.DocType, dbo.Q_VouherStateOne.DocDate, dbo.Q_VouherStateOne.IsDocCancel, dbo.Q_PaymentRef.UserPvocher, 
                         dbo.qJob_CashControl.BookCode, dbo.qJob_CashControl.PRType, dbo.Q_VouherStateOne.AdvAmt, dbo.Q_VouherStateOne.UsedAmt, dbo.Mas_BookAccount.BookName, dbo.Mas_BookAccount.BankCode, 
                         dbo.Mas_BookAccount.BankBranch, dbo.Mas_BookAccount.ACType


GO
/****** Object:  View [dbo].[View_RefClr]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_RefClr]
AS
SELECT     dbo.qJob_ClearDetail.BranchCode, dbo.qJob_ClearDetail.JNo, dbo.qJob_ClearDetail.AdvRefNo, dbo.qJob_ClearDetail.ClrNo, 
                      dbo.qJob_ClearDetail.ClrDate, dbo.qJob_ClearDetail.ClearType, dbo.qJob_ClearDetail.ClearFrom, dbo.qJob_ClearDetail.DocStatus, 
                      dbo.qJob_ClearDetail.SICode, dbo.qJob_ClearDetail.UnitPrice, dbo.qJob_ClearDetail.UnitCost, dbo.qJob_ClearDetail.ChargeVAT, 
                      dbo.qJob_ClearDetail.Tax50Tavi, dbo.qJob_ClearDetail.AdvAmount, dbo.qJob_ClearDetail.UsedAmount, dbo.qJob_CashControl.ControlNo, 
                      dbo.qJob_CashControl.PRVoucher, dbo.qJob_CashControl.VoucherDate, dbo.qJob_CashControl.RecUser, dbo.qJob_ClearDetail.ReceiveRef, 
                      dbo.qJob_CashControl.UserName
FROM         dbo.qJob_ClearDetail LEFT OUTER JOIN
                      dbo.qJob_CashControl ON dbo.qJob_ClearDetail.BranchCode = dbo.qJob_CashControl.BranchCode AND 
                      dbo.qJob_ClearDetail.ReceiveRef = dbo.qJob_CashControl.PRVoucher


GO
/****** Object:  View [dbo].[QE_QuotationHeader]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[QE_QuotationHeader]
AS
SELECT     dbo.Job_QuoHeader.BranchCode, dbo.Job_Order.JNo, dbo.Job_QuoHeader.QNo, dbo.Job_QuoHeader.Revise, dbo.Job_QuoHeader.ReferQNo, 
                      dbo.Job_QuoHeader.CustCode, dbo.Job_QuoHeader.CustBranch, dbo.Job_QuoHeader.BillToCustCode, dbo.Job_QuoHeader.BillToCustBranch, 
                      dbo.Job_QuoHeader.ContactName, dbo.Job_QuoHeader.DocDate, dbo.Job_QuoHeader.ManagerCode, dbo.Job_QuoHeader.DescriptionH, 
                      dbo.Job_QuoHeader.DescriptionF, dbo.Job_QuoHeader.TRemark, dbo.Job_QuoHeader.ApproveBy, dbo.Job_QuoHeader.ApproveDate, 
                      dbo.Job_QuoHeader.ApproveTime, dbo.Job_QuoHeader.ExchageRate
FROM         dbo.Job_QuoHeader INNER JOIN
                      dbo.Job_Order ON dbo.Job_QuoHeader.QNo = dbo.Job_Order.QNo AND dbo.Job_QuoHeader.Revise = dbo.Job_Order.Revise



GO
/****** Object:  View [dbo].[QE_QuoDetailItem]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[QE_QuoDetailItem]
AS
SELECT     dbo.QE_QuotationHeader.BranchCode, dbo.QE_QuotationHeader.JNo, dbo.Job_QuoDetailItem.QNo, dbo.Job_QuoDetailItem.Revise, dbo.Job_QuoDetailItem.LinkItem, 
                      dbo.Job_QuoDetailItem.ItemNo, dbo.Job_QuoDetailItem.STCode, dbo.Job_QuoDetailItem.SICode, dbo.Job_QuoDetailItem.NameThai, 
                      dbo.Job_QuoDetailItem.VenderCode, dbo.Job_QuoDetailItem.UnitCharge, dbo.Job_QuoDetailItem.UnitPrice, dbo.Job_QuoDetailItem.CurrencyCode, 
                      dbo.Job_QuoDetailItem.Start, dbo.Job_QuoDetailItem.Endding, dbo.Job_QuoDetailItem.CY, dbo.Job_QuoDetailItem.QtyStep, dbo.Job_QuoDetailItem.StepSub, 
                      dbo.Job_QuoDetailItem.IsPrintPrice, dbo.Job_QuoDetailItem.IsShowOnPrint, dbo.Job_QuoDetailItem.PrivoteType, dbo.Job_QuoDetailItem.UnitCost, 
                      dbo.Job_QuoDetailItem.UnitQTY, dbo.Job_QuoDetailItem.CurrencyRate, dbo.Job_QuoDetailItem.Isvat, dbo.Job_QuoDetailItem.VatRate, dbo.Job_QuoDetailItem.VatAmt, 
                      dbo.Job_QuoDetailItem.IsTax, dbo.Job_QuoDetailItem.TaxRate, dbo.Job_QuoDetailItem.TaxAmt, dbo.Job_QuoDetailItem.TotalAmt, dbo.Job_QuoDetailItem.CurrentTHB, 
                      dbo.Job_QuoDetailItem.UnitDiscntPerc, dbo.Job_QuoDetailItem.UnitDiscntAmt
FROM         dbo.QE_QuotationHeader INNER JOIN
                      dbo.Job_QuoDetailItem ON dbo.QE_QuotationHeader.BranchCode = dbo.Job_QuoDetailItem.BranchCode AND 
                      dbo.QE_QuotationHeader.QNo = dbo.Job_QuoDetailItem.QNo AND dbo.QE_QuotationHeader.Revise = dbo.Job_QuoDetailItem.Revise



GO
/****** Object:  View [dbo].[QE_QoutationDetail]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[QE_QoutationDetail]
AS
SELECT     dbo.QE_QuotationHeader.BranchCode, dbo.QE_QuotationHeader.JNo, dbo.Job_QuoDetail.QNo, dbo.Job_QuoDetail.Revise, dbo.Job_QuoDetail.ItemNo, 
                      dbo.Job_QuoDetail.LinkItem, dbo.Job_QuoDetail.Description, dbo.Job_QuoDetail.TotalPrice, dbo.Job_QuoDetail.UnitCode
FROM         dbo.QE_QuotationHeader INNER JOIN
                      dbo.Job_QuoDetail ON dbo.QE_QuotationHeader.BranchCode = dbo.Job_QuoDetail.BranchCode AND dbo.QE_QuotationHeader.QNo = dbo.Job_QuoDetail.QNo AND 
                      dbo.QE_QuotationHeader.Revise = dbo.Job_QuoDetail.Revise



GO
/****** Object:  View [dbo].[qJob_AdvHeader]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_AdvHeader]
AS
SELECT        dbo.Job_AdvHeader.BranchCode, dbo.Job_AdvHeader.AdvNo, dbo.Job_AdvHeader.JobType, dbo.Job_AdvHeader.AdvDate, dbo.Job_AdvHeader.AdvType, dbo.Job_AdvHeader.EmpCode, dbo.Job_AdvHeader.JNo, 
                         dbo.Job_AdvHeader.InvNo, dbo.Job_AdvHeader.DocStatus, dbo.Job_AdvHeader.VATRate, dbo.Job_AdvHeader.TotalAdvance, dbo.Job_AdvHeader.TotalVAT, dbo.Job_AdvHeader.Total50Tavi, dbo.Job_AdvHeader.TRemark, 
                         dbo.Job_AdvHeader.ApproveBy, dbo.Job_AdvHeader.ApproveDate, dbo.Job_AdvHeader.ApproveTime, dbo.Job_AdvHeader.PaymentBy, dbo.Job_AdvHeader.PaymentDate, dbo.Job_AdvHeader.PaymentTime, 
                         dbo.Job_AdvHeader.PaymentRef, dbo.Job_AdvHeader.CancelReson, dbo.Job_AdvHeader.CancelProve, dbo.Job_AdvHeader.CancelDate, dbo.Job_AdvHeader.CancelTime, dbo.Job_AdvHeader.AdvCash, 
                         dbo.Job_AdvHeader.AdvChqCash, dbo.Job_AdvHeader.AdvChq, dbo.Job_AdvHeader.AdvCred, dbo.Job_AdvHeader.PayChqTo, dbo.Job_AdvHeader.PayChqDate, dbo.Job_AdvHeader.Doc50Tavi, dbo.Job_AdvHeader.AdvBy, 
                         dbo.Job_AdvHeader.PaymentNo, dbo.Mas_User.TName AS UserName, dbo.Job_Order.CustCode, dbo.Job_Order.CustBranch, dbo.Mas_Company.NameThai AS CustName, dbo.Job_Order.TotalGW, dbo.Job_Order.GWUnit, 
                         dbo.Job_Order.TotalContainer, dbo.Job_Order.ShipBy, dbo.Job_Order.JobStatus
FROM            dbo.Job_AdvHeader LEFT OUTER JOIN
                         dbo.Mas_User ON dbo.Job_AdvHeader.EmpCode = dbo.Mas_User.UserID LEFT OUTER JOIN
                         dbo.Job_Order ON dbo.Job_AdvHeader.JNo = dbo.Job_Order.JNo AND dbo.Job_AdvHeader.BranchCode = dbo.Job_Order.BranchCode LEFT OUTER JOIN
                         dbo.Mas_Company ON dbo.Job_Order.CustBranch = dbo.Mas_Company.Branch AND dbo.Job_Order.CustCode = dbo.Mas_Company.CustCode
GO
/****** Object:  View [dbo].[qJob_ClearHeader]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[qJob_ClearHeader]
AS
SELECT     dbo.Job_ClearHeader.BranchCode, dbo.Job_ClearHeader.ClrNo, dbo.Job_ClearHeader.ClrDate, dbo.Job_ClearHeader.ClearanceDate, 
                      dbo.Job_ClearHeader.EmpCode, dbo.Job_ClearHeader.AdvRefNo, dbo.Job_ClearHeader.AdvTotal, dbo.Job_ClearHeader.JobType, 
                      dbo.Job_ClearHeader.JNo, dbo.Job_ClearHeader.InvNo, dbo.Job_ClearHeader.ClearType, dbo.Job_ClearHeader.ClearFrom, 
                      dbo.Job_ClearHeader.DocStatus, dbo.Job_ClearHeader.TotalExpense, dbo.Job_ClearHeader.TRemark, dbo.Job_ClearHeader.ApproveBy, 
                      dbo.Job_ClearHeader.ApproveDate, dbo.Job_ClearHeader.ApproveTime, dbo.Job_ClearHeader.ReceiveBy, dbo.Job_ClearHeader.ReceiveDate, 
                      dbo.Job_ClearHeader.ReceiveTime, dbo.Job_ClearHeader.ReceiveRef, dbo.Job_ClearHeader.CancelReson, dbo.Job_ClearHeader.CancelProve, 
                      dbo.Job_ClearHeader.CancelDate, dbo.Job_ClearHeader.CancelTime, dbo.Job_ClearHeader.CoPersonCode, dbo.Job_Order.QNo, 
                      dbo.Job_Order.Revise, dbo.Job_Order.CustCode, dbo.Job_Order.CustBranch, dbo.Mas_Company.NameThai AS CustName, 
                      dbo.Mas_User.TName AS CSName, dbo.Job_Order.DocDate AS JobDate, dbo.Job_Order.ShipBy
FROM         dbo.Job_ClearHeader LEFT OUTER JOIN
                      dbo.Job_Order ON dbo.Job_ClearHeader.BranchCode = dbo.Job_Order.BranchCode AND 
                      dbo.Job_ClearHeader.JNo = dbo.Job_Order.JNo LEFT OUTER JOIN
                      dbo.Mas_Company ON dbo.Job_Order.CustCode = dbo.Mas_Company.CustCode AND 
                      dbo.Job_Order.CustBranch = dbo.Mas_Company.Branch LEFT OUTER JOIN
                      dbo.Mas_User ON dbo.Job_ClearHeader.EmpCode = dbo.Mas_User.UserID




GO
/****** Object:  View [dbo].[vKPI_Advance]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vKPI_Advance]
AS
SELECT     a.AdvNo, a.AdvDate, a.EmpCode AS AdvBy, a.JNo, a.ApproveBy, a.ApproveDate, a.PaymentBy, a.PaymentDate, b.EmpCode AS ClrBy, b.ClrNo, 
                      b.ClrDate, b.ReceiveBy, b.ReceiveDate, DATEDIFF(D, b.ClrDate, a.PaymentDate) AS DaysClear, DATEDIFF(D, b.ReceiveDate, b.ClrDate) 
                      AS DaysAccReceive, a.TotalAdvance, dbo.Job_Order.CustCode, dbo.Job_Order.CSCode, a.JobType
FROM         dbo.qJob_AdvHeader AS a LEFT OUTER JOIN
                      dbo.Job_Order ON a.JNo = dbo.Job_Order.JNo LEFT OUTER JOIN
                      dbo.qJob_ClearHeader AS b ON a.AdvNo = b.AdvRefNo
WHERE     (a.DocStatus <> 99)

GO
/****** Object:  View [dbo].[vJob_VolumeByCust]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vJob_VolumeByCust]
AS
SELECT     YEAR(DocDate) AS JobYear, MONTH(DocDate) AS JobMonth, JobStatus, JobType, ShipBy, COUNT(JNo) AS CountJob, CustCode
FROM         dbo.qJob_Order
GROUP BY MONTH(DocDate), YEAR(DocDate), JobStatus, JobType, ShipBy, CustCode

GO
/****** Object:  View [dbo].[QE_UnionCashJob]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[QE_UnionCashJob]
AS
SELECT        [BranchCode] AS BranchCode, [JNo] AS JNo, [ClrNo] AS DocNo, [ClrDate] AS DocDate, [EmpCode] AS UserCode, [CancelReson] AS IsDocCancel
FROM            [Job_ClearHeader]
UNION
SELECT        [BranchCode] AS BranchCode, [JNo] AS JNo, [AdvNo] AS DocNo, [AdvDate] AS DocDate, [EmpCode] AS UserCode, [CancelReson] AS IsDocCancel
FROM            [Job_AdvHeader]
UNION
SELECT        [BranchCode] AS BranchCode, [JobNo] AS JNo, [DocNo] AS DocNo, [DocDate] AS DocDate, [EmpCode] AS UserCode, [CancelReson] AS IsDocCancel
FROM            [Job_BillingHeader]
UNION
SELECT        [BranchCode] AS BranchCode, [JNo] AS JNo, [DocNo] AS DocNo, [DocDate] AS DocDate, [EmpCode] AS UserCode, [CancelReson] AS IsDocCancel
FROM            [Job_PaymentHeader]


GO
/****** Object:  View [dbo].[QE_CashControlRefJob]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[QE_CashControlRefJob]
AS
SELECT        dbo.Job_CashControlDoc.BranchCode, dbo.QE_UnionCashJob.JNo, dbo.Job_CashControlDoc.ControlNo, dbo.Job_CashControlDoc.DocNo
FROM            dbo.Job_CashControlDoc INNER JOIN
                         dbo.QE_UnionCashJob ON dbo.Job_CashControlDoc.BranchCode = dbo.QE_UnionCashJob.BranchCode AND dbo.Job_CashControlDoc.DocNo = dbo.QE_UnionCashJob.DocNo


GO
/****** Object:  View [dbo].[vJob_Volume]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vJob_Volume]
AS
SELECT     YEAR(DutyDate) AS JobYear, MONTH(DutyDate) AS JobMonth, JobStatus, JobType, ShipBy, COUNT(JNo) AS CountJob, CSCode
FROM         dbo.qJob_Order
WHERE     (DutyDate IS NOT NULL)
GROUP BY MONTH(DutyDate), YEAR(DutyDate), JobStatus, JobType, ShipBy, CSCode

GO
/****** Object:  View [dbo].[QE_CashControlHeder]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[QE_CashControlHeder]
AS
SELECT DISTINCT 
                         dbo.Job_CashControl.BranchCode, dbo.QE_CashControlRefJob.JNo, dbo.Job_CashControl.ControlNo, dbo.Job_CashControl.VoucherDate, dbo.Job_CashControl.TRemark, dbo.Job_CashControl.RecUser, 
                         dbo.Job_CashControl.RecDate, dbo.Job_CashControl.RecTime, dbo.Job_CashControl.PostedBy, dbo.Job_CashControl.PostedDate, dbo.Job_CashControl.PostedTime, dbo.Job_CashControl.CancelReson, 
                         dbo.Job_CashControl.CancelProve, dbo.Job_CashControl.CancelDate, dbo.Job_CashControl.CancelTime
FROM            dbo.Job_CashControl INNER JOIN
                         dbo.QE_CashControlRefJob ON dbo.Job_CashControl.BranchCode = dbo.QE_CashControlRefJob.BranchCode AND dbo.Job_CashControl.ControlNo = dbo.QE_CashControlRefJob.ControlNo


GO
/****** Object:  View [dbo].[QE_CashControlSub]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[QE_CashControlSub]
AS
SELECT DISTINCT 
                         dbo.Job_CashControlSub.BranchCode, dbo.QE_CashControlRefJob.JNo, dbo.Job_CashControlSub.ControlNo, dbo.Job_CashControlSub.ItemNo, dbo.Job_CashControlSub.PRVoucher, dbo.Job_CashControlSub.PRType, 
                         dbo.Job_CashControlSub.ChqNo, dbo.Job_CashControlSub.BookCode, dbo.Job_CashControlSub.BankCode, dbo.Job_CashControlSub.BankBranch, dbo.Job_CashControlSub.ChqDate, dbo.Job_CashControlSub.CashAmount, 
                         dbo.Job_CashControlSub.ChqAmount, dbo.Job_CashControlSub.CreditAmount, dbo.Job_CashControlSub.IsLocal, dbo.Job_CashControlSub.ChqStatus, dbo.Job_CashControlSub.TRemark, dbo.Job_CashControlSub.PayChqTo, 
                         dbo.Job_CashControlSub.DocNo, dbo.Job_CashControlSub.SICode, dbo.Job_CashControlSub.RecvBank, dbo.Job_CashControlSub.RecvBranch
FROM            dbo.Job_CashControlSub INNER JOIN
                         dbo.QE_CashControlRefJob ON dbo.Job_CashControlSub.BranchCode = dbo.QE_CashControlRefJob.BranchCode AND dbo.Job_CashControlSub.ControlNo = dbo.QE_CashControlRefJob.ControlNo


GO
/****** Object:  View [dbo].[vJob_Count]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vJob_Count]
AS
SELECT     JobType, ShipBy, CustCode, CSCode, JobStatus, COUNT(*) AS TotalJob
FROM         dbo.qJob_Order
GROUP BY JobType, ShipBy, CustCode, CSCode, JobStatus

GO
/****** Object:  View [dbo].[QE_CashControlDoc]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[QE_CashControlDoc]
AS
SELECT        dbo.Job_CashControlDoc.BranchCode, dbo.QE_CashControlRefJob.JNo, dbo.Job_CashControlDoc.ControlNo, dbo.Job_CashControlDoc.ItemNo, dbo.Job_CashControlDoc.DocType, dbo.Job_CashControlDoc.DocNo, 
                         dbo.Job_CashControlDoc.DocDate, dbo.Job_CashControlDoc.CmpType, dbo.Job_CashControlDoc.CmpCode, dbo.Job_CashControlDoc.CmpBranch, dbo.Job_CashControlDoc.PaidAmount, 
                         dbo.Job_CashControlDoc.TotalAmount
FROM            dbo.Job_CashControlDoc INNER JOIN
                         dbo.QE_CashControlRefJob ON dbo.Job_CashControlDoc.BranchCode = dbo.QE_CashControlRefJob.BranchCode AND dbo.Job_CashControlDoc.ControlNo = dbo.QE_CashControlRefJob.ControlNo AND 
                         dbo.Job_CashControlDoc.DocNo = dbo.QE_CashControlRefJob.DocNo


GO
/****** Object:  View [dbo].[vJob_Invoice]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vJob_Invoice]
AS
SELECT     dbo.Job_BillingHeader.JobNo, dbo.Job_BillingDetail.SICode, dbo.Job_SrvSingle.NameThai, dbo.Job_SrvSingle.IsExpense, 
                      dbo.Job_SrvSingle.Is50Tavi, dbo.Job_SrvSingle.IsTaxCharge, dbo.Job_BillingDetail.AmtAdvance AS sumAdvance, 
                      dbo.Job_BillingDetail.AmtCharge AS sumCharge, dbo.Job_BillingDetail.AmtAdvance + dbo.Job_BillingDetail.AmtCharge AS SumAmount, 
                      dbo.Job_BillingHeader.DocNo AS FirstInvoice, dbo.Job_BillingDetail.ItemNo
FROM         dbo.Job_BillingHeader INNER JOIN
                      dbo.Job_BillingDetail ON dbo.Job_BillingHeader.DocNo = dbo.Job_BillingDetail.DocNo AND 
                      dbo.Job_BillingHeader.BranchCode = dbo.Job_BillingDetail.BranchCode LEFT OUTER JOIN
                      dbo.Job_SrvSingle ON dbo.Job_BillingDetail.SICode = dbo.Job_SrvSingle.SICode
WHERE     (NOT (ISNULL(dbo.Job_BillingHeader.CancelProve, '') <> ''))

GO
/****** Object:  View [dbo].[vJob_NoInvoice]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vJob_NoInvoice]
AS
SELECT     dbo.Job_Detail.JNo, dbo.Job_Detail.LinkItem, dbo.Job_Detail.SICode, dbo.Job_SrvSingle.NameThai, dbo.Job_SrvSingle.IsTaxCharge, 
                      dbo.Job_SrvSingle.Is50Tavi, dbo.Job_SrvSingle.IsExpense, dbo.Job_Detail.BPrice, dbo.Job_Detail.BCost, 
                      (CASE WHEN dbo.Job_Detail.BPrice > 0 THEN dbo.Job_Detail.BPrice ELSE dbo.Job_Detail.BCost END) AS sumAmount
FROM         dbo.Job_Detail LEFT OUTER JOIN
                      dbo.Job_SrvSingle ON dbo.Job_Detail.SICode = dbo.Job_SrvSingle.SICode
WHERE     (ISNULL(dbo.Job_Detail.DNNo, '') = '')

GO
/****** Object:  View [dbo].[vJob_Summary]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vJob_Summary]
AS
SELECT     JobNo, ItemNo, SICode, NameThai AS SIDesc, sumAdvance, sumCharge, 0 AS sumCost, FirstInvoice
FROM         vJob_Invoice
UNION
SELECT     JNo, LinkItem, SICode, Namethai, 0, 0, SumAmount, 'Cost'
FROM         vJob_NoInvoice

GO
/****** Object:  View [dbo].[vJob_Profit]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vJob_Profit]
AS
SELECT     dbo.qJob_Order.BranchCode, dbo.qJob_Order.JNo, dbo.qJob_Order.JRevise, dbo.qJob_Order.ConfirmDate, dbo.qJob_Order.CPolicyCode, 
                      dbo.qJob_Order.DocDate, dbo.qJob_Order.CustCode, dbo.qJob_Order.CustBranch, dbo.qJob_Order.CustContactName, dbo.qJob_Order.QNo, 
                      dbo.qJob_Order.Revise, dbo.qJob_Order.ManagerCode, dbo.qJob_Order.CSCode, dbo.qJob_Order.Description, dbo.qJob_Order.TRemark, 
                      dbo.qJob_Order.JobStatus, dbo.qJob_Order.JobType, dbo.qJob_Order.ShipBy, dbo.qJob_Order.InvNo, dbo.qJob_Order.InvTotal, 
                      dbo.qJob_Order.InvProduct, dbo.qJob_Order.InvCountry, dbo.qJob_Order.InvFCountry, dbo.qJob_Order.InvInterPort, dbo.qJob_Order.InvProductQty, 
                      dbo.qJob_Order.InvProductUnit, dbo.qJob_Order.InvCurUnit, dbo.qJob_Order.InvCurRate, dbo.qJob_Order.ImExDate, dbo.qJob_Order.BLNo, 
                      dbo.qJob_Order.BookingNo, dbo.qJob_Order.ClearPort, dbo.qJob_Order.ClearPortNo, dbo.qJob_Order.ClearDate, dbo.qJob_Order.LoadDate, 
                      dbo.qJob_Order.ForwarderCode, dbo.qJob_Order.AgentCode, dbo.qJob_Order.VesselName, dbo.qJob_Order.ETDDate, dbo.qJob_Order.ETADate, 
                      dbo.qJob_Order.ETTime, dbo.qJob_Order.FNetPrice, dbo.qJob_Order.BNetPrice, dbo.qJob_Order.CancelReson, dbo.qJob_Order.CancelDate, 
                      dbo.qJob_Order.CancelTime, dbo.qJob_Order.CancelProve, dbo.qJob_Order.CancelProveDate, dbo.qJob_Order.CancelProveTime, 
                      dbo.qJob_Order.CloseJobDate, dbo.qJob_Order.CloseJobTime, dbo.qJob_Order.CloseJobBy, dbo.qJob_Order.DeclareType, 
                      dbo.qJob_Order.DeclareNumber, dbo.qJob_Order.DeclareStatus, dbo.qJob_Order.TyAuthorSp, dbo.qJob_Order.Ty19BIS, dbo.qJob_Order.TyClearTax, 
                      dbo.qJob_Order.TyClearTaxReson, dbo.qJob_Order.EstDeliverDate, dbo.qJob_Order.EstDeliverTime, dbo.qJob_Order.TotalContainer, 
                      dbo.qJob_Order.DutyDate, dbo.qJob_Order.DutyAmount, dbo.qJob_Order.DutyCustPayOther, dbo.qJob_Order.DutyCustPayChqAmt, 
                      dbo.qJob_Order.DutyCustPayBankAmt, dbo.qJob_Order.DutyCustPayEPAYAmt, dbo.qJob_Order.DutyCustPayCardAmt, 
                      dbo.qJob_Order.DutyCustPayCashAmt, dbo.qJob_Order.DutyCustPayOtherAmt, dbo.qJob_Order.DutyLtdPayOther, dbo.qJob_Order.DutyLtdPayChqAmt, 
                      dbo.qJob_Order.DutyLtdPayEPAYAmt, dbo.qJob_Order.DutyLtdPayCashAmt, dbo.qJob_Order.DutyLtdPayOtherAmt, dbo.qJob_Order.ConfirmChqDate, 
                      dbo.qJob_Order.ShippingEmp, dbo.qJob_Order.ShippingCmd, dbo.qJob_Order.TotalGW, dbo.qJob_Order.GWUnit, dbo.qJob_Order.TSRequest, 
                      dbo.qJob_Order.ShipmentType, dbo.qJob_Order.ReadyToClearDate, dbo.qJob_Order.Commission, dbo.qJob_Order.CommPayTo, 
                      dbo.qJob_Order.ProjectName, dbo.qJob_Order.MVesselName, dbo.qJob_Order.TotalNW, dbo.qJob_Order.Measurement, dbo.qJob_Order.CustRefNO, 
                      dbo.qJob_Order.TotalQty, dbo.qJob_Order.HAWB, dbo.qJob_Order.MAWB, dbo.qJob_Order.consigneecode, dbo.qJob_Order.privilegests, 
                      dbo.qJob_Order.CustID, dbo.qJob_Order.Title, dbo.qJob_Order.NameThai, dbo.qJob_Order.NameEng, dbo.qJob_Order.AgentName, 
                      dbo.qJob_Order.AreaName, dbo.qJob_Order.CSName, dbo.qJob_Order.SalesCode, dbo.qJob_Order.ConsigneeName, dbo.qJob_Order.ForwarderName, 
                      SUM(ISNULL(dbo.vJob_Summary.sumAdvance, 0)) AS Advance, SUM(ISNULL(dbo.vJob_Summary.sumCharge, 0)) AS Service, 
                      SUM(ISNULL(dbo.vJob_Summary.sumCost, 0)) AS Cost, SUM(ISNULL(dbo.vJob_Summary.sumCharge, 0)) - SUM(ISNULL(dbo.vJob_Summary.sumCost, 
                      0)) AS Profit, MAX(dbo.vJob_Summary.FirstInvoice) AS BillingNo
FROM         dbo.vJob_Summary RIGHT OUTER JOIN
                      dbo.qJob_Order ON dbo.vJob_Summary.JobNo = dbo.qJob_Order.JNo
GROUP BY dbo.qJob_Order.BranchCode, dbo.qJob_Order.JNo, dbo.qJob_Order.JRevise, dbo.qJob_Order.ConfirmDate, dbo.qJob_Order.CPolicyCode, 
                      dbo.qJob_Order.DocDate, dbo.qJob_Order.CustCode, dbo.qJob_Order.CustBranch, dbo.qJob_Order.CustContactName, dbo.qJob_Order.QNo, 
                      dbo.qJob_Order.Revise, dbo.qJob_Order.ManagerCode, dbo.qJob_Order.CSCode, dbo.qJob_Order.Description, dbo.qJob_Order.TRemark, 
                      dbo.qJob_Order.JobStatus, dbo.qJob_Order.JobType, dbo.qJob_Order.ShipBy, dbo.qJob_Order.InvNo, dbo.qJob_Order.InvTotal, 
                      dbo.qJob_Order.InvProduct, dbo.qJob_Order.InvCountry, dbo.qJob_Order.InvFCountry, dbo.qJob_Order.InvInterPort, dbo.qJob_Order.InvProductQty, 
                      dbo.qJob_Order.InvProductUnit, dbo.qJob_Order.InvCurUnit, dbo.qJob_Order.InvCurRate, dbo.qJob_Order.ImExDate, dbo.qJob_Order.BLNo, 
                      dbo.qJob_Order.BookingNo, dbo.qJob_Order.ClearPort, dbo.qJob_Order.ClearPortNo, dbo.qJob_Order.ClearDate, dbo.qJob_Order.LoadDate, 
                      dbo.qJob_Order.ForwarderCode, dbo.qJob_Order.AgentCode, dbo.qJob_Order.VesselName, dbo.qJob_Order.ETDDate, dbo.qJob_Order.ETADate, 
                      dbo.qJob_Order.ETTime, dbo.qJob_Order.FNetPrice, dbo.qJob_Order.BNetPrice, dbo.qJob_Order.CancelReson, dbo.qJob_Order.CancelDate, 
                      dbo.qJob_Order.CancelTime, dbo.qJob_Order.CancelProve, dbo.qJob_Order.CancelProveDate, dbo.qJob_Order.CancelProveTime, 
                      dbo.qJob_Order.CloseJobDate, dbo.qJob_Order.CloseJobTime, dbo.qJob_Order.CloseJobBy, dbo.qJob_Order.DeclareType, 
                      dbo.qJob_Order.DeclareNumber, dbo.qJob_Order.DeclareStatus, dbo.qJob_Order.TyAuthorSp, dbo.qJob_Order.Ty19BIS, dbo.qJob_Order.TyClearTax, 
                      dbo.qJob_Order.TyClearTaxReson, dbo.qJob_Order.EstDeliverDate, dbo.qJob_Order.EstDeliverTime, dbo.qJob_Order.TotalContainer, 
                      dbo.qJob_Order.DutyDate, dbo.qJob_Order.DutyAmount, dbo.qJob_Order.DutyCustPayOther, dbo.qJob_Order.DutyCustPayChqAmt, 
                      dbo.qJob_Order.DutyCustPayBankAmt, dbo.qJob_Order.DutyCustPayEPAYAmt, dbo.qJob_Order.DutyCustPayCardAmt, 
                      dbo.qJob_Order.DutyCustPayCashAmt, dbo.qJob_Order.DutyCustPayOtherAmt, dbo.qJob_Order.DutyLtdPayOther, dbo.qJob_Order.DutyLtdPayChqAmt, 
                      dbo.qJob_Order.DutyLtdPayEPAYAmt, dbo.qJob_Order.DutyLtdPayCashAmt, dbo.qJob_Order.DutyLtdPayOtherAmt, dbo.qJob_Order.ConfirmChqDate, 
                      dbo.qJob_Order.ShippingEmp, dbo.qJob_Order.ShippingCmd, dbo.qJob_Order.TotalGW, dbo.qJob_Order.GWUnit, dbo.qJob_Order.TSRequest, 
                      dbo.qJob_Order.ShipmentType, dbo.qJob_Order.ReadyToClearDate, dbo.qJob_Order.Commission, dbo.qJob_Order.CommPayTo, 
                      dbo.qJob_Order.ProjectName, dbo.qJob_Order.MVesselName, dbo.qJob_Order.TotalNW, dbo.qJob_Order.Measurement, dbo.qJob_Order.CustRefNO, 
                      dbo.qJob_Order.TotalQty, dbo.qJob_Order.HAWB, dbo.qJob_Order.MAWB, dbo.qJob_Order.consigneecode, dbo.qJob_Order.privilegests, 
                      dbo.qJob_Order.CustID, dbo.qJob_Order.Title, dbo.qJob_Order.NameThai, dbo.qJob_Order.NameEng, dbo.qJob_Order.AgentName, 
                      dbo.qJob_Order.AreaName, dbo.qJob_Order.CSName, dbo.qJob_Order.SalesCode, dbo.qJob_Order.ConsigneeName, dbo.qJob_Order.ForwarderName

GO
/****** Object:  View [dbo].[vJob_CodeSum]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vJob_CodeSum]
AS
SELECT     SICode, SIDesc, SUM(sumAdvance) AS Advance, SUM(sumCost) AS Cost, SUM(sumCharge) AS Service
FROM         dbo.vJob_Summary
GROUP BY SICode, SIDesc

GO
/****** Object:  View [dbo].[vKPI_AdvanceSum]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vKPI_AdvanceSum]
AS
SELECT     JNo, COUNT(*) AS TotalAdvDoc, SUM(CASE WHEN DaysClear <= - 7 THEN 1 ELSE 0 END) AS TotalClrOnTime, 
                      SUM(CASE WHEN DaysAccReceive <= - 5 THEN 1 ELSE 0 END) AS TotalRcvOnTime, SUM(CASE WHEN DaysClear <= - 7 THEN 1 ELSE 0 END) 
                      * 100 / COUNT(*) AS AdvClrScore, SUM(CASE WHEN DaysAccReceive <= - 5 THEN 1 ELSE 0 END) * 100 / COUNT(*) AS ClrRcvScore
FROM         dbo.vKPI_Advance
GROUP BY JNo


GO
/****** Object:  View [dbo].[vJob_TrackingOper]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vJob_TrackingOper]
AS
SELECT     dbo.qJob_Order.BranchCode, dbo.qJob_Order.JNo, dbo.qJob_Order.JRevise, dbo.qJob_Order.ConfirmDate, dbo.qJob_Order.CPolicyCode, 
                      dbo.qJob_Order.DocDate, dbo.qJob_Order.CustCode, dbo.qJob_Order.CustBranch, dbo.qJob_Order.CustContactName, dbo.qJob_Order.QNo, 
                      dbo.qJob_Order.Revise, dbo.qJob_Order.ManagerCode, dbo.qJob_Order.CSCode, dbo.qJob_Order.Description, dbo.qJob_Order.TRemark, 
                      dbo.qJob_Order.JobStatus, dbo.qJob_Order.JobType, dbo.qJob_Order.ShipBy, dbo.qJob_Order.InvNo, dbo.qJob_Order.InvTotal, 
                      dbo.qJob_Order.InvProduct, dbo.qJob_Order.InvCountry, dbo.qJob_Order.InvFCountry, dbo.qJob_Order.InvInterPort, dbo.qJob_Order.InvProductQty, 
                      dbo.qJob_Order.InvProductUnit, dbo.qJob_Order.InvCurUnit, dbo.qJob_Order.InvCurRate, dbo.qJob_Order.ImExDate, dbo.qJob_Order.BLNo, 
                      dbo.qJob_Order.BookingNo, dbo.qJob_Order.ClearPort, dbo.qJob_Order.ClearPortNo, dbo.qJob_Order.ClearDate, dbo.qJob_Order.LoadDate, 
                      dbo.qJob_Order.ForwarderCode, dbo.qJob_Order.AgentCode, dbo.qJob_Order.VesselName, dbo.qJob_Order.ETDDate, dbo.qJob_Order.ETADate, 
                      dbo.qJob_Order.ETTime, dbo.qJob_Order.FNetPrice, dbo.qJob_Order.BNetPrice, dbo.qJob_Order.CancelReson, dbo.qJob_Order.CancelDate, 
                      dbo.qJob_Order.CancelTime, dbo.qJob_Order.CancelProve, dbo.qJob_Order.CancelProveDate, dbo.qJob_Order.CancelProveTime, 
                      dbo.qJob_Order.CloseJobDate, dbo.qJob_Order.CloseJobTime, dbo.qJob_Order.CloseJobBy, dbo.qJob_Order.DeclareType, 
                      dbo.qJob_Order.DeclareNumber, dbo.qJob_Order.DeclareStatus, dbo.qJob_Order.TyAuthorSp, dbo.qJob_Order.Ty19BIS, dbo.qJob_Order.TyClearTax, 
                      dbo.qJob_Order.TyClearTaxReson, dbo.qJob_Order.EstDeliverDate, dbo.qJob_Order.EstDeliverTime, dbo.qJob_Order.TotalContainer, 
                      dbo.qJob_Order.DutyDate, dbo.qJob_Order.DutyAmount, dbo.qJob_Order.DutyCustPayOther, dbo.qJob_Order.DutyCustPayChqAmt, 
                      dbo.qJob_Order.DutyCustPayBankAmt, dbo.qJob_Order.DutyCustPayEPAYAmt, dbo.qJob_Order.DutyCustPayCardAmt, 
                      dbo.qJob_Order.DutyCustPayCashAmt, dbo.qJob_Order.DutyCustPayOtherAmt, dbo.qJob_Order.DutyLtdPayOther, dbo.qJob_Order.DutyLtdPayChqAmt, 
                      dbo.qJob_Order.DutyLtdPayEPAYAmt, dbo.qJob_Order.DutyLtdPayCashAmt, dbo.qJob_Order.DutyLtdPayOtherAmt, dbo.qJob_Order.ConfirmChqDate, 
                      dbo.qJob_Order.ShippingEmp, dbo.qJob_Order.ShippingCmd, dbo.qJob_Order.TotalGW, dbo.qJob_Order.GWUnit, dbo.qJob_Order.TSRequest, 
                      dbo.qJob_Order.ShipmentType, dbo.qJob_Order.ReadyToClearDate, dbo.qJob_Order.Commission, dbo.qJob_Order.CommPayTo, 
                      dbo.qJob_Order.ProjectName, dbo.qJob_Order.MVesselName, dbo.qJob_Order.TotalNW, dbo.qJob_Order.Measurement, dbo.qJob_Order.CustRefNO, 
                      dbo.qJob_Order.TotalQty, dbo.qJob_Order.HAWB, dbo.qJob_Order.MAWB, dbo.qJob_Order.consigneecode, dbo.qJob_Order.privilegests, 
                      dbo.qJob_Order.CustID, dbo.qJob_Order.Title, dbo.qJob_Order.NameThai, dbo.qJob_Order.NameEng, dbo.qJob_Order.AgentName, 
                      dbo.qJob_Order.AreaName, dbo.qJob_Order.CSName, dbo.qJob_Order.SalesCode, dbo.qJob_Order.ConsigneeName, dbo.qJob_Order.ForwarderName, 
                      dbo.vJob_Summary.JobNo, dbo.vJob_Summary.ItemNo, dbo.vJob_Summary.SICode, dbo.vJob_Summary.SIDesc, dbo.vJob_Summary.sumAdvance, 
                      dbo.vJob_Summary.sumCharge, dbo.vJob_Summary.sumCost, dbo.vJob_Summary.FirstInvoice
FROM         dbo.qJob_Order LEFT OUTER JOIN
                      dbo.vJob_Summary ON dbo.qJob_Order.JNo = dbo.vJob_Summary.JobNo

GO
/****** Object:  View [dbo].[vKPI]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[vKPI]
AS
SELECT     dbo.Job_Order.JNo, dbo.Job_Order.CustCode, dbo.Job_Order.CSCode, dbo.Job_Order.ShippingEmp, dbo.Job_Order.ETDDate, dbo.Job_Order.ETADate, 
                      dbo.Job_Order.DocDate, DATEDIFF(d, dbo.Job_Order.DocDate, 
                      (CASE WHEN dbo.Job_Order.JobType = 1 THEN dbo.Job_Order.ETADate ELSE dbo.Job_Order.ETDDate END)) AS OpenOntime, 
                      dbo.Job_Order.ClearDate AS CustomAcceptDate, DATEDIFF(d, dbo.Job_Order.ClearDate, 
                      (CASE WHEN dbo.Job_Order.JobType = 1 THEN dbo.Job_Order.ETADate ELSE dbo.Job_Order.ETDDate END)) AS EDIOntime, 
                      dbo.Job_Order.ReadyToClearDate AS ReadyClearDate, DATEDIFF(d, dbo.Job_Order.ReadyToClearDate, 
                      (CASE WHEN dbo.Job_Order.JobType = 1 THEN dbo.Job_Order.ETADate ELSE dbo.Job_Order.ETDDate END)) AS ShippingOntime, 
                      dbo.Job_Order.DutyDate AS InspectionDate, DATEDIFF(d, dbo.Job_Order.DutyDate, 
                      (CASE WHEN dbo.Job_Order.JobType = 1 THEN dbo.Job_Order.ETADate ELSE dbo.Job_Order.ETDDate END)) AS ClearanceOntime, 
                      dbo.Job_Order.CloseJobDate, DATEDIFF(d, dbo.Job_Order.CloseJobDate,(CASE WHEN dbo.Job_Order.JobType=1 THEN dbo.Job_Order.DutyDate ELSE dbo.Job_Order.ReadyToClearDate END)) AS CloseJobOnTime, 
                      MAX(dbo.Job_AdvHeader.AdvDate) AS LastAdvance, MAX(dbo.Job_ClearHeader.ClrDate) AS LastClearing, MIN(dbo.Job_BillingHeader.DocDate) AS FirstInvoice,
                      MAX(dbo.Job_BillingHeader.DocDate) AS LastInvoice, MAX(dbo.Job_TaxInvoice.InvDate) AS LastReceipt, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, 
                      dbo.Job_Order.ForwarderCode, dbo.Job_Order.AgentCode, dbo.Job_Order.DeclareNumber, dbo.Job_Order.TotalContainer, 
                      dbo.Job_Order.ConfirmChqDate AS AccSentDate, dbo.Job_Order.ConfirmDate AS AccConfirmDate, DATEDIFF(d, dbo.Job_Order.CloseJobDate, 
                      dbo.Job_Order.ConfirmDate) AS ConfirmOntime, DATEDIFF(d, dbo.Job_Order.CloseJobDate, dbo.Job_Order.ConfirmChqDate) AS SentOntime
FROM         dbo.Job_TaxInvoice RIGHT OUTER JOIN
                      dbo.Job_BillingHeader ON dbo.Job_TaxInvoice.InvNo = dbo.Job_BillingHeader.TaxInvNo RIGHT OUTER JOIN
                      dbo.Job_Order ON dbo.Job_BillingHeader.JobNo = dbo.Job_Order.JNo LEFT OUTER JOIN
                      dbo.Job_ClearHeader ON dbo.Job_Order.JNo = dbo.Job_ClearHeader.JNo LEFT OUTER JOIN
                      dbo.Job_AdvHeader ON dbo.Job_Order.JNo = dbo.Job_AdvHeader.JNo
GROUP BY dbo.Job_Order.JNo, dbo.Job_Order.CustCode, dbo.Job_Order.CSCode, dbo.Job_Order.ShippingEmp, dbo.Job_Order.ETDDate, 
                      dbo.Job_Order.ETADate, dbo.Job_Order.DocDate, dbo.Job_Order.ClearDate, dbo.Job_Order.ReadyToClearDate, dbo.Job_Order.DutyDate, 
                      dbo.Job_Order.CloseJobDate, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, dbo.Job_Order.ForwarderCode, 
                      dbo.Job_Order.AgentCode, dbo.Job_Order.DeclareNumber, dbo.Job_Order.TotalContainer, dbo.Job_Order.ConfirmChqDate, dbo.Job_Order.ConfirmDate, 
                      DATEDIFF(d, dbo.Job_Order.CloseJobDate, dbo.Job_Order.ConfirmDate), DATEDIFF(d, dbo.Job_Order.CloseJobDate, dbo.Job_Order.ConfirmChqDate)




GO
/****** Object:  View [dbo].[vKPI_Summary]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vKPI_Summary]
AS
SELECT     dbo.vKPI.JNo, dbo.vKPI.CustCode, dbo.vKPI.CSCode, dbo.vKPI.ShippingEmp, dbo.vKPI.ETDDate, dbo.vKPI.ETADate, dbo.vKPI.DocDate, dbo.vKPI.OpenOntime, 
                      (CASE WHEN vKPI.ShipBy=2 then (case when dbo.vKPI.OpenOntime > 3 THEN 1 ELSE 0 END) else (case when dbo.vKPI.OpenOntime >=0 THEN 1 ELSE 0 END) end) AS OpenScore
                      , dbo.vKPI.CustomAcceptDate, dbo.vKPI.EDIOntime, 
                      (CASE WHEN vKPI.JobType = 1 THEN (CASE WHEN [EDIOntime] >= -2 THEN 1 ELSE 0 END) 
                      ELSE (CASE WHEN vKPI.[ShipBy] = 4 THEN (CASE WHEN [EDIOntime] >= 0 THEN 1 ELSE 0 END) ELSE (CASE WHEN [EDIOntime] >= 3 THEN 1 ELSE 0 END) END) 
                      END) AS EDIScore
                      , dbo.vKPI.ReadyClearDate, (CASE WHEN [ReadyClearDate] > CONVERT(datetime, '01/01/1900', 103) THEN 'Cleared' ELSE 'Not Cleared' END) 
                      AS EDIStatus, dbo.vKPI.ShippingOntime AS DaysStatus03, dbo.vKPI.InspectionDate, dbo.vKPI.ClearanceOntime AS DaysStatus04 
                      ,dbo.vKPI.ShippingOntime -dbo.vKPI.ClearanceOntime as EDIClearDays,
                      dbo.vKPI.CloseJobDate,dbo.vKPI.CloseJobOnTime, 
                      (CASE WHEN vKPI.JobType = 1 THEN (CASE WHEN [CloseJobOntime] >= -7 THEN 1 ELSE 0 END) 
                      ELSE (CASE WHEN vKPI.ShipBy =4 and vKPI.JobType=2 then (CASE WHEN [CloseJobOntime] >= -17 THEN 1 ELSE 0 END) else (CASE WHEN [CloseJobOntime] >= -7 THEN 1 ELSE 0 END) end) END) AS CloseJobScore
                      , dbo.vKPI.LastAdvance, dbo.vKPI.LastClearing, dbo.vKPI.FirstInvoice, 
                      dbo.vKPI.LastInvoice, dbo.vKPI.LastReceipt, dbo.vKPI.AccConfirmDate AS AccReceiveDate, dbo.vKPI.ConfirmOntime as ReceiveOntime, 
                      (CASE WHEN dbo.vKPI.ConfirmOntime <=3 THEN 1 else 0 end) as ReceiveScore,
                      dbo.vKPI.AccSentDate AS TrackingConfirmDate, dbo.vKPI.SentOntime as ConfirmOntime, 
                      (CASE WHEN [SentOntime] >= - 7 THEN 1 ELSE 0 END) AS ACCSentScore, 
                      DATEDIFF(d, dbo.vKPI.AccSentDate, 
                      dbo.vKPI.FirstInvoice) AS BillingOntime, DATEDIFF(d, dbo.vKPI.LastClearing, dbo.vKPI.CloseJobDate) AS DaysClose, DATEDIFF(d, dbo.vKPI.LastInvoice, 
                      dbo.vKPI.CloseJobDate) AS DaysBill, DATEDIFF(d, dbo.vKPI.LastReceipt, dbo.vKPI.LastInvoice) AS DaysComplete, dbo.vJob_Profit.Advance, dbo.vJob_Profit.Service, 
                      dbo.vJob_Profit.Cost, dbo.vJob_Profit.Profit, dbo.vKPI_AdvanceSum.TotalAdvDoc, dbo.vKPI_AdvanceSum.TotalClrOnTime, dbo.vKPI_AdvanceSum.TotalRcvOnTime, 
                      dbo.vKPI_AdvanceSum.AdvClrScore, dbo.vKPI_AdvanceSum.ClrRcvScore, dbo.vKPI.JobStatus, dbo.GetJobStatus(dbo.vKPI.JobStatus) AS Status, dbo.vKPI.JobType, 
                      dbo.vKPI.ShipBy, dbo.vKPI.ForwarderCode, dbo.vKPI.AgentCode, dbo.vKPI.DeclareNumber, dbo.vKPI.TotalContainer
FROM         dbo.vKPI LEFT OUTER JOIN
                      dbo.vJob_Profit ON dbo.vKPI.JNo = dbo.vJob_Profit.JNo LEFT OUTER JOIN
                      dbo.vKPI_AdvanceSum ON dbo.vKPI.JNo = dbo.vKPI_AdvanceSum.JNo


GO
/****** Object:  View [dbo].[qrpt_ksat_Biggg]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qrpt_ksat_Biggg]
AS
SELECT     dbo.qJob_BillDetail.DocNo, dbo.qJob_BillDetail.DocDate, dbo.qJob_BillDetail.JobNo, Asrv.ProcessDesc AS PCSales, 
                      Asrv.GLAccountCodeSales AS GLSALES, Mas_GlSaleName.GLSalsesName, dbo.qJob_BillDetail.AmtCharge AS SalePrice, 
                      Bsrv.ProcessDesc AS PCCost, Bsrv.GLAccountCodeCost AS GLCOST, Mas_GLCostName.GLCostName, dbo.qJob_BillDetail.AmtAdvance AS CostPrice, 
                      dbo.qJob_Detail.UnitCost AS CmpCost, ROUND(dbo.qJob_BillDetail.AmtCharge - dbo.qJob_Detail.UnitCost, 2) AS SalesPrf, 
                      ROUND(dbo.qJob_BillDetail.AmtAdvance - dbo.qJob_Detail.UnitCost, 2) AS CostPrf
FROM         dbo.qJob_BillDetail INNER JOIN
                      dbo.Job_SrvSingle AS Asrv ON dbo.qJob_BillDetail.SICode = Asrv.SICode INNER JOIN
                      dbo.Job_SrvSingle AS Bsrv ON dbo.qJob_BillDetail.SICode = Bsrv.SICode INNER JOIN
                      dbo.qJob_Detail ON dbo.qJob_BillDetail.BranchCode = dbo.qJob_Detail.BranchCode AND dbo.qJob_BillDetail.JobNo = dbo.qJob_Detail.JNo AND 
                      dbo.qJob_BillDetail.DocNo = dbo.qJob_Detail.DNNo AND dbo.qJob_BillDetail.SICode = dbo.qJob_Detail.SICode INNER JOIN
                      dbo.MAS_GLACCOUNT AS Mas_GlSaleName ON Asrv.GLAccountCodeSales = Mas_GlSaleName.GLSalesCode INNER JOIN
                      dbo.MAS_GLACCOUNT AS Mas_GLCostName ON Bsrv.GLAccountCodeCost = Mas_GLCostName.GLCostCode


GO
/****** Object:  View [dbo].[qrpt_CostState]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qrpt_CostState]
AS
SELECT     dbo.qJob_BillDetail.DocDate, dbo.qJob_BillDetail.BillToCustCode, dbo.qJob_BillDetail.BillToCustBranch, dbo.qJob_BillDetail.NameThai, 
                      dbo.qJob_BillDetail.TaxNumber, dbo.qJob_BillDetail.DocNo, dbo.qJob_BillDetail.SICode, dbo.qJob_BillDetail.SDescription, 
                      dbo.qJob_BillDetail.TotalAdvance + dbo.qJob_BillDetail.TotalCharge AS GRAmount, dbo.qJob_BillDetail.TotalVAT, 
                      dbo.qJob_BillDetail.Total50Tavi1 + dbo.qJob_BillDetail.Total50Tavi2 AS TotalTax, dbo.qJob_BillDetail.TotalNet, dbo.qJob_BillDetail.DCurrencyCode, 
                      dbo.qJob_BillDetail.JobNo, dbo.qJob_BillDetail.EmpCode, dbo.Job_SrvSingle.GLAccountCodeSales, dbo.Job_SrvSingle.GLAccountCodeCost, 
                      MAS_GLACCOUNT_1.GLCostName
FROM         dbo.MAS_GLACCOUNT AS MAS_GLACCOUNT_1 INNER JOIN
                      dbo.qJob_BillDetail INNER JOIN
                      dbo.Job_SrvSingle ON dbo.qJob_BillDetail.SICode = dbo.Job_SrvSingle.SICode ON MAS_GLACCOUNT_1.GLCostCode = dbo.Job_SrvSingle.GLAccountCodeCost


GO
/****** Object:  View [dbo].[qrpt_SalseState]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qrpt_SalseState]
AS
SELECT     dbo.qJob_BillDetail.DocDate, dbo.qJob_BillDetail.BillToCustCode, dbo.qJob_BillDetail.BillToCustBranch, dbo.qJob_BillDetail.NameThai, 
                      dbo.qJob_BillDetail.TaxNumber, dbo.qJob_BillDetail.DocNo, dbo.qJob_BillDetail.SICode, dbo.qJob_BillDetail.SDescription, 
                      dbo.qJob_BillDetail.TotalAdvance + dbo.qJob_BillDetail.TotalCharge AS GRAmount, dbo.qJob_BillDetail.TotalVAT, 
                      dbo.qJob_BillDetail.Total50Tavi1 + dbo.qJob_BillDetail.Total50Tavi2 AS TotalTax, dbo.qJob_BillDetail.TotalNet, dbo.qJob_BillDetail.DCurrencyCode, 
                      dbo.qJob_BillDetail.JobNo, dbo.qJob_BillDetail.EmpCode, dbo.Job_SrvSingle.GLAccountCodeSales, dbo.Job_SrvSingle.GLAccountCodeCost, 
                      MAS_GLACCOUNT_1.GLSalsesName
FROM         dbo.MAS_GLACCOUNT AS MAS_GLACCOUNT_1 INNER JOIN
                      dbo.qJob_BillDetail INNER JOIN
                      dbo.Job_SrvSingle ON dbo.qJob_BillDetail.SICode = dbo.Job_SrvSingle.SICode ON MAS_GLACCOUNT_1.GLSalesCode = dbo.Job_SrvSingle.GLAccountCodeSales


GO
/****** Object:  View [dbo].[Q_ProfitCalculate]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Q_ProfitCalculate]
AS
SELECT        BranchCode, JNo, Sales_DS - Cost_DS AS Profit_DS, Sales_DSR - Cost_DSR AS Profit_DSR, Sales_OS - Cost_OS AS Profit_OS, Sales_OSR - Cost_OSR AS Profit_OSR, ROUND((((Sales_DS - Cost_DS) + (Sales_DSR - Cost_DSR)) 
                         + (Sales_OS - Cost_OS)) + (Sales_OSR - Cost_OSR), 2) AS SubTotal_Profit
FROM            dbo.Q_CostJoinProfit


GO
/****** Object:  View [dbo].[Q_ReportCostAndProfit]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Q_ReportCostAndProfit]
AS
SELECT     dbo.Q_CostJoinProfit.BranchCode, dbo.Q_CostJoinProfit.JNo, dbo.Q_CostJoinProfit.JobDate, dbo.Q_CostJoinProfit.LastBiiling AS TotalInvoice,
                          (SELECT     CONVERT(date, DocDate) AS BiiiDate
                            FROM          dbo.Job_BillingHeader
                            WHERE      (JobNo = dbo.Q_CostJoinProfit.JNo) AND (BranchCode = dbo.Q_CostJoinProfit.BranchCode) AND 
                                                   (JobBillAmt = dbo.Q_CostJoinProfit.LastBiiling)) AS LastInvDate, dbo.Q_CostJoinProfit.CPolicyCode AS JobState, 
                      dbo.Q_CostJoinProfit.JobType, dbo.Q_CostJoinProfit.ShipBy, dbo.Q_CostJoinProfit.JobStatus, dbo.Q_CostJoinProfit.CSCode, 
                      dbo.Q_CostJoinProfit.CustCode, dbo.Q_CostJoinProfit.CustBranch, dbo.Q_CostJoinProfit.CustTaxNumber, dbo.Q_CostJoinProfit.CustName, 
                      dbo.Q_CostJoinProfit.ConsignCode, dbo.Q_CostJoinProfit.ConsignBranch, dbo.Q_CostJoinProfit.ConsignTaxNumber, 
                      dbo.Q_CostJoinProfit.ConsignName, dbo.Q_CostJoinProfit.ETDDate, dbo.Q_CostJoinProfit.ETADate, dbo.Q_CostJoinProfit.MAWB, 
                      dbo.Q_CostJoinProfit.HAWB, dbo.Q_CostJoinProfit.Sales_DS, dbo.Q_CostJoinProfit.Sales_DSR, dbo.Q_CostJoinProfit.Sales_OS, 
                      dbo.Q_CostJoinProfit.Sales_OSR, dbo.Q_CostJoinProfit.SubTotal_Sales, dbo.Q_CostJoinProfit.Cost_DS, dbo.Q_CostJoinProfit.Cost_DSR, 
                      dbo.Q_CostJoinProfit.Cost_OS, dbo.Q_CostJoinProfit.Cost_OSR, dbo.Q_CostJoinProfit.SubTotal_Cost, dbo.Q_ProfitCalculate.Profit_DS, 
                      dbo.Q_ProfitCalculate.Profit_DSR, dbo.Q_ProfitCalculate.Profit_OS, dbo.Q_ProfitCalculate.Profit_OSR, dbo.Q_ProfitCalculate.SubTotal_Profit, 
                      CONVERT(date, dbo.Q_CostJoinProfit.ConfirmDate) AS JobStatusDate
FROM         dbo.Q_CostJoinProfit INNER JOIN
                      dbo.Q_ProfitCalculate ON dbo.Q_CostJoinProfit.BranchCode = dbo.Q_ProfitCalculate.BranchCode AND 
                      dbo.Q_CostJoinProfit.JNo = dbo.Q_ProfitCalculate.JNo
WHERE     (dbo.Q_CostJoinProfit.LastBiiling > 0)


GO
/****** Object:  View [dbo].[qJob_AdvDetail]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_AdvDetail] AS 
SELECT Job_AdvHeader.*, Job_Order.CustCode, Job_Order.CustBranch, Job_Order.CustCode+'-'+[CustBranch] AS CustID, Mas_Company.NameThai AS CustTName, Mas_Company.NameEng AS CustEName, Mas_User.TName AS CSName, Job_AdvDetail.ItemNo, Job_AdvDetail.STCode, Job_AdvDetail.SICode, Job_AdvDetail.AdvAmount, Job_AdvDetail.Charge50Tavi, Job_AdvDetail.TRemark AS AdvTRemark, Job_Order.AgentCode, Mas_Agent.TName AS AgentName, Job_AdvDetail.ChargeVAT, Job_AdvDetail.IsDuplicate, Job_Order.ShipBy
FROM ((((Job_AdvHeader LEFT JOIN Job_AdvDetail ON (Job_AdvHeader.AdvNo = Job_AdvDetail.AdvNo) AND (Job_AdvHeader.BranchCode = Job_AdvDetail.BranchCode)) LEFT JOIN Job_Order ON (Job_AdvHeader.JNo = Job_Order.JNo) AND (Job_AdvHeader.BranchCode = Job_Order.BranchCode)) LEFT JOIN Mas_Company ON (Job_Order.CustBranch = Mas_Company.Branch) AND (Job_Order.CustCode = Mas_Company.CustCode)) INNER JOIN Mas_User ON Job_AdvHeader.EmpCode = Mas_User.UserID) LEFT JOIN Mas_Agent ON Job_Order.AgentCode = Mas_Agent.Code

GO
/****** Object:  View [dbo].[Q_ClearEarness]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Q_ClearEarness]
AS
SELECT     dbo.qJob_ClearDetail.BranchCode, dbo.qJob_ClearDetail.ClrNo, dbo.qJob_AdvDetail.AdvNo, dbo.qJob_ClearDetail.JobNo, CONVERT(Date, 
                      dbo.qJob_ClearDetail.ClrDate) AS DateClr, CONVERT(Date, dbo.qJob_AdvDetail.AdvDate) AS DateAdv, dbo.qJob_ClearDetail.ClearType, 
                      dbo.qJob_ClearDetail.ClearFrom, dbo.qJob_ClearDetail.DocStatus, dbo.qJob_ClearDetail.ReceiveRef, dbo.qJob_ClearDetail.CancelReson, 
                      dbo.qJob_ClearDetail.Qty, dbo.qJob_ClearDetail.UnitCode, dbo.qJob_ClearDetail.CurrencyCode, dbo.qJob_ClearDetail.CurRate, 
                      dbo.qJob_ClearDetail.SICode, dbo.qJob_ClearDetail.SDescription, ROUND(ISNULL(dbo.qJob_ClearDetail.AdvTotal, 0), 2) AS ClrTotalAdv, 
                      ROUND(ISNULL(dbo.qJob_AdvDetail.TotalAdvance, 0), 2) AS AdvTotalAdv, ROUND(ISNULL(dbo.qJob_AdvDetail.TotalVAT, 0), 2) AS AdvTotalVAT, 
                      ROUND(ISNULL(dbo.qJob_AdvDetail.Total50Tavi, 0), 2) AS AdvTotal50Tavi, ROUND(ISNULL(dbo.qJob_ClearDetail.TotalExpense, 0), 2) 
                      AS ClrTotalExpense, ROUND(ISNULL(dbo.qJob_ClearDetail.UnitPrice, 0), 2) AS ClrUnitPrice, ROUND(ISNULL(dbo.qJob_ClearDetail.BPrice, 0), 2) 
                      AS ClrBPrice, ROUND(ISNULL(dbo.qJob_ClearDetail.UnitCost, 0), 2) AS ClrUnitCost, ROUND(ISNULL(dbo.qJob_ClearDetail.Tax50Tavi, 0), 2) 
                      AS ClrTax50Tavi, ROUND(ISNULL(dbo.qJob_ClearDetail.AdvAmount, 0), 2) AS ClrAdvAmount, ROUND(ISNULL(dbo.qJob_ClearDetail.UsedAmount, 0), 2) 
                      AS ClrUsedAmount, dbo.qJob_ClearDetail.SlipNO, dbo.qJob_ClearDetail.Remark, dbo.qJob_ClearDetail.CustCode, dbo.qJob_ClearDetail.CustBranch, 
                      dbo.qJob_ClearDetail.CustName, dbo.qJob_ClearDetail.CSName, dbo.qJob_AdvDetail.AgentCode, dbo.qJob_AdvDetail.AgentName, 
                      dbo.Mas_Vender.VenCode, dbo.Mas_Vender.BranchCode AS VenBrCode, dbo.Mas_Vender.TaxNumber, dbo.Mas_Vender.English
FROM         dbo.qJob_ClearDetail INNER JOIN
                      dbo.Mas_Vender ON dbo.qJob_ClearDetail.VenderCode = dbo.Mas_Vender.VenCode LEFT OUTER JOIN
                      dbo.qJob_AdvDetail ON dbo.qJob_ClearDetail.BranchCode = dbo.qJob_AdvDetail.BranchCode AND 
                      dbo.qJob_ClearDetail.AdvRefNo = dbo.qJob_AdvDetail.AdvNo
WHERE     (dbo.qJob_ClearDetail.CancelReson = '')

GO
/****** Object:  View [dbo].[qJob_RSlip]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qJob_RSlip]
AS
SELECT     dbo.Job_RSlip.BranchCode, dbo.Job_RSlip.DocNo AS RSlipNo, CONVERT(date, dbo.Job_RSlip.DocDate) AS RSlipDate, 
                      dbo.Job_RSlipSub.BillNo AS RefInvNo
FROM         dbo.Job_RSlip INNER JOIN
                      dbo.Job_RSlipSub ON dbo.Job_RSlip.BranchCode = dbo.Job_RSlipSub.BranchCode AND dbo.Job_RSlip.DocNo = dbo.Job_RSlipSub.DocNo


GO
/****** Object:  View [dbo].[Q_FinancialCostReport]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Q_FinancialCostReport]
AS
SELECT     dbo.qJob_ClearDetail.BranchCode, dbo.qJob_ClearDetail.ClrNo, dbo.qJob_ClearDetail.ClrDate, MONTH(dbo.qJob_ClearDetail.ClrDate) AS ClrMonth, 
                      dbo.qJob_ClearDetail.AdvRefNo, dbo.qJob_ClearDetail.InvNo, dbo.qJob_ClearDetail.ClearType, dbo.qJob_ClearDetail.ClearFrom, 
                      dbo.qJob_ClearDetail.DocStatus AS ClrDocStatus, dbo.qJob_ClearDetail.CancelReson AS ClrCancelReson, dbo.qJob_ClearDetail.CancelProve AS ClrCancelProve, 
                      CONVERT(Date, dbo.qJob_ClearDetail.CancelDate) AS ClrCancelDate, dbo.Q_PaymentRef.ControlNo, dbo.Q_PaymentRef.PRVoucher, CONVERT(Date, 
                      dbo.Q_PaymentRef.VoucherDate) AS PVDate, dbo.qJob_ClearDetail.SICode, dbo.qJob_ClearDetail.SDescription, dbo.qJob_ClearDetail.VenderCode, 
                      dbo.Mas_Vender.TaxNumber AS VendorTaxNumber, dbo.Mas_Vender.English AS VendorEname, dbo.qJob_ClearDetail.CurrencyCode, dbo.qJob_ClearDetail.CurRate, 
                      dbo.qJob_ClearDetail.ChargeVAT, dbo.qJob_ClearDetail.Tax50Tavi AS TaxAmt, 
                      dbo.qJob_ClearDetail.UsedAmount - dbo.qJob_ClearDetail.ChargeVAT + dbo.qJob_ClearDetail.Tax50Tavi AS PreVat, dbo.qJob_ClearDetail.UsedAmount, 
                      dbo.qJob_ClearDetail.EmpCode AS ClrEmpCode, dbo.qJob_ClearDetail.CSName AS ClrEmpName, dbo.qJob_ClearDetail.SlipNO, dbo.qJob_ClearDetail.CustCode, 
                      dbo.qJob_ClearDetail.CustBranch, dbo.qJob_ClearDetail.CustName, dbo.qJob_Detail.JNo, CONVERT(Date, dbo.qJob_Detail.ConfirmDate) AS JobStatusDate, 
                      CONVERT(Date, dbo.qJob_Detail.DocDate) AS JobDate, dbo.qJob_Detail.CPolicyCode, dbo.qJob_Detail.JobType, dbo.qJob_Detail.ShipBy, dbo.qJob_Detail.JobStatus, 
                      CONVERT(Date, dbo.qJob_Detail.ImExDate) AS IEDate, dbo.qJob_Detail.BLNo, CONVERT(Date, dbo.qJob_Detail.ETDDate) AS ETDDate, CONVERT(Date, 
                      dbo.qJob_Detail.ETADate) AS ETADate, dbo.qJob_Detail.HAWB, dbo.qJob_Detail.MAWB, dbo.qJob_BillDetail.DocNo AS InvoiceNo, CONVERT(Date, 
                      dbo.qJob_BillDetail.DocDate) AS InvoiceDate, CONVERT(Date, dbo.qJob_BillDetail.TaxInvDate) AS TaxInvDate, dbo.qJob_BillDetail.BillToCustCode, 
                      dbo.qJob_BillDetail.BillToCustBranch, dbo.Mas_Company.TaxNumber AS BillToTaxNumber, dbo.Mas_Company.NameThai AS BillToNameThai, 
                      dbo.qJob_BillDetail.TaxInvNo, dbo.qJob_RSlip.RSlipNo AS DebitNo, dbo.qJob_RSlip.RSlipDate AS DebitDate, dbo.qJob_BillDetail.ProcessDesc, 
                      dbo.MAS_GLACCOUNT.GLCostCode AS GLAccountCode, dbo.MAS_GLACCOUNT.GLCostName
FROM         dbo.qJob_ClearDetail LEFT OUTER JOIN
                      dbo.qJob_Detail ON dbo.qJob_ClearDetail.BranchCode = dbo.qJob_Detail.BranchCode AND dbo.qJob_ClearDetail.JNo = dbo.qJob_Detail.JNo AND 
                      dbo.qJob_ClearDetail.ClrNo = dbo.qJob_Detail.ClearingNO AND dbo.qJob_ClearDetail.SICode = dbo.qJob_Detail.SICode INNER JOIN
                      dbo.MAS_GLACCOUNT ON dbo.qJob_Detail.GLAccountCodeCost = dbo.MAS_GLACCOUNT.GLCostCode LEFT OUTER JOIN
                      dbo.Q_PaymentRef ON dbo.qJob_ClearDetail.BranchCode = dbo.Q_PaymentRef.BranchCode AND 
                      dbo.qJob_ClearDetail.ClrNo = dbo.Q_PaymentRef.DocNo LEFT OUTER JOIN
                      dbo.Mas_Vender ON dbo.qJob_ClearDetail.VenderCode = dbo.Mas_Vender.VenCode LEFT OUTER JOIN
                      dbo.qJob_BillDetail ON dbo.qJob_BillDetail.BranchCode = dbo.qJob_Detail.BranchCode AND dbo.qJob_BillDetail.JobNo = dbo.qJob_Detail.JNo AND 
                      dbo.qJob_BillDetail.DocNo = dbo.qJob_Detail.DNNo AND dbo.qJob_BillDetail.SICode = dbo.qJob_Detail.SICode LEFT OUTER JOIN
                      dbo.qJob_RSlip ON dbo.qJob_RSlip.BranchCode = dbo.qJob_BillDetail.BranchCode AND dbo.qJob_RSlip.RefInvNo = dbo.qJob_BillDetail.DocNo LEFT OUTER JOIN
                      dbo.Mas_Company ON dbo.qJob_BillDetail.BillToCustCode = dbo.Mas_Company.CustCode AND dbo.qJob_BillDetail.BillToCustBranch = dbo.Mas_Company.Branch

GO
/****** Object:  View [dbo].[Q_FinancialSalesReport]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Q_FinancialSalesReport]
AS
SELECT     dbo.qJob_BillDetail.BranchCode, dbo.qJob_BillDetail.DocNo AS InvoceNo, CONVERT(date, dbo.qJob_BillDetail.DocDate) AS InvoiceDate, 
                      MONTH(dbo.qJob_BillDetail.DocDate) AS InvoiceMonth, dbo.qJob_BillDetail.JobNo, dbo.qJob_BillDetail.JobBillAmt, dbo.qJob_BillDetail.CustCode, 
                      dbo.qJob_BillDetail.CustBranch, Mas_Customers.TaxNumber AS CustTaxNumber, Mas_Customers.NameEng AS CustName, 
                      dbo.qJob_BillDetail.BillToCustCode, dbo.qJob_BillDetail.BillToCustBranch, dbo.qJob_BillDetail.TaxNumber AS BillToTaxNumber, 
                      dbo.qJob_BillDetail.NameEng AS BillToName, dbo.qJob_BillDetail.EmpCode, dbo.qJob_BillDetail.CurrencyCode, dbo.qJob_BillDetail.ExchangeRate, 
                      dbo.qJob_RSlip.RSlipNo, CONVERT(date, dbo.qJob_RSlip.RSlipDate) AS RSlipDate, dbo.qJob_BillDetail.SICode, dbo.qJob_BillDetail.SDescription, 
                      ISNULL(SUM(dbo.qJob_BillDetail.IsTaxCharge), 0) AS IsVat, ISNULL(SUM(dbo.qJob_BillDetail.Is50Tavi), 0) AS IsTax, 
                      ISNULL(SUM(dbo.qJob_BillDetail.Rate50Tavi), 0) AS TaxRate, ROUND(ISNULL(SUM(dbo.qJob_BillDetail.AmtAdvance), 0), 2) AS AmtAdvance, 
                      ROUND(ISNULL(SUM(dbo.qJob_BillDetail.AmtCharge), 0), 2) AS AmtCharge, ROUND(ISNULL(SUM(dbo.qJob_BillDetail.TotalVAT), 0), 2) AS TotalVAT, 
                      ROUND(ISNULL(SUM(dbo.qJob_BillDetail.Total50Tavi1 + dbo.qJob_BillDetail.Total50Tavi2), 0), 2) AS TotalTax, 
                      ROUND(ISNULL(SUM(dbo.qJob_BillDetail.TotalCustAdv), 0), 2) AS TotalCustAdv, ROUND(ISNULL(SUM(dbo.qJob_BillDetail.TotalNet), 0), 2) AS TotalNet, 
                      dbo.qJob_BillDetail.ProcessDesc, dbo.qJob_BillDetail.GLAccountCodeSales AS GLAccountCode, dbo.MAS_GLACCOUNT.GLSalsesName, 
                      dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, CONVERT(date, dbo.Job_Order.ETDDate) AS ETDDate, CONVERT(date, 
                      dbo.Job_Order.ETADate) AS ETADate, CONVERT(date, dbo.Job_Order.DocDate) AS JobDate, CONVERT(date, dbo.Job_Order.ConfirmDate) 
                      AS JobStatusDate, dbo.Job_Order.CPolicyCode
FROM         dbo.qJob_BillDetail LEFT OUTER JOIN
                      dbo.qJob_RSlip ON dbo.qJob_BillDetail.BranchCode = dbo.qJob_RSlip.BranchCode AND 
                      dbo.qJob_BillDetail.DocNo = dbo.qJob_RSlip.RefInvNo INNER JOIN
                      dbo.Mas_Company AS Mas_Customers ON dbo.qJob_BillDetail.CustCode = Mas_Customers.CustCode AND 
                      dbo.qJob_BillDetail.CustBranch = Mas_Customers.Branch INNER JOIN
                      dbo.Job_Order ON dbo.qJob_BillDetail.BranchCode = dbo.Job_Order.BranchCode AND 
                      dbo.qJob_BillDetail.JobNo = dbo.Job_Order.JNo LEFT OUTER JOIN
                      dbo.MAS_GLACCOUNT ON dbo.qJob_BillDetail.GLAccountCodeSales = dbo.MAS_GLACCOUNT.GLSalesCode
GROUP BY dbo.qJob_BillDetail.BranchCode, dbo.qJob_BillDetail.DocNo, dbo.qJob_BillDetail.DocDate, dbo.qJob_BillDetail.DocDate, dbo.qJob_BillDetail.JobNo, 
                      dbo.qJob_BillDetail.JobBillAmt, dbo.qJob_BillDetail.CustCode, dbo.qJob_BillDetail.CustBranch, Mas_Customers.TaxNumber, 
                      Mas_Customers.NameEng, dbo.qJob_BillDetail.BillToCustCode, dbo.qJob_BillDetail.BillToCustBranch, dbo.qJob_BillDetail.TaxNumber, 
                      dbo.qJob_BillDetail.NameEng, dbo.qJob_BillDetail.EmpCode, dbo.qJob_BillDetail.CurrencyCode, dbo.qJob_BillDetail.ExchangeRate, 
                      dbo.qJob_RSlip.RSlipNo, dbo.qJob_RSlip.RSlipDate, dbo.qJob_BillDetail.SICode, dbo.qJob_BillDetail.SDescription, dbo.qJob_BillDetail.IsTaxCharge, 
                      dbo.qJob_BillDetail.Is50Tavi, dbo.qJob_BillDetail.Rate50Tavi, dbo.qJob_BillDetail.AmtAdvance, dbo.qJob_BillDetail.AmtCharge, 
                      dbo.qJob_BillDetail.TotalVAT, dbo.qJob_BillDetail.Total50Tavi1, dbo.qJob_BillDetail.Total50Tavi2, dbo.qJob_BillDetail.TotalCustAdv, 
                      dbo.qJob_BillDetail.TotalNet, dbo.qJob_BillDetail.ProcessDesc, dbo.qJob_BillDetail.GLAccountCodeSales, dbo.MAS_GLACCOUNT.GLSalsesName, 
                      dbo.Job_Order.ConfirmDate, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, dbo.Job_Order.ETDDate, 
                      dbo.Job_Order.ETADate, dbo.Job_Order.CPolicyCode, dbo.Job_Order.DocDate

GO
/****** Object:  View [dbo].[qGL_SetEarnest]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[qGL_SetEarnest]
as
select a.*,b.GLCostName from
(
	select ClrDate as DocDate,ClrNo as DocNo,JNo as JobNo,UsedAmount-ChargeVAT as DEBIT,0 as CREDIT,CustName,'1130-12' as ACCode  from qJob_ClearDetail
	where SICode in(
		select SICode from Job_SrvSingle where GLAccountCodeCost='1130-12'	
	)
	union
	select ClrDate,ClrNo,JNo,0 as DEBIT,UsedAmount-ChargeVAT as CREDIT,CustName,'1111-00'  from qJob_ClearDetail
	where SICode in(
		select SICode from Job_SrvSingle where GLAccountCodeCost='1130-12'	
	)
) a inner join MAS_GLACCOUNT b
on a.ACCode=b.GLCostCode
GO
/****** Object:  View [dbo].[qGL_RcvEarnest]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create view [dbo].[qGL_RcvEarnest]
as
select a.*,b.GLCostName 
from
(
select ClrDate as DocDate,ClrNo as DocNo,JNo as JobNo,UsedAmount-ChargeVAT-Convert(numeric,substring(Remark,2,charindex(':',Remark,0)-2)) as DEBIT,0 as CREDIT,CustName,'1111-00' as ACCode  from qJob_ClearDetail
where SICode in(
	select SICode from Job_SrvSingle where GLAccountCodeCost='1130-12'	
) and DocStatus=3 and Remark like '#%'
union
select ClrDate as DocDate,ClrNo as DocNo,JNo as JobNo,Convert(numeric,substring(Remark,2,charindex(':',Remark,0)-2)) as DEBIT,0 as CRedit,CustName,'1130-10' as ACCode  from qJob_ClearDetail
where SICode in(
	select SICode from Job_SrvSingle where GLAccountCodeCost='1130-12'	
) and DocStatus=3 and Remark like '#%' and SUBSTRING(Remark,2,1)<>'0'
union
select ClrDate as DocDate,ClrNo as DocNo,JNo as JobNo,0 as DEBIT,UsedAmount-ChargeVAT as CRedit,CustName,'1130-12' as ACCode  from qJob_ClearDetail
where SICode in(
	select SICode from Job_SrvSingle where GLAccountCodeCost='1130-12'	
) and DocStatus=3 and Remark like '#%' 
) a inner join MAS_GLACCOUNT b
on a.ACCode=b.GLCostCode


GO
/****** Object:  View [dbo].[qGL_RcvAR]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[qGL_RcvAR]
as
with recv
as
(	
	select a.*,b.DocNo from
	(
	select ctl.BranchCode,ctl.ControlNo,ctl.VoucherDate,
	SUM(ctl.CashAmount) as Cash,
	SUM(ctl.ChqAmount) as Chq,
	SUM(ISNULL(ctl.CreditAmount,0)) as Credit
	,ctl.PayChqTo,ctl.BookCode,ISNULL(book.EAddress2,'1111-00') as AccCode 
	from qJob_CashControl ctl 
        left join Mas_BookAccount book 
        on ctl.BookCode=book.BookCode
	where ctl.ControlNo in(
	    select ControlNo from Job_CashControlDoc where
	    DocType='INV' And ControlNo=ctl.ControlNo)
	and Not ctl.CancelProve <>''
	group by ctl.BranchCode,ctl.ControlNo,ctl.VoucherDate,ctl.PayChqTo,ctl.BookCode,ISNULL(book.EAddress2,'1111-00')
	) a	inner join Job_CashControlDoc b
	on a.ControlNo=b.ControlNo and a.PayChqTo=b.DocNo
	and b.DocType ='INV' 	
)
select b.TaxInvNo,b.TaxInvDate,b.DocNo,b.JobNo,r.VoucherDate ,SUM(r.Cash) as DEBIT,0 as CREDIT
,b.CustTName as CustName,'1111-00' as ACCode
from recv r inner join qJob_BillHeader b
on r.BranchCode=b.BranchCode and r.DocNo=b.DocNo
and b.TaxInvNo <>'' and not b.CancelProve <>''
and r.Cash>0
group by b.TaxInvNo,b.TaxInvDate ,b.DocNo,b.JobNo,r.VoucherDate,b.CustTName 
union
select b.TaxInvNo,b.TaxInvDate,b.DocNo,b.JobNo,r.VoucherDate ,SUM(r.Chq),0
,b.CustTName as NameEng,r.AccCode as ACCode
from recv r inner join qJob_BillHeader b
on r.BranchCode=b.BranchCode and r.DocNo=b.DocNo
and b.TaxInvNo <>'' and not b.CancelProve <>''
and r.Chq>0
group by b.TaxInvNo,b.TaxInvDate,b.DocNo,b.JobNo,r.VoucherDate,b.CustTName,r.AccCode
union
select b.TaxInvNo,b.TaxInvDate,b.DocNo,b.JobNo,b.DocDate ,b.Total50Tavi2,0
,b.CustTName as NameEng,'1151-13' as ACCode
from qJob_BillHeader b inner join recv r on b.BranchCode=r.BranchCode and b.DocNo=r.DocNo
where b.TaxInvNo <>'' and not b.CancelProve <>''
and b.Total50Tavi2>0 



GO
/****** Object:  View [dbo].[qJob_CustAdvChq]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qJob_CustAdvChq]
AS
SELECT     dbo.Job_CustAdvChq.BranchCode, dbo.Job_CustAdvChq.RefNo, dbo.Job_CustAdvChq.BankCode, dbo.Job_CustAdvChq.ChqNo, 
                      dbo.Job_CustAdvChq.CustCode, dbo.Job_CustAdvChq.CustBranch, dbo.Job_CustAdvChq.ChqDate, dbo.Job_CustAdvChq.ChqAmount, 
                      dbo.Job_CustAdvChq.TotalUsed, dbo.Job_CustAdvChq.PayTo, dbo.Job_CustAdvChq.Remark, dbo.Job_CustAdvChq.RecordDate, 
                      dbo.Job_CustAdvChq.RecordBy, dbo.Job_CustAdvChq.DepBookAcc, dbo.Job_CustAdvChq.DepDate, dbo.Job_CustAdvChq.DepUser, 
                      dbo.Job_CustAdvChq.ApproveBy, dbo.Job_CustAdvChq.ApproveDate, dbo.Job_CustAdvChq.CancelBy, dbo.Job_CustAdvChq.CancelDate, 
                      dbo.Job_CustAdvChq.CancelReason, dbo.Job_CustAdvChq.ClearBy, dbo.Job_CustAdvChq.ClearDate, dbo.Job_CustAdvChq.ControlNo, 
                      dbo.Mas_Company.CustGroup, dbo.Mas_Company.TaxNumber, dbo.Mas_Company.Title, dbo.Mas_Company.NameThai, 
                      dbo.Mas_Company.NameEng
FROM         dbo.Job_CustAdvChq LEFT OUTER JOIN
                      dbo.Mas_Company ON dbo.Job_CustAdvChq.CustCode = dbo.Mas_Company.CustCode AND 
                      dbo.Job_CustAdvChq.CustBranch = dbo.Mas_Company.Branch


GO
/****** Object:  View [dbo].[qGL_CustAdvChq]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qGL_CustAdvChq]
as
select c.*,t.GLCostName
from
(
select RefNo,DepDate,ChqNo,Payto as PayTo,Remark, NameThai,ChqAmount as DEBIT,0 as CREDIT,'1130-03' as ACCode,'S' as ACType from qJob_CustAdvChq
 where ApproveBy<>'' and Not CancelBy <>''
union
select RefNo,DepDate,ChqNo,PayTo,Remark, NameThai,0 as DEBIT,ChqAmount as CREDIT,'1130-11','S' from qJob_CustAdvChq
 where ApproveBy<>'' and Not CancelBy <>''
union 
select a.RefNo,a.DepDate,a.ChqNo,a.PayTo,a.Remark, a.NameThai,a.ChqAmount-SUM(b.PayAmount) as DEBIT,0 as CREDIT,'1130-11' as ACCode,'C' as ACType from qJob_CustAdvChq a
inner join Job_CustAdvChqSub b
on a.BranchCode=b.BranchCode and a.RefNo=b.RefNo
 where a.ApproveBy<>'' And a.ClearBy<>''
 group by a.RefNo,a.DepDate,a.ChqNo,a.NameThai,a.ChqAmount,a.PayTo,a.Remark
union
select a.RefNo,a.DepDate,a.ChqNo,a.PayTo,a.Remark, a.NameThai,0 as DEBIT,a.ChqAmount-SUM(b.PayAmount) as CREDIT,'1130-03' as ACCode,'C' as ACType from qJob_CustAdvChq a
inner join Job_CustAdvChqSub b
on a.BranchCode=b.BranchCode and a.RefNo=b.RefNo
 where a.ApproveBy<>'' And a.ClearBy<>''
 group by a.RefNo,a.DepDate,a.ChqNo,a.NameThai,a.ChqAmount,a.PayTo,a.Remark
) c inner join mas_glaccount t
on c.ACCode=t.GLCostCode
GO
/****** Object:  View [dbo].[q_RcvExport]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE View [dbo].[q_RcvExport]
as
select a.[TaxInvNo]
      ,a.[DocNo]
      ,a.[JobNo]
      ,a.[TaxinvDate]
      ,SUM(a.[DEBIT]) as DEBIT
      ,SUM(a.[CREDIT]) as CREDIT
      ,a.[CustName]
      ,a.[ACCode]
      ,b.GLCostName  from
	  (
			SELECT r.[TaxInvNo]
			--      ,t.[BillingNO] as DocNo
					,(SELECT STUFF(
						(SELECT ',' + DocNo
							FROM Job_BillingHeader WHERE TAxInvNo=r.TaxInvNo
							FOR XML PATH(''),type).value('.','nvarchar(max)'),1,1,''
						)
					) AS [DocNo]
					,(SELECT STUFF(
						(SELECT ',' + JobNo
							FROM Job_BillingHeader WHERE TAxInvNo=r.TaxInvNo
							FOR XML PATH(''),type).value('.','nvarchar(max)'),1,1,''
						)
					) AS [JobNo]
					,r.[VoucherDate]
					,t.InvDate as TaxInvDate
					,SUM(r.[DEBIT]) as DEBIT
					,SUM(r.[CREDIT]) as CREDIT
					,r.[CustName]
					,r.[ACCode]
				FROM [qGL_RcvAR] r inner join [Job_TaxInvoice] t
				on r.TaxInvNo=t.InvNo
				and Not t.CancelProve<>''
				GROUP BY r.TaxInvNo,t.BillingNo,r.VoucherDate,t.InvDate,r.CustName,r.ACCode 

			union
			
				SELECT t.TaxInvNo
					,(SELECT STUFF(
						(SELECT ',' + DocNo
							FROM Job_BillingHeader WHERE TAxInvNo=t.TaxInvNo
							FOR XML PATH(''),type).value('.','nvarchar(max)'),1,1,''
						)
					) AS [BillingNo]
					,(SELECT STUFF(
						(SELECT ',' + JobNo
							FROM Job_BillingHeader WHERE TAxInvNo=t.TaxInvNo
							FOR XML PATH(''),type).value('.','nvarchar(max)'),1,1,''
						)
					) AS [JobNo]
					,t.TaxInvDate as VCDate
					,t.TaxInvDate
					,Sum(t.CREDIT) as DEBIT
					,Sum(t.DEBIT) as CREDIT
					,t.NameThai
					,t.GLCostCode
				FROM Q_TaxExport t
				WHERE t.TaxInvNo<>'' and
				t.DEBIT >0
				and t.GLCostCode in('1130-01','1153-03','1130-01','1130-10')
				group by t.TaxInvNo,t.TaxInvDate,t.NameThai,t.GLCostCode
	 ) a
     inner join 
     MAS_GLACCOUNT b
     on a.ACCode =b.GLCostCode
GROUP BY a.[TaxInvNo]
	  ,a.[DocNo]
	  ,a.[JobNo]
      ,a.[TaxinvDate]
      ,a.[CustName]
      ,a.[ACCode]
      ,b.GLCostName



GO
/****** Object:  View [dbo].[q_StateMentAccount_V2]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[q_StateMentAccount_V2] 
AS
SELECT a.*,isnull(a.[TotalRecieve]-a.[TotalPayMent],0) as Balance,
CASE WHEN b.ChqAmount >0 then 'CH' ELSE (
  CASE WHEN b.CashAmount>0 then 'CA' ELSE 'CR' END
) END as VCType 
FROM [Q_StatementAccount] a left join 
Job_CashControlSub b on
a.ControlNo=b.ControlNo and a.PRVoucher=b.PRVoucher
GO
/****** Object:  View [dbo].[qJob_RClearExp]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_RClearExp]
AS
SELECT        a.BranchCode, a.DocNo, a.DocDate, a.TotalNetCharge, a.TotalCustAdv, a.BillingNo,dbo.qJob_ORder.CustCode, b.ItemNo, b.SDescription, b.TRemark, (CASE WHEN ISNULL(a.CancelProve,'')<>'' THEN 0 ELSE b.AmountCharge END) as AmountCharge, dbo.Job_BillingHeader.ContactName,dbo.qJob_Order.JNo,dbo.qJob_order.JobType,dbo.qJob_Order.ShipBy , dbo.qJob_Order.InvNo, dbo.qJob_Order.InvTotal, 
                         dbo.qJob_Order.InvProduct, dbo.qJob_Order.InvCountry, dbo.qJob_Order.InvFCountry, dbo.qJob_Order.InvInterPort, dbo.qJob_Order.InvProductQty, dbo.qJob_Order.InvProductUnit, dbo.qJob_Order.InvCurUnit, 
                         dbo.qJob_Order.InvCurRate, dbo.qJob_Order.ImExDate, dbo.qJob_Order.BLNo, dbo.qJob_Order.BookingNo, dbo.qJob_Order.ClearPort, dbo.qJob_Order.ClearPortNo, dbo.qJob_Order.LoadDate, dbo.qJob_Order.ForwarderCode, 
                         dbo.qJob_Order.AgentCode, dbo.qJob_Order.VesselName, dbo.qJob_Order.ETDDate, dbo.qJob_Order.ETADate, dbo.qJob_Order.DeclareNumber, dbo.qJob_Order.TotalContainer, dbo.qJob_Order.DutyDate, 
                         dbo.qJob_Order.DutyAmount, dbo.qJob_Order.TotalGW, dbo.qJob_Order.GWUnit, dbo.qJob_Order.MVesselName, dbo.qJob_Order.TotalNW, dbo.qJob_Order.Measurement, dbo.qJob_Order.CustRefNO, dbo.qJob_Order.TotalQty, 
                         dbo.qJob_Order.HAWB, dbo.qJob_Order.MAWB,(CASE WHEN ISNULL(a.CancelProve,'')<>'' THEN '**CANCEL**' ELSE '' END)+ dbo.qJob_Order.NameEng as NameEng, dbo.qJob_Order.CSName, dbo.qJob_Order.ConsigneeName, dbo.qJob_Order.ForwarderName, dbo.qJob_Order.AgentName, 
                         dbo.qJob_Order.EAddress1, dbo.qJob_Order.EAddress2, dbo.qJob_Order.TAddress1, dbo.qJob_Order.TAddress2,
a.CancelProve,a.CancelDate,a.CancelReason 
FROM            dbo.qJob_Order RIGHT OUTER JOIN
                         dbo.Job_BillingHeader ON dbo.qJob_Order.BranchCode = dbo.Job_BillingHeader.BranchCode AND dbo.qJob_Order.JNo = dbo.Job_BillingHeader.JobNo RIGHT OUTER JOIN
                         dbo.Job_RClearExp AS a INNER JOIN
                         dbo.Job_RClearExpSub AS b ON a.BranchCode = b.BranchCode AND a.DocNo = b.DocNo ON dbo.Job_BillingHeader.DocNo = a.BillingNo AND dbo.Job_BillingHeader.BranchCode = a.BranchCode
GO
/****** Object:  View [dbo].[qAlert_M001]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qAlert_M001] AS 
SELECT Job_Order.BranchCode, Job_Order.JobStatus, Job_Order.CSCode, Job_Order.JNo, Job_Controls.ItemNo AS LinkItem, Job_Controls.NDate, Job_Controls.ADate, Year([ADate]) AS AlertYear
FROM Job_Order LEFT JOIN Job_Controls ON (Job_Order.BranchCode = Job_Controls.BranchCode) AND (Job_Order.JNo = Job_Controls.JNo)
WHERE (((Job_Order.JobStatus)=2) AND ((Year([ADate]))>1900))

GO
/****** Object:  View [dbo].[QE_Advance]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[QE_Advance]
AS
SELECT        dbo.Job_AdvDetail.ItemNo, dbo.Job_AdvDetail.STCode, dbo.Job_AdvDetail.SICode, dbo.Job_AdvDetail.AdvAmount, dbo.Job_AdvDetail.IsChargeVAT, dbo.Job_AdvDetail.ChargeVAT, dbo.Job_AdvDetail.Rate50Tavi, 
                         dbo.Job_AdvDetail.Charge50Tavi, dbo.Job_AdvDetail.TRemark, dbo.Job_AdvDetail.IsDuplicate, dbo.Job_AdvDetail.PayChqTo, dbo.Job_AdvDetail.Doc50Tavi, dbo.Job_AdvHeader.BranchCode, dbo.Job_AdvHeader.JNo, 
                         dbo.Job_AdvDetail.AdvNo
FROM            dbo.Job_AdvHeader INNER JOIN
                         dbo.Job_AdvDetail ON dbo.Job_AdvHeader.BranchCode = dbo.Job_AdvDetail.BranchCode AND dbo.Job_AdvHeader.AdvNo = dbo.Job_AdvDetail.AdvNo


GO
/****** Object:  View [dbo].[QE_Clearing]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[QE_Clearing]
AS
SELECT     dbo.Job_ClearHeader.BranchCode, dbo.Job_ClearHeader.JNo, dbo.Job_ClearDetail.ClrNo, dbo.Job_ClearDetail.ItemNo, dbo.Job_ClearDetail.LinkItem, 
                      dbo.Job_ClearDetail.STCode, dbo.Job_ClearDetail.SICode, dbo.Job_ClearDetail.SDescription, dbo.Job_ClearDetail.VenderCode, dbo.Job_ClearDetail.Qty, 
                      dbo.Job_ClearDetail.UnitCode, dbo.Job_ClearDetail.CurrencyCode, dbo.Job_ClearDetail.CurRate, dbo.Job_ClearDetail.UnitPrice, dbo.Job_ClearDetail.FPrice, 
                      dbo.Job_ClearDetail.BPrice, dbo.Job_ClearDetail.QUnitPrice, dbo.Job_ClearDetail.QFPrice, dbo.Job_ClearDetail.QBPrice, dbo.Job_ClearDetail.UnitCost, 
                      dbo.Job_ClearDetail.FCost, dbo.Job_ClearDetail.BCost, dbo.Job_ClearDetail.ChargeVAT, dbo.Job_ClearDetail.Tax50Tavi, dbo.Job_ClearDetail.AdvNO, 
                      dbo.Job_ClearDetail.AdvAmount, dbo.Job_ClearDetail.UsedAmount, dbo.Job_ClearDetail.IsQuoItem, dbo.Job_ClearDetail.SlipNO, dbo.Job_ClearDetail.Remark, 
                      dbo.Job_ClearDetail.IsDuplicate, dbo.Job_ClearDetail.IsLtdAdv50Tavi, dbo.Job_ClearDetail.Pay50TaviTo, dbo.Job_ClearDetail.NO50Tavi, 
                      dbo.Job_ClearDetail.Date50Tavi, dbo.Job_ClearDetail.VenderBillingNo, dbo.Job_ClearDetail.AirQtyStep, dbo.Job_ClearDetail.StepSub, 
                      dbo.Job_ClearDetail.JobNo
FROM         dbo.Job_ClearHeader INNER JOIN
                      dbo.Job_ClearDetail ON dbo.Job_ClearHeader.BranchCode = dbo.Job_ClearDetail.BranchCode AND dbo.Job_ClearHeader.ClrNo = dbo.Job_ClearDetail.ClrNo



GO
/****** Object:  View [dbo].[QE_CustAdvanceCheqHeader]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[QE_CustAdvanceCheqHeader]
AS
SELECT DISTINCT 
                      dbo.Job_CustAdvChq.BranchCode, dbo.Job_CustAdvChqSub.JNO, dbo.Job_CustAdvChq.RefNo, dbo.Job_CustAdvChq.BankCode, 
                      dbo.Job_CustAdvChq.ChqNo, dbo.Job_CustAdvChq.CustCode, dbo.Job_CustAdvChq.CustBranch, dbo.Job_CustAdvChq.ChqDate, 
                      dbo.Job_CustAdvChq.ChqAmount, dbo.Job_CustAdvChq.TotalUsed, dbo.Job_CustAdvChq.PayTo, dbo.Job_CustAdvChq.Remark, 
                      dbo.Job_CustAdvChq.RecordDate, dbo.Job_CustAdvChq.RecordBy, dbo.Job_CustAdvChq.DepBookAcc, dbo.Job_CustAdvChq.DepDate, 
                      dbo.Job_CustAdvChq.DepUser, dbo.Job_CustAdvChq.ApproveBy, dbo.Job_CustAdvChq.ApproveDate, dbo.Job_CustAdvChq.CancelBy, 
                      dbo.Job_CustAdvChq.CancelDate, dbo.Job_CustAdvChq.CancelReason, dbo.Job_CustAdvChq.ClearBy, dbo.Job_CustAdvChq.ClearDate, 
                      dbo.Job_CustAdvChq.ControlNo
FROM         dbo.Job_CustAdvChq INNER JOIN
                      dbo.Job_CustAdvChqSub ON dbo.Job_CustAdvChq.BranchCode = dbo.Job_CustAdvChqSub.BranchCode AND 
                      dbo.Job_CustAdvChq.RefNo = dbo.Job_CustAdvChqSub.RefNo

GO
/****** Object:  View [dbo].[QE_InvoiceAPDetail]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[QE_InvoiceAPDetail]
AS
SELECT        dbo.Job_PaymentHeader.BranchCode, dbo.Job_PaymentHeader.JNo, dbo.Job_PaymentDetail.DocNo, dbo.Job_PaymentDetail.ItemNo, dbo.Job_PaymentDetail.SICode, dbo.Job_PaymentDetail.SDescription, 
                         dbo.Job_PaymentDetail.ExpSlipNO, dbo.Job_PaymentDetail.SRemark, dbo.Job_PaymentDetail.QtyUnit, dbo.Job_PaymentDetail.IsTaxCharge, dbo.Job_PaymentDetail.Is50Tavi, dbo.Job_PaymentDetail.Rate50Tavi, 
                         dbo.Job_PaymentDetail.AmtAdvance, dbo.Job_PaymentDetail.AmtCharge, dbo.Job_PaymentDetail.ForeignAmt, dbo.Job_PaymentDetail.CurrencyCode, dbo.Job_PaymentDetail.ExchangeRate, 
                         dbo.Job_PaymentDetail.CurrencyCodeCredit, dbo.Job_PaymentDetail.ExchangeRateCredit, dbo.Job_PaymentDetail.ForeignAmtCredit, dbo.Job_PaymentDetail.DiscountPerc, dbo.Job_PaymentDetail.AmtDiscount, 
                         dbo.Job_PaymentDetail.ForeignDisc, dbo.Job_PaymentDetail.FUnitPrice, dbo.Job_PaymentDetail.FQty, dbo.Job_PaymentDetail.FTotalAmt
FROM            dbo.Job_PaymentHeader INNER JOIN
                         dbo.Job_PaymentDetail ON dbo.Job_PaymentHeader.BranchCode = dbo.Job_PaymentDetail.BranchCode AND dbo.Job_PaymentHeader.DocNo = dbo.Job_PaymentDetail.DocNo


GO
/****** Object:  View [dbo].[QE_ListSelectJob]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[QE_ListSelectJob]
AS
SELECT        BranchCode, JNo, JRevise, CONVERT(date, ConfirmDate, 103) AS ConfirmDate, CPolicyCode, CONVERT(date, DocDate, 103) AS DocDate, CustCode, CustBranch, QNo, Revise, CSCode, JobStatus, JobType, ShipBy, 
                         CONVERT(date, ETDDate, 103) AS ETDDate, CONVERT(date, ETADate, 103) AS ETADate, HAWB, MAWB
FROM            dbo.Job_Order


GO
/****** Object:  View [dbo].[qJob_AdvMJob]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_AdvMJob] AS 
SELECT Job_AdvMJob.*, Job_Order.ImExDate, Job_Order.TotalGW, Job_Order.GWUnit, Mas_Company.NameThai AS CustName, Mas_User.TName AS EmpName, Job_AdvHeader.DocStatus AS AdvDocStatus
FROM (((Job_AdvMJob LEFT JOIN Job_Order ON (Job_AdvMJob.BranchCode = Job_Order.BranchCode) AND (Job_AdvMJob.JNo = Job_Order.JNo)) LEFT JOIN Mas_Company ON (Job_Order.CustCode = Mas_Company.CustCode) AND (Job_Order.CustBranch = Mas_Company.Branch)) LEFT JOIN Mas_User ON Job_AdvMJob.CSCode = Mas_User.UserID) LEFT JOIN Job_AdvHeader ON (Job_AdvMJob.BranchCode = Job_AdvHeader.BranchCode) AND (Job_AdvMJob.AdvNO = Job_AdvHeader.AdvNo)

GO
/****** Object:  View [dbo].[qJob_ClearMJob]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_ClearMJob] AS 
SELECT Job_ClearMJob.*, Job_ClearHeader.DocStatus, Job_Order.ImExDate, Job_Order.ClearDate, Job_Order.TotalContainer, Job_Order.TotalGW, Job_Order.GWUnit, Mas_Company.NameThai AS CustName, Mas_User.TName AS EmpName, Job_Order.InvNo, Job_ClearHeader.EmpCode
FROM (((Job_ClearMJob LEFT JOIN Job_ClearHeader ON (Job_ClearMJob.BranchCode = Job_ClearHeader.BranchCode) AND (Job_ClearMJob.ClrNO = Job_ClearHeader.ClrNo)) LEFT JOIN Job_Order ON (Job_ClearHeader.BranchCode = Job_Order.BranchCode) AND (Job_ClearHeader.JNo = Job_Order.JNo)) LEFT JOIN Mas_Company ON (Job_Order.CustCode = Mas_Company.CustCode) AND (Job_Order.CustBranch = Mas_Company.Branch)) LEFT JOIN Mas_User ON Job_ClearMJob.CSCode = Mas_User.UserID

GO
/****** Object:  View [dbo].[qJob_Controls]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_Controls] AS 
SELECT Job_Order.CPolicyCode, Job_CPolicyHeader.PolicyName, Job_Controls.BranchCode, Job_Controls.JNo, Job_Controls.ItemNo, Job_Controls.SCID, Job_CPolicyDetail.SCDescription, Job_Controls.EmpCode, Job_Controls.BDate, Job_Controls.BTime, Job_Controls.NDate, Job_Controls.NTime, Job_Controls.ADate, Job_Controls.AlertReson, Job_Controls.UnLockBy, Job_Controls.UnLockDate, Job_Controls.UnLockTime, Job_Controls.TRemark, Job_Controls.DayStart, Job_Controls.DayStartDate, Job_Controls.AmtDHoliday, Job_Controls.AmtDPeriod, Job_Controls.AmtDOverDue, Job_Controls.MaximumDay, Job_Controls.Field1, Job_Controls.Field2, Job_Controls.Field3, Job_Controls.Field4, Job_Controls.Field5, Job_Controls.Field6, Job_Controls.Field7, Job_Controls.Field8, Job_Controls.Field9, Job_Controls.Field10, Job_Order.DocDate
FROM (Job_Order INNER JOIN Job_Controls ON (Job_Order.JNo = Job_Controls.JNo) AND (Job_Order.BranchCode = Job_Controls.BranchCode)) INNER JOIN (Job_CPolicyHeader INNER JOIN Job_CPolicyDetail ON Job_CPolicyHeader.PolicyCode = Job_CPolicyDetail.PolicyCode) ON (Job_Controls.SCID = Job_CPolicyDetail.SCID) AND (Job_Controls.ItemNo = Job_CPolicyDetail.ItemNo) AND (Job_Order.CPolicyCode = Job_CPolicyHeader.PolicyCode)

GO
/****** Object:  View [dbo].[qJob_CoPersonSlip]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_CoPersonSlip] AS 
SELECT Job_CoPersonSlip.*, Mas_TaxCode.TName AS CoPersonName, Job_ClearHeader.JNo, Job_ClearHeader.InvNo, Mas_Company.NameThai AS CustName
FROM (((Job_CoPersonSlip LEFT JOIN Job_ClearHeader ON (Job_CoPersonSlip.BranchCode = Job_ClearHeader.BranchCode) AND (Job_CoPersonSlip.DocNO = Job_ClearHeader.ClrNo)) LEFT JOIN Job_Order ON (Job_ClearHeader.BranchCode = Job_Order.BranchCode) AND (Job_ClearHeader.JNo = Job_Order.JNo)) LEFT JOIN Mas_Company ON (Job_Order.CustCode = Mas_Company.CustCode) AND (Job_Order.CustBranch = Mas_Company.Branch)) LEFT JOIN Mas_TaxCode ON Job_CoPersonSlip.CoPersonCode = Mas_TaxCode.TaxNumber

GO
/****** Object:  View [dbo].[qJob_CustAdvance]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_CustAdvance]
AS
SELECT     dbo.Job_CustAdvHeader.BranchCode, dbo.Job_CustAdvHeader.JNo, dbo.Job_CustAdvHeader.DocNo, dbo.Job_CustAdvHeader.DocDate, 
                      dbo.Job_CustAdvHeader.TotalAdvance, dbo.Job_CustAdvHeader.RefNO, dbo.Job_CustAdvHeader.AdvNo, dbo.Job_CustAdvDetail.ItemNo, 
                      dbo.Job_CustAdvDetail.SICode, dbo.Job_CustAdvDetail.SDescription, dbo.Job_CustAdvDetail.TotalExpense, dbo.Job_CustAdvDetail.PayTo, 
                      dbo.Job_CustAdvDetail.PaySlipNo, dbo.Job_CustAdvDetail.PaySlipDate, dbo.Job_CustAdvDetail.Remark, dbo.Mas_Company.NameEng, 
                      dbo.Mas_Company.NameThai, dbo.Job_Order.CustCode, dbo.Job_Order.CustBranch, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, 
                      dbo.Job_Order.ShipBy, dbo.Job_CustAdvDetail.ReceiptDue, dbo.Job_CustAdvDetail.ReceiptNo, dbo.Job_CustAdvDetail.ReceiptDate
FROM         dbo.Job_CustAdvHeader INNER JOIN
                      dbo.Job_CustAdvDetail ON dbo.Job_CustAdvHeader.DocNo = dbo.Job_CustAdvDetail.DocNo AND 
                      dbo.Job_CustAdvHeader.JNo = dbo.Job_CustAdvDetail.JNo AND 
                      dbo.Job_CustAdvHeader.BranchCode = dbo.Job_CustAdvDetail.BranchCode INNER JOIN
                      dbo.Job_Order ON dbo.Job_CustAdvHeader.JNo = dbo.Job_Order.JNo INNER JOIN
                      dbo.Mas_Company ON dbo.Job_Order.CustBranch = dbo.Mas_Company.Branch AND dbo.Job_Order.CustCode = dbo.Mas_Company.CustCode

GO
/****** Object:  View [dbo].[qJob_CustAdvChqSub]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qJob_CustAdvChqSub]
AS
SELECT     dbo.Job_CustAdvChq.BranchCode, dbo.Job_CustAdvChq.RefNo, dbo.Job_CustAdvChq.BankCode, dbo.Job_CustAdvChq.ChqNo, 
                      dbo.Job_CustAdvChq.CustCode, dbo.Job_CustAdvChq.CustBranch, dbo.Job_CustAdvChq.ChqDate, dbo.Job_CustAdvChq.ChqAmount, 
                      dbo.Job_CustAdvChq.TotalUsed, dbo.Job_CustAdvChq.PayTo, dbo.Job_CustAdvChq.Remark, dbo.Job_CustAdvChq.RecordDate, 
                      dbo.Job_CustAdvChq.RecordBy, dbo.Job_CustAdvChq.DepBookAcc, dbo.Job_CustAdvChq.DepDate, dbo.Job_CustAdvChq.DepUser, 
                      dbo.Job_CustAdvChq.ControlNo, dbo.Job_CustAdvChq.ApproveBy, dbo.Job_CustAdvChq.ApproveDate, dbo.Job_CustAdvChq.CancelBy, 
                      dbo.Job_CustAdvChq.CancelDate, dbo.Job_CustAdvChq.CancelReason, 
                      dbo.Job_CustAdvChqSub.SeqNo, dbo.Job_CustAdvChqSub.JNO, dbo.Job_CustAdvChqSub.PayAmount, 
                      dbo.Job_CustAdvChqSub.Remark AS DRemark, dbo.Job_CustAdvChqSub.BillingNo, dbo.Mas_BankCode.BName AS BankName, 
                      dbo.Job_CustAdvChqSub.SICode, dbo.Job_CustAdvChqSub.ClearingNo, dbo.Job_CustAdvChqSub.ItemNo,
                      dbo.Job_CustAdvChqSub.BillFlag
FROM         dbo.Job_CustAdvChq LEFT OUTER JOIN
                      dbo.Mas_BankCode ON dbo.Job_CustAdvChq.BankCode = dbo.Mas_BankCode.Code LEFT OUTER JOIN
                      dbo.Job_CustAdvChqSub ON dbo.Job_CustAdvChq.BranchCode = dbo.Job_CustAdvChqSub.BranchCode AND 
                      dbo.Job_CustAdvChq.RefNo = dbo.Job_CustAdvChqSub.RefNo


GO
/****** Object:  View [dbo].[qJob_DebitNote]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_DebitNote] AS SELECT a.BranchCode,a.DocNo,a.DocDate,a.InvNo,a.EmpCode,a.ApproveBy,a.ApproveDate,a.ApproveTime,a.Remark,a.VatInclude,a.IsCreditNote,SUM(b.DiffAmt) AS AmtChange,a.VatRate,a.VatAmt,a.TotalNet FROM dbo.Job_DebitNote a INNER JOIN dbo.Job_DebitNoteSub b ON a.BranchCode = b.BranchCode AND a.DocNo = b.DocNo GROUP BY a.BranchCode,a.DocNo,a.DocDate,a.InvNo,a.EmpCode,a.ApproveBy,a.ApproveDate,a.ApproveTime,a.Remark,a.VatInclude,a.IsCreditNote,a.VatRate,a.VatAmt,a.TotalNet
GO
/****** Object:  View [dbo].[qJob_Document]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_Document] AS 
SELECT Job_Document.*, Mas_DocType.DocName, Job_Order.DocDate AS JobDate, Job_Order.ImExDate, Job_Order.CustCode, Job_Order.CustBranch, Job_Order.[CustCode]+'-'+[CustBranch] AS CustID, Mas_Company.NameThai AS CustTName, Mas_User.TName AS CSName
FROM (((Job_Document LEFT JOIN Mas_DocType ON Job_Document.DocType = Mas_DocType.DocType) LEFT JOIN Job_Order ON (Job_Document.BranchCode = Job_Order.BranchCode) AND (Job_Document.JNo = Job_Order.JNo)) LEFT JOIN Mas_Company ON (Job_Order.CustCode = Mas_Company.CustCode) AND (Job_Order.CustBranch = Mas_Company.Branch)) LEFT JOIN Mas_User ON Job_Order.CSCode = Mas_User.UserID

GO
/****** Object:  View [dbo].[qJob_LoadInfo]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_LoadInfo] AS 
SELECT Job_Order.*, Job_LoadInfo.VenderCode, Job_LoadInfo.ContactName, Job_LoadInfoDetail.ItemNo, Job_LoadInfoDetail.CTN_NO, Job_LoadInfoDetail.SealNumber, Job_LoadInfoDetail.TruckNO, Job_LoadInfoDetail.TruckIN, Job_LoadInfoDetail.Start, Job_LoadInfoDetail.Finish, Job_LoadInfoDetail.TimeUsed, Job_LoadInfoDetail.CauseCode, Job_LoadInfoDetail.Comment, [Job_Order].[CustCode]+'-'+[CustBranch] AS CustID, Mas_Company.NameThai AS CustTName, Mas_LoadCause.TName AS LoadCause
FROM (((Job_LoadInfo LEFT JOIN Job_LoadInfoDetail ON (Job_LoadInfo.BranchCode = Job_LoadInfoDetail.BranchCode) AND (Job_LoadInfo.JNo = Job_LoadInfoDetail.JNo)) LEFT JOIN Job_Order ON (Job_LoadInfo.BranchCode = Job_Order.BranchCode) AND (Job_LoadInfo.JNo = Job_Order.JNo)) LEFT JOIN Mas_Company ON (Job_Order.CustCode = Mas_Company.CustCode) AND (Job_Order.CustBranch = Mas_Company.Branch)) LEFT JOIN Mas_LoadCause ON Job_LoadInfoDetail.CauseCode = Mas_LoadCause.Code

GO
/****** Object:  View [dbo].[qJob_PayDetail]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qJob_PayDetail]
AS
SELECT        dbo.Job_PaymentHeader.BranchCode, dbo.Job_PaymentHeader.DocNo, dbo.Job_PaymentHeader.DocDate, dbo.Job_PaymentHeader.JNo, dbo.Job_PaymentHeader.JobBillAmt, dbo.Job_PaymentHeader.CustCode, 
                         dbo.Job_PaymentHeader.CustBranch, dbo.Job_PaymentHeader.BillToCustCode, dbo.Job_PaymentHeader.BillToCustBranch, dbo.Job_PaymentHeader.ContactName, dbo.Job_PaymentHeader.EmpCode, 
                         dbo.Job_PaymentHeader.PrintedBy, dbo.Job_PaymentHeader.PrintedDate, dbo.Job_PaymentHeader.PrintedTime, dbo.Job_PaymentHeader.RefNo, dbo.Job_PaymentHeader.VATRate, dbo.Job_PaymentHeader.Tavi50Rate1, 
                         dbo.Job_PaymentHeader.Tavi50Rate2, dbo.Job_PaymentHeader.TaxInvNo, dbo.Job_PaymentHeader.TaxInvDate, dbo.Job_PaymentHeader.TotalAdvance, dbo.Job_PaymentHeader.TotalCharge, 
                         dbo.Job_PaymentHeader.TotalIsTaxCharge, dbo.Job_PaymentHeader.TotalIs50Tavi1, dbo.Job_PaymentHeader.TotalIs50Tavi2, dbo.Job_PaymentHeader.TotalVAT, dbo.Job_PaymentHeader.Total50Tavi1, 
                         dbo.Job_PaymentHeader.Total50Tavi2, dbo.Job_PaymentHeader.TotalCustAdv, dbo.Job_PaymentHeader.TotalNet, dbo.Job_PaymentHeader.BillDate, dbo.Job_PaymentHeader.BillTime, dbo.Job_PaymentHeader.BillAcceptNo, 
                         dbo.Job_PaymentHeader.PayDate, dbo.Job_PaymentHeader.PayTime, dbo.Job_PaymentHeader.Remark1, dbo.Job_PaymentHeader.Remark2, dbo.Job_PaymentHeader.Remark3, dbo.Job_PaymentHeader.Remark4, 
                         dbo.Job_PaymentHeader.Remark5, dbo.Job_PaymentHeader.Remark6, dbo.Job_PaymentHeader.Remark7, dbo.Job_PaymentHeader.Remark8, dbo.Job_PaymentHeader.Remark9, dbo.Job_PaymentHeader.Remark10, 
                         dbo.Job_PaymentHeader.CancelReson, dbo.Job_PaymentHeader.CancelProve, dbo.Job_PaymentHeader.CancelDate, dbo.Job_PaymentHeader.CancelTime, dbo.Job_PaymentHeader.PaidFlag, 
                         dbo.Job_PaymentHeader.ShippingRemark, dbo.Job_PaymentHeader.CurrencyCode, dbo.Job_PaymentHeader.ExchangeRate, dbo.Job_PaymentHeader.ForeignAmt, dbo.Job_PaymentDetail.ItemNo, 
                         dbo.Job_PaymentDetail.SICode, dbo.Job_PaymentDetail.SDescription, dbo.Job_PaymentDetail.ExpSlipNO, dbo.Job_PaymentDetail.SRemark, dbo.Job_PaymentDetail.QtyUnit, dbo.Job_PaymentDetail.IsTaxCharge, 
                         dbo.Job_PaymentDetail.Is50Tavi, dbo.Job_PaymentDetail.Rate50Tavi, dbo.Job_PaymentDetail.AmtAdvance, dbo.Job_PaymentDetail.AmtCharge, dbo.Job_Order.InvNo, dbo.Job_Order.InvProduct, dbo.Job_Order.VesselName, 
                         dbo.Job_Order.ETADate, dbo.Job_Order.ETDDate, dbo.Mas_Company.Title, dbo.Mas_Company.NameThai, dbo.Mas_Company.NameEng, dbo.Mas_Company.TAddress1, dbo.Mas_Company.TAddress2, 
                         dbo.Mas_Company.EAddress1, dbo.Mas_Company.EAddress2, dbo.Mas_Company.Phone, dbo.Mas_Company.FaxNumber, dbo.Mas_Company.GLAccountCode, dbo.Mas_Company.LevelGrade, 
                         dbo.Mas_Company.TermOfPayment, dbo.Mas_Company.BillCondition, dbo.Mas_Company.CreditLimit, dbo.Mas_Company.DMailAddress
FROM            dbo.Job_PaymentHeader LEFT OUTER JOIN
                         dbo.Job_PaymentDetail ON dbo.Job_PaymentHeader.BranchCode = dbo.Job_PaymentDetail.BranchCode AND dbo.Job_PaymentHeader.DocNo = dbo.Job_PaymentDetail.DocNo LEFT OUTER JOIN
                         dbo.Job_Order ON dbo.Job_PaymentHeader.BranchCode = dbo.Job_Order.BranchCode AND dbo.Job_PaymentHeader.JNo = dbo.Job_Order.JNo LEFT OUTER JOIN
                         dbo.Mas_Company ON dbo.Job_PaymentHeader.BillToCustCode = dbo.Mas_Company.CustCode AND dbo.Job_PaymentHeader.BillToCustBranch = dbo.Mas_Company.Branch


GO
/****** Object:  View [dbo].[qJob_PayHeader]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qJob_PayHeader]
AS
SELECT        dbo.Job_PaymentHeader.CustCode + '-' + dbo.Job_PaymentHeader.CustBranch AS CustID, dbo.Job_PaymentHeader.BranchCode, dbo.Job_PaymentHeader.DocNo, dbo.Job_PaymentHeader.DocDate, 
                         dbo.Job_PaymentHeader.JNo, dbo.Job_PaymentHeader.JobBillAmt, dbo.Job_PaymentHeader.CustCode, dbo.Job_PaymentHeader.CustBranch, dbo.Job_PaymentHeader.BillToCustCode, 
                         dbo.Job_PaymentHeader.BillToCustBranch, dbo.Job_PaymentHeader.ContactName, dbo.Job_PaymentHeader.EmpCode, dbo.Job_PaymentHeader.PrintedBy, dbo.Job_PaymentHeader.PrintedDate, 
                         dbo.Job_PaymentHeader.PrintedTime, dbo.Job_PaymentHeader.RefNo, dbo.Job_PaymentHeader.VATRate, dbo.Job_PaymentHeader.Tavi50Rate1, dbo.Job_PaymentHeader.Tavi50Rate2, dbo.Job_PaymentHeader.TaxInvNo, 
                         dbo.Job_PaymentHeader.TaxInvDate, dbo.Job_PaymentHeader.TotalAdvance, dbo.Job_PaymentHeader.TotalCharge, dbo.Job_PaymentHeader.TotalIsTaxCharge, dbo.Job_PaymentHeader.TotalIs50Tavi1, 
                         dbo.Job_PaymentHeader.TotalIs50Tavi2, dbo.Job_PaymentHeader.TotalVAT, dbo.Job_PaymentHeader.Total50Tavi1, dbo.Job_PaymentHeader.Total50Tavi2, dbo.Job_PaymentHeader.TotalCustAdv, 
                         dbo.Job_PaymentHeader.TotalNet, dbo.Job_PaymentHeader.BillDate, dbo.Job_PaymentHeader.BillTime, dbo.Job_PaymentHeader.BillAcceptNo, dbo.Job_PaymentHeader.PayDate, dbo.Job_PaymentHeader.PayTime, 
                         dbo.Job_PaymentHeader.Remark1, dbo.Job_PaymentHeader.Remark2, dbo.Job_PaymentHeader.Remark3, dbo.Job_PaymentHeader.Remark4, dbo.Job_PaymentHeader.Remark5, dbo.Job_PaymentHeader.Remark6, 
                         dbo.Job_PaymentHeader.Remark7, dbo.Job_PaymentHeader.Remark8, dbo.Job_PaymentHeader.Remark9, dbo.Job_PaymentHeader.Remark10, dbo.Job_PaymentHeader.CancelReson, dbo.Job_PaymentHeader.CancelProve, 
                         dbo.Job_PaymentHeader.CancelDate, dbo.Job_PaymentHeader.CancelTime, dbo.Job_PaymentHeader.PaidFlag, dbo.Job_PaymentHeader.ShippingRemark, dbo.Job_PaymentHeader.CurrencyCode, 
                         dbo.Job_PaymentHeader.ExchangeRate, dbo.Job_PaymentHeader.ForeignAmt, dbo.Job_PaymentHeader.QuatationNo, dbo.Job_PaymentHeader.Revise, dbo.Job_PaymentHeader.JobCustCode, 
                         dbo.Job_PaymentHeader.JobCustBranch, dbo.Mas_Branch.BrName, dbo.Job_Order.DocDate AS JobDate, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, dbo.Mas_Company.NameThai AS CustTName,
                          dbo.Mas_Company.NameEng AS CustEName, dbo.Mas_Company.LevelGrade, dbo.Mas_Company.CreditLimit
FROM            dbo.Job_PaymentHeader LEFT OUTER JOIN
                         dbo.Mas_Branch ON dbo.Job_PaymentHeader.BranchCode = dbo.Mas_Branch.Code LEFT OUTER JOIN
                         dbo.Mas_Company ON dbo.Job_PaymentHeader.CustCode = dbo.Mas_Company.CustCode AND dbo.Job_PaymentHeader.CustBranch = dbo.Mas_Company.Branch LEFT OUTER JOIN
                         dbo.Job_Order ON dbo.Job_PaymentHeader.BranchCode = dbo.Job_Order.BranchCode AND dbo.Job_PaymentHeader.JNo = dbo.Job_Order.JNo


GO
/****** Object:  View [dbo].[qJob_Quotation]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*SELECT     dbo.Job_QuoHeader.BranchCode, dbo.Job_QuoHeader.QNo, dbo.Job_QuoHeader.Revise, dbo.Job_QuoHeader.ReferQNo, 
                      dbo.Job_QuoHeader.CustCode, dbo.Job_QuoHeader.CustBranch, dbo.Mas_Company.NameThai, dbo.Mas_Company.NameEng, 
                      dbo.Mas_Company.TAddress1, dbo.Mas_Company.TAddress2, dbo.Mas_Company.EAddress1, dbo.Mas_Company.EAddress2, 
                      dbo.Job_QuoHeader.ContactName, dbo.Job_QuoHeader.DocDate, dbo.Job_QuoHeader.ManagerCode, Mas_User_1.TName AS IssueName, 
                      dbo.Job_QuoHeader.DescriptionH, dbo.Job_QuoHeader.DescriptionF, dbo.Job_QuoHeader.TRemark, dbo.Job_QuoHeader.ApproveBy, 
                      dbo.Mas_User.TName AS ApproveName, dbo.Job_QuoHeader.ApproveDate, dbo.Job_QuoHeader.ApproveTime, dbo.Job_QuoDetail.ItemNo, 
                      dbo.Job_QuoDetail.LinkItem, dbo.Job_QuoDetail.Description, dbo.Job_QuoDetail.TotalPrice, dbo.Job_QuoDetail.UnitCode, 
                      dbo.Job_QuoDetailItem.STCode, dbo.Job_QuoDetailItem.SICode, dbo.Job_QuoDetailItem.NameThai AS SDescription, 
                      dbo.Job_QuoDetailItem.VenderCode, dbo.Job_QuoDetailItem.UnitCharge, dbo.Job_QuoDetailItem.UnitPrice, dbo.Job_QuoDetailItem.CurrencyCode, 
                      dbo.Job_QuoDetailItem.Start, dbo.Job_QuoDetailItem.Endding, dbo.Job_QuoDetailItem.CY, dbo.Job_QuoDetailItem.QtyStep, 
                      dbo.Job_QuoDetailItem.StepSub, dbo.Job_QuoDetailItem.IsPrintPrice, dbo.Job_QuoDetailItem.IsShowOnPrint, dbo.Job_QuoDetailItem.PrivoteType, 
                      Mas_User_1.EMail
FROM         dbo.Mas_Company RIGHT OUTER JOIN
                      dbo.Job_QuoHeader ON dbo.Mas_Company.CustCode = dbo.Job_QuoHeader.CustCode AND 
                      dbo.Mas_Company.Branch = dbo.Job_QuoHeader.CustBranch LEFT OUTER JOIN
                      dbo.Job_QuoDetailItem RIGHT OUTER JOIN
                      dbo.Job_QuoDetail ON dbo.Job_QuoDetailItem.BranchCode = dbo.Job_QuoDetail.BranchCode AND 
                      dbo.Job_QuoDetailItem.QNo = dbo.Job_QuoDetail.QNo AND dbo.Job_QuoDetailItem.Revise = dbo.Job_QuoDetail.Revise ON 
                      dbo.Job_QuoHeader.BranchCode = dbo.Job_QuoDetail.BranchCode AND dbo.Job_QuoHeader.QNo = dbo.Job_QuoDetail.QNo AND 
                      dbo.Job_QuoHeader.Revise = dbo.Job_QuoDetail.Revise LEFT OUTER JOIN
                      dbo.Mas_User AS Mas_User_1 ON dbo.Job_QuoHeader.ManagerCode = Mas_User_1.UserID LEFT OUTER JOIN*/
CREATE VIEW [dbo].[qJob_Quotation]
AS
SELECT     dbo.Job_QuoHeader.BranchCode, dbo.Job_QuoHeader.QNo, dbo.Job_QuoHeader.Revise, dbo.Job_QuoHeader.ReferQNo, 
                      dbo.Job_QuoHeader.CustCode, dbo.Job_QuoHeader.CustBranch, dbo.Mas_Company.NameThai, dbo.Mas_Company.NameEng, 
                      dbo.Mas_Company.TAddress1, dbo.Mas_Company.TAddress2, dbo.Mas_Company.EAddress1, dbo.Mas_Company.EAddress2, 
                      dbo.Job_QuoHeader.ContactName, dbo.Job_QuoHeader.DocDate, dbo.Job_QuoHeader.ManagerCode, Mas_User_1.TName AS IssueName, 
                      dbo.Job_QuoHeader.DescriptionH, dbo.Job_QuoHeader.DescriptionF, dbo.Job_QuoHeader.TRemark, dbo.Job_QuoHeader.ApproveBy, 
                      dbo.Mas_User.TName AS ApproveName, dbo.Job_QuoHeader.ApproveDate, dbo.Job_QuoHeader.ApproveTime, dbo.Job_QuoDetail.ItemNo, 
                      dbo.Job_QuoDetail.LinkItem, dbo.Job_QuoDetail.Description, dbo.Job_QuoDetail.TotalPrice, dbo.Job_QuoDetail.UnitCode, 
                      dbo.Job_QuoDetailItem.STCode, dbo.Job_QuoDetailItem.SICode, dbo.Job_QuoDetailItem.NameThai AS SDescription, 
                      dbo.Job_QuoDetailItem.VenderCode, dbo.Job_QuoDetailItem.UnitCharge, dbo.Job_QuoDetailItem.UnitPrice, dbo.Job_QuoDetailItem.CurrencyCode, 
                      dbo.Job_QuoDetailItem.Start, dbo.Job_QuoDetailItem.Endding, dbo.Job_QuoDetailItem.CY, dbo.Job_QuoDetailItem.QtyStep, 
                      dbo.Job_QuoDetailItem.StepSub, dbo.Job_QuoDetailItem.IsPrintPrice, dbo.Job_QuoDetailItem.IsShowOnPrint, dbo.Job_QuoDetailItem.PrivoteType, 
                      Mas_User_1.EMail, dbo.Mas_Company.BillToCustCode, dbo.Mas_Company.BillToBranch, dbo.Job_QuoDetailItem.UnitCost, 
                      dbo.Job_QuoDetailItem.UnitQTY, dbo.Job_QuoDetailItem.CurrencyRate, dbo.Job_QuoDetailItem.Isvat, dbo.Job_QuoDetailItem.VatRate, 
                      dbo.Job_QuoDetailItem.VatAmt, dbo.Job_QuoDetailItem.IsTax, dbo.Job_QuoDetailItem.TaxRate, dbo.Job_QuoDetailItem.TaxAmt, 
                      dbo.Job_QuoDetailItem.TotalAmt, dbo.Job_QuoDetailItem.CurrentTHB, dbo.Job_QuoDetailItem.UnitDiscntPerc, 
                      dbo.Job_QuoDetailItem.UnitDiscntAmt
FROM         dbo.Mas_Company RIGHT OUTER JOIN
                      dbo.Job_QuoHeader ON dbo.Mas_Company.CustCode = dbo.Job_QuoHeader.CustCode AND 
                      dbo.Mas_Company.Branch = dbo.Job_QuoHeader.CustBranch LEFT OUTER JOIN
                      dbo.Job_QuoDetailItem RIGHT OUTER JOIN
                      dbo.Job_QuoDetail ON dbo.Job_QuoDetailItem.LinkItem = dbo.Job_QuoDetail.LinkItem AND 
                      dbo.Job_QuoDetailItem.BranchCode = dbo.Job_QuoDetail.BranchCode AND dbo.Job_QuoDetailItem.QNo = dbo.Job_QuoDetail.QNo ON 
                      dbo.Job_QuoHeader.BranchCode = dbo.Job_QuoDetail.BranchCode AND dbo.Job_QuoHeader.QNo = dbo.Job_QuoDetail.QNo AND 
                      dbo.Job_QuoHeader.Revise = dbo.Job_QuoDetail.Revise LEFT OUTER JOIN
                      dbo.Mas_User AS Mas_User_1 ON dbo.Job_QuoHeader.ManagerCode = Mas_User_1.UserID LEFT OUTER JOIN
                      dbo.Mas_User ON dbo.Job_QuoHeader.ApproveBy = dbo.Mas_User.UserID

GO
/****** Object:  View [dbo].[qJob_RefundTax]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_RefundTax] AS SELECT dbo.Job_RefundTaxHeader.RefundNo, dbo.Job_RefundTaxHeader.SendDate, dbo.Job_RefundTaxHeader.ReDate, dbo.Job_RefundTaxHeader.ClaimNo,dbo.Job_RefundTaxHeader.ClaimDate, dbo.Job_RefundTaxHeader.TaxCardDate, dbo.Job_RefundTaxDetail.DNo,dbo.Job_RefundTaxDetail.DeclareNumber, dbo.Job_RefundTaxDetail.ExDate, dbo.Job_RefundTaxDetail.Product, dbo.Job_RefundTaxDetail.FOB,dbo.Job_RefundTaxDetail.NetWeight, dbo.Job_RefundTaxDetail.GFrom, dbo.Job_RefundTaxDetail.TTariff, dbo.Job_RefundTaxDetail.TRate,dbo.Job_RefundTaxDetail.TAmount, dbo.Job_RefundTaxDetail.INVNo FROM dbo.Job_RefundTaxHeader LEFT OUTER JOIN dbo.Job_RefundTaxDetail ON dbo.Job_RefundTaxHeader.RefundNo = dbo.Job_RefundTaxDetail.RefundNo

GO
/****** Object:  View [dbo].[qJob_Shipping]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_Shipping] AS 
SELECT Job_Order.BranchCode, Job_Order.ShippingEmp, Job_Order.ImExDate, Job_Order.ClearPort, Job_Order.JNo, Job_Order.JobType, Mas_User.TName AS EmpName, Job_Order.JobStatus, Job_Order.ShipBy
FROM Job_Order LEFT JOIN Mas_User ON Job_Order.ShippingEmp=Mas_User.UserID
WHERE (((Job_Order.JobStatus)=2))

GO
/****** Object:  View [dbo].[qJob_SumCost]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_SumCost] AS 
SELECT Job_Detail.BranchCode, Job_Detail.JNo, Sum(Job_Detail.QBPrice) AS SumQPrice, Sum(Job_Detail.BPrice) AS SumPrice, Sum(Job_Detail.BCost) AS SumCost, Sum([BPrice]-[BCost]) AS Profit
FROM Job_Detail
GROUP BY Job_Detail.BranchCode, Job_Detail.JNo

GO
/****** Object:  View [dbo].[qJob_Tax50Tavi]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_Tax50Tavi]
AS
SELECT [BranchCode]
      ,[DocNo]
      ,[JNo]
      ,[DocRefType]
      ,[DocRefNo]
      ,[DocDate]
      ,[TaxNumber1]
      ,[IDCard1]
      ,[TName1]
      ,[TAddress1]
      ,[TaxNumber2]
      ,[IDCard2]
      ,[TName2]
      ,[TAddress2]
      ,[TaxNumber3]
      ,[IDCard3]
      ,[TName3]
      ,[TAddress3]
      ,[SeqInForm]
      ,[FormType]
      ,[IncRate]
      ,[IncOther]
      ,[IncType1] as IncType
      ,[PayDate1] as PayDate
      ,[PayAmount1] as PayAmt
      ,[PayTax1] as PayTax
	  ,[PayTaxDesc1] as PayTaxDesc
      ,[TotalPayAmount]
      ,[TotalPayTax]
      ,[SoLicenseNo]
      ,[SoLicenseAmount]
      ,[SoAccAmount]
      ,[PayeeAccNo]
      ,[SoTaxNo]
      ,[PayTaxType]
      ,[PayTaxOther]        
      ,[TaxLawNo]
FROM [Job_Tax50Tavi]
WHERE PayAmount1>0
UNION
SELECT [BranchCode]
      ,[DocNo]
      ,[JNo]
      ,[DocRefType]
      ,[DocRefNo]
      ,[DocDate]
      ,[TaxNumber1]
      ,[IDCard1]
      ,[TName1]
      ,[TAddress1]
      ,[TaxNumber2]
      ,[IDCard2]
      ,[TName2]
      ,[TAddress2]
      ,[TaxNumber3]
      ,[IDCard3]
      ,[TName3]
      ,[TAddress3]
      ,[SeqInForm]
      ,[FormType]
      ,[IncRate]
      ,[IncOther]
      ,[IncType2]
      ,[PayDate2]
      ,[PayAmount2]
      ,[PayTax2]
	  ,[PayTaxDesc2]
      ,[TotalPayAmount]
      ,[TotalPayTax]
      ,[SoLicenseNo]
      ,[SoLicenseAmount]
      ,[SoAccAmount]
      ,[PayeeAccNo]
      ,[SoTaxNo]
      ,[PayTaxType]
      ,[PayTaxOther]        
      ,[TaxLawNo]
FROM [Job_Tax50Tavi]
WHERE PayAmount2>0
UNION
SELECT [BranchCode]
      ,[DocNo]
      ,[JNo]
      ,[DocRefType]
      ,[DocRefNo]
      ,[DocDate]
      ,[TaxNumber1]
      ,[IDCard1]
      ,[TName1]
      ,[TAddress1]
      ,[TaxNumber2]
      ,[IDCard2]
      ,[TName2]
      ,[TAddress2]
      ,[TaxNumber3]
      ,[IDCard3]
      ,[TName3]
      ,[TAddress3]
	  ,[SeqInForm]
      ,[FormType]
      ,[IncRate]
      ,[IncOther]
      ,[IncType3]
      ,[PayDate3]
      ,[PayAmount3]
      ,[PayTax3]
	  ,[PayTaxDesc3]
      ,[TotalPayAmount]
      ,[TotalPayTax]
      ,[SoLicenseNo]
      ,[SoLicenseAmount]
      ,[SoAccAmount]
      ,[PayeeAccNo]
      ,[SoTaxNo]
      ,[PayTaxType]
      ,[PayTaxOther]        
      ,[TaxLawNo]
FROM [Job_Tax50Tavi]
WHERE PayAmount3>0
GO
/****** Object:  View [dbo].[qJob_TaxInvDetail]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_TaxInvDetail]
AS
SELECT        dbo.Job_TaxInvoice.BranchCode, dbo.Job_TaxInvoice.InvNo, dbo.Job_TaxInvoice.InvDate, dbo.Job_TaxInvoice.CustCode, dbo.Job_TaxInvoice.CustBranch, dbo.Job_TaxInvoice.BillToCustCode, 
                         dbo.Job_TaxInvoice.BillToCustBranch, 
						 						 (SELECT STUFF(
						(SELECT ',' + DocNo
							FROM Job_BillingHeader WHERE TAxInvNo=dbo.Job_TaxInvoice.InvNo
							FOR XML PATH(''),type).value('.','nvarchar(max)'),1,1,''
						)
					     ) AS BillingNo
						 , dbo.Job_TaxInvoice.VATRate, dbo.Job_TaxInvoice.TotalCharge, dbo.Job_TaxInvoice.TotalVAT, dbo.Job_TaxInvoice.Total50Tavi, 
                         dbo.Job_TaxInvoice.TotalNet, dbo.Job_TaxInvoice.TRemark, dbo.Job_TaxInvoice.EmpCode, dbo.Job_TaxInvoice.PrintedBy, dbo.Job_TaxInvoice.PrintedDate, dbo.Job_TaxInvoice.PrintedTime, dbo.Job_TaxInvoice.ReceiveBy, 
                         dbo.Job_TaxInvoice.ReceiveDate, dbo.Job_TaxInvoice.ReceiveTime, dbo.Job_TaxInvoice.ReceiveRef, dbo.Job_TaxInvoice.CancelReson, dbo.Job_TaxInvoice.CancelProve, dbo.Job_TaxInvoice.CancelDate, 
                         dbo.Job_TaxInvoice.CancelTime, dbo.Job_TaxInvoice.CurrencyCode, dbo.Job_TaxInvoice.ExchangeRate, dbo.Job_TaxInvoice.ForeignAmt, dbo.Job_TaxInvoiceDetail.ItemNo, dbo.Job_TaxInvoiceDetail.SICode, 
                         dbo.Job_TaxInvoiceDetail.SDescription, dbo.Job_TaxInvoiceDetail.Rate50Tavi, dbo.Job_TaxInvoiceDetail.AmtCharge, dbo.Job_TaxInvoiceDetail.AmtVAT, dbo.Job_TaxInvoiceDetail.Amt50Tavi, dbo.Mas_Company.TaxNumber, 
                         dbo.Mas_Company.Title, dbo.Mas_Company.NameThai, dbo.Mas_Company.NameEng, dbo.Job_TaxInvoiceDetail.Qty, dbo.Job_TaxInvoiceDetail.UnitPrice, dbo.Job_TaxInvoiceDetail.QtyUnit, dbo.Mas_Company.TAddress1, 
                         dbo.Mas_Company.TAddress2, dbo.Mas_Company.EAddress1, dbo.Mas_Company.EAddress2,dbo.Mas_Company.Phone,dbo.Mas_Company.FaxNumber
FROM            dbo.Job_TaxInvoice LEFT OUTER JOIN
                         dbo.Job_TaxInvoiceDetail ON dbo.Job_TaxInvoice.BranchCode = dbo.Job_TaxInvoiceDetail.BranchCode AND dbo.Job_TaxInvoice.InvNo = dbo.Job_TaxInvoiceDetail.InvNo LEFT OUTER JOIN
                         dbo.Mas_Company ON dbo.Job_TaxInvoice.BillToCustCode = dbo.Mas_Company.CustCode AND dbo.Job_TaxInvoice.BillToCustBranch = dbo.Mas_Company.Branch

GO
/****** Object:  View [dbo].[qJob_TaxInvHeader]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_TaxInvHeader] 
AS
SELECT        dbo.Job_TaxInvoice.BranchCode, dbo.Job_TaxInvoice.InvNo, dbo.Job_TaxInvoice.InvDate, dbo.Job_TaxInvoice.CustCode, dbo.Job_TaxInvoice.CustBranch, dbo.Job_TaxInvoice.BillToCustCode, 
                         dbo.Job_TaxInvoice.BillToCustBranch, 
						 (SELECT STUFF(
						(SELECT ',' + DocNo
							FROM Job_BillingHeader WHERE TAxInvNo=dbo.Job_TaxInvoice.InvNo
							FOR XML PATH(''),type).value('.','nvarchar(max)'),1,1,''
						)
					     ) AS BillingNo
						 , 
						 dbo.Job_TaxInvoice.VATRate, dbo.Job_TaxInvoice.TotalCharge, dbo.Job_TaxInvoice.TotalVAT, dbo.Job_TaxInvoice.Total50Tavi, 
                         dbo.Job_TaxInvoice.TotalNet, dbo.Job_TaxInvoice.TRemark, dbo.Job_TaxInvoice.EmpCode, dbo.Job_TaxInvoice.PrintedBy, dbo.Job_TaxInvoice.PrintedDate, dbo.Job_TaxInvoice.PrintedTime, dbo.Job_TaxInvoice.ReceiveBy, 
                         dbo.Job_TaxInvoice.ReceiveDate, dbo.Job_TaxInvoice.ReceiveTime, dbo.Job_TaxInvoice.ReceiveRef, dbo.Job_TaxInvoice.CancelReson, dbo.Job_TaxInvoice.CancelProve, dbo.Job_TaxInvoice.CancelDate, 
                         dbo.Job_TaxInvoice.CancelTime, dbo.Job_TaxInvoice.CurrencyCode, dbo.Job_TaxInvoice.ExchangeRate, dbo.Job_TaxInvoice.ForeignAmt, dbo.Job_TaxInvoice.CashDate, dbo.Job_TaxInvoice.CashAmount, 
                         dbo.Job_TaxInvoice.Transferdate, dbo.Job_TaxInvoice.TransferBank, dbo.Job_TaxInvoice.TransferAmount, dbo.Job_TaxInvoice.CheqDate, dbo.Job_TaxInvoice.CheqBank, dbo.Job_TaxInvoice.CheqAmount, 
                         dbo.Job_TaxInvoice.CustCode + '-' + dbo.Job_TaxInvoice.CustBranch AS CustID, dbo.Mas_Company.NameThai AS CustTName, dbo.Mas_Company.NameEng AS CustEName, dbo.Mas_Company.LevelGrade, 
                         dbo.Mas_Company.CreditLimit, dbo.Mas_User.TName AS EmpName
FROM            dbo.Job_TaxInvoice LEFT OUTER JOIN
                         dbo.Mas_Company ON dbo.Job_TaxInvoice.CustCode = dbo.Mas_Company.CustCode AND dbo.Job_TaxInvoice.CustBranch = dbo.Mas_Company.Branch LEFT OUTER JOIN
                         dbo.Mas_User ON dbo.Job_TaxInvoice.ReceiveBy = dbo.Mas_User.UserID
GO
/****** Object:  View [dbo].[qReport_Job_Billing]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qReport_Job_Billing]
AS
SELECT        dbo.Job_BillingHeader.BranchCode, dbo.Job_BillingHeader.BillToCustCode, dbo.Job_BillingHeader.BillToCustBranch, dbo.Mas_Company.Title, 
                         dbo.Mas_Company.NameThai, dbo.Mas_Company.NameEng, dbo.Mas_Company.TAddress1, dbo.Mas_Company.TAddress2, dbo.Mas_Company.EAddress1, 
                         dbo.Mas_Company.EAddress2, dbo.Job_BillingHeader.TotalAdvance, dbo.Job_BillingHeader.TotalCharge, dbo.Job_BillingHeader.TotalIsTaxCharge, 
                         dbo.Job_BillingHeader.TotalIs50Tavi1, dbo.Job_BillingHeader.TotalIs50Tavi2, dbo.Job_BillingHeader.TotalVAT, dbo.Job_BillingHeader.Total50Tavi1, 
                         dbo.Job_BillingHeader.Total50Tavi2, dbo.Job_BillingHeader.TotalCustAdv, dbo.Job_BillingHeader.TotalNet, dbo.Job_BillingHeader.PayDate, dbo.Job_Order.JNo, 
                         dbo.Job_Order.DocDate AS JobDate, dbo.Job_Order.CustCode, dbo.Job_Order.CustBranch, dbo.Job_Order.CSCode, dbo.Job_Order.JobStatus, 
                         dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, dbo.Job_CashControlDoc.DocType, dbo.Job_CashControlDoc.ControlNo, dbo.Job_BillingHeader.CancelReson, 
                         dbo.Job_BillingHeader.CancelProve, dbo.Job_BillingHeader.CancelDate, dbo.Job_BillingHeader.DocDate, dbo.Job_BillingHeader.DocNo
FROM            dbo.Job_BillingHeader INNER JOIN
                         dbo.Job_Order ON dbo.Job_BillingHeader.BranchCode = dbo.Job_Order.BranchCode AND dbo.Job_BillingHeader.JobNo = dbo.Job_Order.JNo INNER JOIN
                         dbo.Mas_Company ON dbo.Job_BillingHeader.BillToCustCode = dbo.Mas_Company.CustCode AND 
                         dbo.Job_BillingHeader.BillToCustBranch = dbo.Mas_Company.Branch LEFT OUTER JOIN
                         dbo.Job_CashControlDoc ON dbo.Job_BillingHeader.BranchCode = dbo.Job_CashControlDoc.BranchCode AND 
                         dbo.Job_BillingHeader.DocNo = dbo.Job_CashControlDoc.DocNo


GO
/****** Object:  View [dbo].[vAdv_all]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vAdv_all]
AS
SELECT DISTINCT 
                      a.BranchCode, a.EmpCode, a.JNo, a.DocStatus, a.AdvNo, a.AdvDate, a.TotalAdvance, b.ClrNo, b.DocStatus AS ClrStatus, b.ClrDate, b.TotalExpense, 
                      b.ReceiveRef, b.TRemark, c.PaidAmount, c.TotalAmount, a.JobType, dbo.Job_Order.ShipBy, dbo.Job_Order.CustCode, dbo.Job_Order.CustBranch
FROM         dbo.Job_AdvHeader AS a LEFT OUTER JOIN
                      dbo.Job_Order ON a.JNo = dbo.Job_Order.JNo AND a.BranchCode = dbo.Job_Order.BranchCode LEFT OUTER JOIN
                      dbo.Job_ClearHeader AS b LEFT OUTER JOIN
                      dbo.Job_CashControlDoc AS c ON b.ClrNo = c.DocNo ON a.AdvNo = b.AdvRefNo
WHERE     (a.DocStatus < 99)


GO
/****** Object:  View [dbo].[vADV_UnClear]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vADV_UnClear] as SELECT DISTINCT dbo.Job_AdvHeader.*, ISNULL(dbo.Job_ClearHeader.DocStatus, 0) AS clrStatus FROM dbo.Job_ClearHeader RIGHT OUTER JOIN dbo.Job_ClearDetail ON dbo.Job_ClearHeader.ClrNo = dbo.Job_ClearDetail.ClrNo RIGHT OUTER JOIN dbo.Job_AdvHeader ON dbo.Job_ClearDetail.AdvNO = dbo.Job_AdvHeader.AdvNo WHERE (dbo.Job_AdvHeader.DocStatus <= 4) AND (ISNULL(dbo.Job_ClearHeader.DocStatus, 0) <= 2)

GO
/****** Object:  View [dbo].[vCheque]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vCheque]
AS
SELECT     dbo.ChequeHeader.*, dbo.ChequeDetail.Seq, dbo.ChequeDetail.JobNo, dbo.ChequeDetail.Expense, dbo.ChequeDetail.Amount, dbo.ChequeDetail.VoucherNo, 
                      dbo.Mas_Company.TaxNumber, dbo.Mas_Company.NameThai, dbo.Mas_Company.TAddress1, dbo.Mas_Company.TAddress2, dbo.Mas_Company.Phone, 
                      dbo.Mas_Company.FaxNumber
FROM         dbo.ChequeHeader LEFT OUTER JOIN
                      dbo.Mas_Company ON dbo.ChequeHeader.CustCode = dbo.Mas_Company.CustCode LEFT OUTER JOIN
                      dbo.ChequeDetail ON dbo.ChequeHeader.BankID = dbo.ChequeDetail.BankID AND dbo.ChequeHeader.ChequeNo = dbo.ChequeDetail.ChequeNo

GO
/****** Object:  View [dbo].[vChequeHeader]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vChequeHeader]
AS
SELECT     dbo.ChequeHeader.BankID, dbo.ChequeHeader.ChequeNo, dbo.ChequeHeader.ChequeType, dbo.ChequeHeader.ChequeDate, dbo.ChequeHeader.IssueDate, 
                      dbo.ChequeHeader.IssueBy, dbo.ChequeHeader.CustCode, dbo.ChequeHeader.PayTo, dbo.ChequeHeader.Total, dbo.ChequeHeader.ChequeStatus, 
                      dbo.ChequeHeader.BookNo, dbo.ChequeHeader.HaveSquare, dbo.ChequeHeader.Payee, dbo.ChequeHeader.HaveLine, dbo.ChequeHeader.Remark, 
                      dbo.ChequeHeader.Printed, dbo.Mas_Company.NameThai, dbo.Mas_Company.TAddress1, dbo.Mas_Company.TAddress2, dbo.Mas_Company.Phone, 
                      dbo.Mas_Company.FaxNumber, dbo.Mas_Company.TaxNumber
FROM         dbo.ChequeHeader LEFT OUTER JOIN
                      dbo.Mas_Company ON dbo.ChequeHeader.CustCode = dbo.Mas_Company.CustCode

GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_BudgetPolicy]    Script Date: 08-Mar-19 11:31:25 AM ******/
CREATE NONCLUSTERED INDEX [IDX_BudgetPolicy] ON [dbo].[Job_BudgetPolicy]
(
	[Active] ASC,
	[BranchCode] ASC,
	[JobType] ASC,
	[ShipBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Job_AdvDetail] ADD  DEFAULT ((1)) FOR [ExchangeRate]
GO
ALTER TABLE [dbo].[Job_AdvDetail] ADD  DEFAULT ((1)) FOR [AdvQty]
GO
ALTER TABLE [dbo].[Job_AdvDetail] ADD  DEFAULT ((1)) FOR [UnitPrice]
GO
ALTER TABLE [dbo].[Job_AdvHeader] ADD  DEFAULT ((1)) FOR [ExchangeRate]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_ItemNo]  DEFAULT ((0)) FOR [ItemNo]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_IsTaxCharge]  DEFAULT ((0)) FOR [IsTaxCharge]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_Is50Tavi]  DEFAULT ((0)) FOR [Is50Tavi]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_Rate50Tavi]  DEFAULT ((0)) FOR [Rate50Tavi]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_AmtAdvance]  DEFAULT ((0)) FOR [AmtAdvance]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_AmtCharge]  DEFAULT ((0)) FOR [AmtCharge]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_ForeignAmt]  DEFAULT ((0)) FOR [ForeignAmt]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_ExchangeRate]  DEFAULT ((1)) FOR [ExchangeRate]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_ExchangeRateCredit]  DEFAULT ((0)) FOR [ExchangeRateCredit]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_ForeignAmtCredit]  DEFAULT ((0)) FOR [ForeignAmtCredit]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_DiscountPerc]  DEFAULT ((0)) FOR [DiscountPerc]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_AmtDiscount]  DEFAULT ((0)) FOR [AmtDiscount]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_ForeignDisc]  DEFAULT ((0)) FOR [ForeignDisc]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_FUnitPrice]  DEFAULT ((0)) FOR [FUnitPrice]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_FQty]  DEFAULT ((0)) FOR [FQty]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_FTotalAmt]  DEFAULT ((0)) FOR [FTotalAmt]
GO
ALTER TABLE [dbo].[Job_BillingHeader] ADD  CONSTRAINT [DF_Job_BillingHeader_Revise]  DEFAULT ((0)) FOR [Revise]
GO
ALTER TABLE [dbo].[Job_OSRCreditNote] ADD  CONSTRAINT [DF_Job_KSACreditNote_TotalCharge]  DEFAULT ((0)) FOR [TotalCharge]
GO
ALTER TABLE [dbo].[Job_OSRCreditNote] ADD  CONSTRAINT [DF_Job_KSACreditNote_TotalVAT]  DEFAULT ((0)) FOR [TotalVAT]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_ItemNo]  DEFAULT ((0)) FOR [ItemNo]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_IsTaxCharge]  DEFAULT ((0)) FOR [IsTaxCharge]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_Is50Tavi]  DEFAULT ((0)) FOR [Is50Tavi]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_Rate50Tavi]  DEFAULT ((0)) FOR [Rate50Tavi]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_AmtAdvance]  DEFAULT ((0)) FOR [AmtAdvance]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_AmtCharge]  DEFAULT ((0)) FOR [AmtCharge]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_ForeignAmt]  DEFAULT ((0)) FOR [ForeignAmt]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_ExchangeRate]  DEFAULT ((0)) FOR [ExchangeRate]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_ExchangeRateCredit]  DEFAULT ((0)) FOR [ExchangeRateCredit]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_ForeignAmtCredit]  DEFAULT ((0)) FOR [ForeignAmtCredit]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_DiscountPerc]  DEFAULT ((0)) FOR [DiscountPerc]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_AmtDiscount]  DEFAULT ((0)) FOR [AmtDiscount]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_ForeignDisc]  DEFAULT ((0)) FOR [ForeignDisc]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_FUnitPrice]  DEFAULT ((0)) FOR [FUnitPrice]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_FQty]  DEFAULT ((0)) FOR [FQty]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_FTotalAmt]  DEFAULT ((0)) FOR [FTotalAmt]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_JobBillAmt]  DEFAULT ((0)) FOR [JobBillAmt]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_VATRate]  DEFAULT ((0)) FOR [VATRate]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_Tavi50Rate1]  DEFAULT ((0)) FOR [Tavi50Rate1]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_Tavi50Rate2]  DEFAULT ((0)) FOR [Tavi50Rate2]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_TotalAdvance]  DEFAULT ((0)) FOR [TotalAdvance]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_TotalCharge]  DEFAULT ((0)) FOR [TotalCharge]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_TotalIsTaxCharge]  DEFAULT ((0)) FOR [TotalIsTaxCharge]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_TotalIs50Tavi1]  DEFAULT ((0)) FOR [TotalIs50Tavi1]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_TotalIs50Tavi2]  DEFAULT ((0)) FOR [TotalIs50Tavi2]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_TotalVAT]  DEFAULT ((0)) FOR [TotalVAT]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_Total50Tavi1]  DEFAULT ((0)) FOR [Total50Tavi1]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_Total50Tavi2]  DEFAULT ((0)) FOR [Total50Tavi2]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_TotalCustAdv]  DEFAULT ((0)) FOR [TotalCustAdv]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_TotalNet]  DEFAULT ((0)) FOR [TotalNet]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_PaidFlag]  DEFAULT ((0)) FOR [PaidFlag]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_ExchangeRate]  DEFAULT ((0)) FOR [ExchangeRate]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_ForeignAmt]  DEFAULT ((0)) FOR [ForeignAmt]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_Revise]  DEFAULT ((0)) FOR [Revise]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_UnitCost]  DEFAULT ((0)) FOR [UnitCost]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_UnitQTY]  DEFAULT ((1)) FOR [UnitQTY]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_CurrencyRate]  DEFAULT ((1)) FOR [CurrencyRate]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_Isvat]  DEFAULT ((0)) FOR [Isvat]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_VatRate]  DEFAULT ((0)) FOR [VatRate]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_VatAmt]  DEFAULT ((0)) FOR [VatAmt]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_IsTax]  DEFAULT ((0)) FOR [IsTax]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_TaxRate]  DEFAULT ((0)) FOR [TaxRate]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_TaxAmt]  DEFAULT ((0)) FOR [TaxAmt]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_TotalAmt]  DEFAULT ((0)) FOR [TotalAmt]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_ForeignAmt]  DEFAULT ((0)) FOR [CurrentTHB]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_UnitDiscntPerc]  DEFAULT ((0)) FOR [UnitDiscntPerc]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_UnitDiscntAmt]  DEFAULT ((0)) FOR [UnitDiscntAmt]
GO
ALTER TABLE [dbo].[Job_QuoHeader] ADD  CONSTRAINT [DF_Job_QuoHeader_ExchageRate]  DEFAULT ((0)) FOR [ExchageRate]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_IsTaxCharge]  DEFAULT ((0)) FOR [IsTaxCharge]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_Is50Tavi]  DEFAULT ((0)) FOR [Is50Tavi]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_Rate50Tavi]  DEFAULT ((0)) FOR [Rate50Tavi]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_IsCredit]  DEFAULT ((0)) FOR [IsCredit]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_IsExpense]  DEFAULT ((0)) FOR [IsExpense]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_IsShowPrice]  DEFAULT ((0)) FOR [IsShowPrice]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_IsHaveSlip]  DEFAULT ((0)) FOR [IsHaveSlip]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_IsPay50TaviTo]  DEFAULT ((0)) FOR [IsPay50TaviTo]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_IsLtdAdv50Tavi]  DEFAULT ((0)) FOR [IsLtdAdv50Tavi]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_IsUsedCoSlip]  DEFAULT ((0)) FOR [IsUsedCoSlip]
GO
ALTER TABLE [dbo].[Job_TaxInvoiceDetail] ADD  CONSTRAINT [DF_Job_TaxInvoiceDetail_BranchCode]  DEFAULT ((0)) FOR [BranchCode]
GO
ALTER TABLE [dbo].[Mas_BookAccount] ADD  CONSTRAINT [DF_Mas_BookAccount_IsLocal]  DEFAULT ((0)) FOR [IsLocal]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_CustType]  DEFAULT ((0)) FOR [CustType]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_Is19bis]  DEFAULT ((0)) FOR [Is19bis]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_MgrSeq]  DEFAULT ((0)) FOR [MgrSeq]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_LevelNoExp]  DEFAULT ((0)) FOR [LevelNoExp]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_LevelNoImp]  DEFAULT ((0)) FOR [LevelNoImp]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_DutyLimit]  DEFAULT ((0)) FOR [DutyLimit]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_CommRate]  DEFAULT ((0)) FOR [CommRate]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_GoldCardNO]  DEFAULT ((0)) FOR [GoldCardNO]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_CustomsBrokerSeq]  DEFAULT ((0)) FOR [CustomsBrokerSeq]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_ISCustomerSign]  DEFAULT ((0)) FOR [ISCustomerSign]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_ISCustomerSignInv]  DEFAULT ((0)) FOR [ISCustomerSignInv]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_ISCustomerSignDec]  DEFAULT ((0)) FOR [ISCustomerSignDec]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_ISCustomerSignECon]  DEFAULT ((0)) FOR [ISCustomerSignECon]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_IsShippingCannotSign]  DEFAULT ((0)) FOR [IsShippingCannotSign]
GO
ALTER TABLE [dbo].[MAS_GLACCOUNT] ADD  CONSTRAINT [DF_MAS_GLACCOUNT_BranchCode]  DEFAULT ((0)) FOR [BranchCode]
GO
ALTER TABLE [dbo].[MAS_GLACCOUNT] ADD  CONSTRAINT [DF_MAS_GLACCOUNT_JobType]  DEFAULT ((0)) FOR [JobType]
GO
ALTER TABLE [dbo].[MAS_GLACCOUNT] ADD  CONSTRAINT [DF_MAS_GLACCOUNT_ShipBy]  DEFAULT ((0)) FOR [ShipBy]
GO
/****** Object:  StoredProcedure [dbo].[RefreshJobStatus]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RefreshJobStatus]
(
@JobNo varchar(20)
)
as
BEGIN
--status wait for processs--????????????????????
update a
set a.JobStatus =1 
from Job_order a left join Job_AdvHeader b on a.JNo=b.JNo
where b.AdvNo is null and a.JobStatus<>99 and a.JobStatus<>1
and a.JNo=@JobNo

--status process check from clearing or have adv =?????????????????? ??????????????????? ??????????????????
update a
set JobStatus =2  
from Job_order a left join Job_AdvHeader b on a.JNo=b.JNo
where b.AdvNo is not null and a.Jobstatus<>99 and a.JobStatus<>2
and a.JNo=@JobNo

update a 
set JobStatus =2
from Job_Order a inner join Job_Detail b on a.JNo=b.JNo where b.ClearingNO <>''
and a.JobStatus<>99 and a.JobStatus<>2
and a.JNo=@JobNo

--status close check from have closejobdate ??????????????????
update a 
set JobStatus =3
from Job_Order a where a.CloseJobBy<>'' and a.JobStatus <>99 and a.JobStatus<>3
and a.JNo=@JobNo

--status part billing check from job which have item that not issue invoice ?????????????????????????????????????????
update a
set jobstatus=4
from Job_Order a inner join Job_detail b 
on a.JNo=b.JNo left join Job_SrvSingle c 
on b.SICode=c.SICode where ISNULL(c.IsExpense,0) =0 and ISNULL(b.DNNo,'') ='' and b.BPrice>0
and a.JNo in(select JNo from Job_detail where JNo=b.JNo and ISNULL(DNNo,'')<>'')
and a.JobStatus <>99 and a.JobStatus<>4
and a.JNo=@JobNo

--status full billing check from job which every income have invoice  ??????????????????????
update d
set JobStatus=5
from Job_Order d
where d.JNo not in(
select distinct a.JNo 
from Job_Order a inner join Job_detail b 
on a.JNo=b.JNo left join Job_SrvSingle c 
on b.SICode=c.SICode where isnull(c.IsExpense,0) =0 and b.BPrice>0 and ISNULL(b.DNNo,'')='' and a.JNo=d.JNo)
and d.JNo in(select distinct JNo from Job_detail where JNo=d.JNo and ISNULL(DNNo,'')<>'')
and d.JobStatus<>99 and d.JobStatus<>5
and d.JNo=@JobNo
--status complete when every invoice from Job have receipt ?????????????????????

update d
set JobStatus=6
from Job_Order d
where d.JNo not in(
		select distinct a.JNo 
		from Job_Order a inner join Job_detail b 
		on a.JNo=b.JNo left join Job_SrvSingle c 
		on b.SICode=c.SICode where isnull(c.IsExpense,0) =0 and b.BPrice>0 
		and ISNULL(b.DNNo,'')='' and a.JNo=d.JNo
		)
	and d.JNo in(
		select distinct JNo from Job_detail where JNo=d.JNo and ISNULL(DNNo,'')<>''
		)
	and d.JNo not in(
		select distinct e.JNo from Job_detail e where e.JNo=d.JNo and ISNULL(e.DNNo,'')<>'' and
		e.DNNo IN(select DocNo from Job_BillingHeader where DocNo=e.DNNo and ISNULL(TaxInvNo,'')='' And Not CancelProve<>'' And TotalCharge>0)
		)
	and d.JNo not in(
		select JobNo from qJob_BillBalance where Balance>0 and JobNo=d.JNo
		)
and d.JobStatus<>99 and d.JobStatus>=3 and d.JobStatus<>6
and d.JNo=@JobNo

--????????????
update Job_Order set JobStatus=99 where CancelProve<>'' and JobStatus<>99
and JNo=@JobNo

END
GO
/****** Object:  StoredProcedure [dbo].[RefreshStatusAll]    Script Date: 08-Mar-19 11:31:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RefreshStatusAll]
as
BEGIN
--status wait for processs--????????????????????
update a
set a.JobStatus =1 
from Job_order a left join Job_AdvHeader b on a.JNo=b.JNo
where b.AdvNo is null and a.JobStatus<>99 and a.JobStatus<>1

--status process check from clearing or have adv =?????????????????? ??????????????????? ??????????????????
update a
set JobStatus =2  
from Job_order a left join Job_AdvHeader b on a.JNo=b.JNo
where b.AdvNo is not null and a.Jobstatus<>99 and a.JobStatus<>2

update a 
set JobStatus =2
from Job_Order a inner join Job_Detail b on a.JNo=b.JNo where b.ClearingNO <>''
and a.JobStatus<>99 and a.JobStatus<>2

--status close check from have closejobdate ??????????????????
update a 
set JobStatus =3
from Job_Order a where a.CloseJobBy<>'' and a.JobStatus <>99 and a.JobStatus<>3

--status part billing check from job which have item that not issue invoice ?????????????????????????????????????????
update a
set jobstatus=4
from Job_Order a inner join Job_detail b 
on a.JNo=b.JNo left join Job_SrvSingle c 
on b.SICode=c.SICode where ISNULL(c.IsExpense,0) =0 and ISNULL(b.DNNo,'') ='' and b.BPrice>0
and a.JNo in(select JNo from Job_detail where JNo=b.JNo and ISNULL(DNNo,'')<>'')
and a.JobStatus <>99 and a.JobStatus<>4

--status full billing check from job which every income have invoice  ??????????????????????
update d
set JobStatus=5
from Job_Order d
where d.JNo not in(
select distinct a.JNo 
from Job_Order a inner join Job_detail b 
on a.JNo=b.JNo left join Job_SrvSingle c 
on b.SICode=c.SICode where isnull(c.IsExpense,0) =0 and b.BPrice>0 and ISNULL(b.DNNo,'')='' and a.JNo=d.JNo)
and d.JNo in(select distinct JNo from Job_detail where JNo=d.JNo and ISNULL(DNNo,'')<>'')
and d.JobStatus<>99 and d.JobStatus<>5
--status complete when every invoice from Job have receipt ?????????????????????

update d
set JobStatus=6
from Job_Order d
where d.JNo not in(
		select distinct a.JNo 
		from Job_Order a inner join Job_detail b 
		on a.JNo=b.JNo left join Job_SrvSingle c 
		on b.SICode=c.SICode where isnull(c.IsExpense,0) =0 and b.BPrice>0 
		and ISNULL(b.DNNo,'')='' and a.JNo=d.JNo
		)
	and d.JNo in(
		select distinct JNo from Job_detail where JNo=d.JNo and ISNULL(DNNo,'')<>''
		)
	and d.JNo not in(
		select distinct e.JNo from Job_detail e where e.JNo=d.JNo and ISNULL(e.DNNo,'')<>'' and
		e.DNNo IN(select DocNo from Job_BillingHeader where DocNo=e.DNNo and ISNULL(TaxInvNo,'')='' And Not CancelProve<>'' And TotalCharge>0)
		)
	and d.JNo not in(
		select JobNo from qJob_BillBalance where Balance>0 And JobNo=d.JNo
		)
and d.JobStatus<>99 and d.JobStatus>=3 and d.JobStatus<>6

--????????????
update Job_Order set JobStatus=99 where CancelProve<>'' and JobStatus<>99

END




GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[78] 2[4] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_ClearDetail"
            Begin Extent = 
               Top = 0
               Left = 176
               Bottom = 361
               Right = 332
            End
            DisplayFlags = 280
            TopColumn = 29
         End
         Begin Table = "qJob_AdvDetail"
            Begin Extent = 
               Top = 0
               Left = 611
               Bottom = 330
               Right = 763
            End
            DisplayFlags = 280
            TopColumn = 31
         End
         Begin Table = "Mas_Vender"
            Begin Extent = 
               Top = 46
               Left = 391
               Bottom = 330
               Right = 554
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 39
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ClearEarness'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ClearEarness'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ClearEarness'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[31] 2[36] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Mas_Customers"
            Begin Extent = 
               Top = 0
               Left = 407
               Bottom = 92
               Right = 592
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 0
               Left = 142
               Bottom = 374
               Right = 333
            End
            DisplayFlags = 280
            TopColumn = 75
         End
         Begin Table = "Mas_Consignee"
            Begin Extent = 
               Top = 103
               Left = 414
               Bottom = 348
               Right = 599
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 16
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1920
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_CostJoinProfit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_CostJoinProfit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[16] 2[84] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_ClearDetail"
            Begin Extent = 
               Top = 14
               Left = 214
               Bottom = 388
               Right = 370
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "qJob_Detail"
            Begin Extent = 
               Top = 8
               Left = 407
               Bottom = 365
               Right = 549
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Q_PaymentRef"
            Begin Extent = 
               Top = 2
               Left = 26
               Bottom = 152
               Right = 178
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Vender"
            Begin Extent = 
               Top = 156
               Left = 38
               Bottom = 275
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "qJob_BillDetail"
            Begin Extent = 
               Top = 11
               Left = 595
               Bottom = 375
               Right = 747
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "qJob_RSlip"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 125
               Right = 429
            End
  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialCostReport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'          DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MAS_GLACCOUNT"
            Begin Extent = 
               Top = 399
               Left = 802
               Bottom = 582
               Right = 954
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 16
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialCostReport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialCostReport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[64] 2[36] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[26] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_BillDetail"
            Begin Extent = 
               Top = 0
               Left = 364
               Bottom = 361
               Right = 546
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "qJob_RSlip"
            Begin Extent = 
               Top = 7
               Left = 813
               Bottom = 133
               Right = 965
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Customers"
            Begin Extent = 
               Top = 142
               Left = 813
               Bottom = 299
               Right = 998
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MAS_GLACCOUNT"
            Begin Extent = 
               Top = 315
               Left = 833
               Bottom = 493
               Right = 985
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 4
               Left = 94
               Bottom = 359
               Right = 285
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaP' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialSalesReport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'ane = 
      PaneHidden = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialSalesReport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialSalesReport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[44] 2[30] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[95] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_CashControl"
            Begin Extent = 
               Top = 0
               Left = 76
               Bottom = 468
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_CashControlDoc"
            Begin Extent = 
               Top = 21
               Left = 604
               Bottom = 431
               Right = 821
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_CashControlSub"
            Begin Extent = 
               Top = 12
               Left = 300
               Bottom = 496
               Right = 553
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2490
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_PaymentRef'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_PaymentRef'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[14] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Q_CostJoinProfit"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 343
               Right = 243
            End
            DisplayFlags = 280
            TopColumn = 15
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitCalculate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitCalculate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[9] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 245
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "qJob_Detail"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 245
               Right = 253
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_SrvSingle"
            Begin Extent = 
               Top = 246
               Left = 38
               Bottom = 365
               Right = 244
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitCost'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitCost'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[30] 2[47] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -672
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 363
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "qJob_BillDetail"
            Begin Extent = 
               Top = 0
               Left = 320
               Bottom = 780
               Right = 654
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 2280
         Width = 2115
         Width = 1905
         Width = 3345
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitSales'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitSales'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[51] 2[21] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Q_CostJoinProfit"
            Begin Extent = 
               Top = 3
               Left = 340
               Bottom = 360
               Right = 494
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Q_ProfitCalculate"
            Begin Extent = 
               Top = 7
               Left = 550
               Bottom = 328
               Right = 702
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 40
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 7' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ReportCostAndProfit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'20
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ReportCostAndProfit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ReportCostAndProfit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[63] 2[32] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[90] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_CashControl"
            Begin Extent = 
               Top = 0
               Left = 99
               Bottom = 618
               Right = 297
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Q_PaymentRef"
            Begin Extent = 
               Top = 0
               Left = 344
               Bottom = 180
               Right = 523
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Q_VouherStateOne"
            Begin Extent = 
               Top = 5
               Left = 566
               Bottom = 224
               Right = 735
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 3
               Left = 792
               Bottom = 554
               Right = 991
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Mas_BookAccount"
            Begin Extent = 
               Top = 444
               Left = 365
               Bottom = 643
               Right = 563
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "Job_CashControlDoc"
            Begin Extent = 
               Top = 180
               Left = 395
               Bottom = 310
               Right = 565
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         W' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_StatementAccount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'idth = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_StatementAccount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_StatementAccount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[22] 2[38] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = -192
      End
      Begin Tables = 
         Begin Table = "qGL_SetAR"
            Begin Extent = 
               Top = 0
               Left = 625
               Bottom = 343
               Right = 777
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_TaxInvoice"
            Begin Extent = 
               Top = 0
               Left = 156
               Bottom = 360
               Right = 316
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 54
               Left = 390
               Bottom = 307
               Right = 575
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MAS_GLACCOUNT"
            Begin Extent = 
               Top = 6
               Left = 815
               Bottom = 267
               Right = 967
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 19
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_TaxExport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_TaxExport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_TaxExport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[17] 4[4] 2[28] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_VouherStateOne'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_VouherStateOne'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[34] 2[43] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[85] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_CashControl"
            Begin Extent = 
               Top = 6
               Left = 154
               Bottom = 656
               Right = 365
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_CashControlDoc"
            Begin Extent = 
               Top = 12
               Left = 443
               Bottom = 283
               Right = 614
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_VouherStateTwo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_VouherStateTwo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 10
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_AdvHeader"
            Begin Extent = 
               Top = 6
               Left = 50
               Bottom = 320
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_AdvDetail"
            Begin Extent = 
               Top = 0
               Left = 309
               Bottom = 359
               Right = 469
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_Advance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_Advance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[66] 2[4] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[76] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4[60] 2) )"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2) )"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_CashControlDoc"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 260
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "QE_CashControlRefJob"
            Begin Extent = 
               Top = 6
               Left = 306
               Bottom = 144
               Right = 476
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlDoc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlDoc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[58] 2[4] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_CashControl"
            Begin Extent = 
               Top = 0
               Left = 147
               Bottom = 322
               Right = 317
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "QE_CashControlRefJob"
            Begin Extent = 
               Top = 0
               Left = 411
               Bottom = 298
               Right = 581
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 16
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlHeder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlHeder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[43] 2[16] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_CashControlDoc"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 275
               Right = 237
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "QE_UnionCashJob"
            Begin Extent = 
               Top = 6
               Left = 289
               Bottom = 277
               Right = 459
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlRefJob'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlRefJob'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[45] 2[3] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[89] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_CashControlSub"
            Begin Extent = 
               Top = 0
               Left = 133
               Bottom = 433
               Right = 303
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "QE_CashControlRefJob"
            Begin Extent = 
               Top = 6
               Left = 439
               Bottom = 138
               Right = 609
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlSub'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlSub'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 10
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_ClearHeader"
            Begin Extent = 
               Top = 0
               Left = 193
               Bottom = 362
               Right = 353
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_ClearDetail"
            Begin Extent = 
               Top = 6
               Left = 391
               Bottom = 360
               Right = 555
            End
            DisplayFlags = 280
            TopColumn = 19
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_Clearing'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_Clearing'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[47] 2[7] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_CustAdvChq"
            Begin Extent = 
               Top = 10
               Left = 30
               Bottom = 369
               Right = 243
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Job_CustAdvChqSub"
            Begin Extent = 
               Top = 3
               Left = 282
               Bottom = 364
               Right = 475
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 26
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CustAdvanceCheqHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CustAdvanceCheqHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 10
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_PaymentHeader"
            Begin Extent = 
               Top = 0
               Left = 91
               Bottom = 334
               Right = 287
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_PaymentDetail"
            Begin Extent = 
               Top = 0
               Left = 379
               Bottom = 307
               Right = 617
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_InvoiceAPDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_InvoiceAPDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 10
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 325
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 81
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_ListSelectJob'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_ListSelectJob'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 10
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "QE_QuotationHeader"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 345
               Right = 206
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_QuoDetail"
            Begin Extent = 
               Top = 0
               Left = 325
               Bottom = 314
               Right = 485
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QoutationDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QoutationDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 10
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "QE_QuotationHeader"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 353
               Right = 206
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_QuoDetailItem"
            Begin Extent = 
               Top = 1
               Left = 283
               Bottom = 350
               Right = 443
            End
            DisplayFlags = 280
            TopColumn = 14
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QuoDetailItem'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QuoDetailItem'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[15] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_QuoHeader"
            Begin Extent = 
               Top = 0
               Left = 61
               Bottom = 306
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 0
               Left = 289
               Bottom = 210
               Right = 488
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QuotationHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QuotationHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[22] 2[33] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[21] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_UnionCashJob'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_UnionCashJob'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[43] 2[4] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_AdvHeader"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_User"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 422
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 244
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 2100
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_AdvHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_AdvHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[53] 4[9] 2[12] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[91] 2[4] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_SrvSingle"
            Begin Extent = 
               Top = 100
               Left = 763
               Bottom = 361
               Right = 953
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_BillingDetail"
            Begin Extent = 
               Top = 0
               Left = 483
               Bottom = 373
               Right = 681
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_BillingHeader"
            Begin Extent = 
               Top = 5
               Left = 0
               Bottom = 376
               Right = 167
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 88
               Left = 263
               Bottom = 203
               Right = 454
            End
            DisplayFlags = 280
            TopColumn = 52
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 203
               Left = 260
               Bottom = 318
               Right = 445
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Pan' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'eHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "a"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 204
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "b"
            Begin Extent = 
               Top = 6
               Left = 242
               Bottom = 84
               Right = 393
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 84
               Left = 242
               Bottom = 192
               Right = 426
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "d"
            Begin Extent = 
               Top = 114
               Left = 38
               Bottom = 222
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "e"
            Begin Extent = 
               Top = 192
               Left = 266
               Bottom = 270
               Right = 417
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output =' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[48] 4[14] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_CustAdvHeader"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 190
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Job_CustAdvDetail"
            Begin Extent = 
               Top = 6
               Left = 228
               Bottom = 121
               Right = 380
            End
            DisplayFlags = 280
            TopColumn = 10
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 241
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 16
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 126
               Left = 267
               Bottom = 241
               Right = 452
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
     ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_CustAdvance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'    Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_CustAdvance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_CustAdvance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[9] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_BillingHeader"
            Begin Extent = 
               Top = 45
               Left = 391
               Bottom = 160
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 18
         End
         Begin Table = "Job_DebitNote"
            Begin Extent = 
               Top = 0
               Left = 19
               Bottom = 115
               Right = 171
            End
            DisplayFlags = 280
            TopColumn = 10
         End
         Begin Table = "Job_DebitNoteSub"
            Begin Extent = 
               Top = 11
               Left = 206
               Bottom = 126
               Right = 358
            End
            DisplayFlags = 280
            TopColumn = 8
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 10
               Left = 574
               Bottom = 125
               Right = 759
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
   ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_DebitNoteSub'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'      Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_DebitNoteSub'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_DebitNoteSub'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 12
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 237
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_Detail"
            Begin Extent = 
               Top = 0
               Left = 459
               Bottom = 517
               Right = 627
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Branch"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 215
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_User"
            Begin Extent = 
               Top = 126
               Left = 236
               Bottom = 245
               Right = 401
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Agent"
            Begin Extent = 
               Top = 216
               Left = 38
               Bottom = 335
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 246
               Left = 236
               Bottom = 365
               Right = 429
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_RFARS"
            Begin Extent = 
               Top = 336
               Left = 38
               Bottom = 455
               Right = 198
            End
            Di' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Detail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'splayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_RFICC"
            Begin Extent = 
               Top = 366
               Left = 236
               Bottom = 485
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_ServUnitType"
            Begin Extent = 
               Top = 456
               Left = 38
               Bottom = 575
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_SrvSingle"
            Begin Extent = 
               Top = 6
               Left = 665
               Bottom = 364
               Right = 855
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
      PaneHidden = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Detail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Detail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[10] 4[56] 2[16] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "a"
            Begin Extent = 
               Top = 2
               Left = 250
               Bottom = 352
               Right = 441
            End
            DisplayFlags = 280
            TopColumn = 77
         End
         Begin Table = "Mas_Vender"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "g"
            Begin Extent = 
               Top = 11
               Left = 500
               Bottom = 126
               Right = 663
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "b"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 241
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "f"
            Begin Extent = 
               Top = 174
               Left = 527
               Bottom = 289
               Right = 688
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "d"
            Begin Extent = 
               Top = 308
               Left = 521
               Bottom = 423
               Right = 673
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "e"
            Begin Extent = 
               Top = 366
               Left = 38
               Bottom = 481
               Right = 195
            End
            DisplayFlags = 280
            TopColumn = 0
      ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Order'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'   End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 1380
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Order'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Order'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[36] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_PaymentHeader"
            Begin Extent = 
               Top = 0
               Left = 375
               Bottom = 211
               Right = 542
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_PaymentDetail"
            Begin Extent = 
               Top = 0
               Left = 638
               Bottom = 115
               Right = 790
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 241
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 130
               Left = 695
               Bottom = 360
               Right = 880
            End
            DisplayFlags = 280
            TopColumn = 51
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
     ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'    Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[72] 2[23] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_PaymentHeader"
            Begin Extent = 
               Top = 3
               Left = 20
               Bottom = 291
               Right = 200
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Branch"
            Begin Extent = 
               Top = 0
               Left = 456
               Bottom = 132
               Right = 626
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 0
               Left = 636
               Bottom = 374
               Right = 842
            End
            DisplayFlags = 280
            TopColumn = 45
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 0
               Left = 267
               Bottom = 343
               Right = 477
            End
            DisplayFlags = 280
            TopColumn = 7
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filt' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'er = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[45] 2[22] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[92] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 165
               Left = 203
               Bottom = 401
               Right = 388
            End
            DisplayFlags = 280
            TopColumn = 51
         End
         Begin Table = "Job_QuoHeader"
            Begin Extent = 
               Top = 0
               Left = 558
               Bottom = 342
               Right = 710
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_QuoDetailItem"
            Begin Extent = 
               Top = 14
               Left = 5
               Bottom = 302
               Right = 175
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_QuoDetail"
            Begin Extent = 
               Top = 20
               Left = 225
               Bottom = 214
               Right = 377
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_User_1"
            Begin Extent = 
               Top = 155
               Left = 259
               Bottom = 270
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_User"
            Begin Extent = 
               Top = 169
               Left = 370
               Bottom = 284
               Right = 527
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 60
         Width = 284
         Width = 150' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Quotation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'0
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Quotation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Quotation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_RSlip"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 301
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_RSlipSub"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 316
               Right = 388
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 2250
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_RSlip'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_RSlip'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[19] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_TaxInvoice"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_TaxInvoiceDetail"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 121
               Right = 388
            End
            DisplayFlags = 280
            TopColumn = 8
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 241
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_TaxInvDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_TaxInvDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[45] 2[4] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1[56] 3) )"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_BillDetail"
            Begin Extent = 
               Top = 0
               Left = 257
               Bottom = 354
               Right = 432
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_SrvSingle"
            Begin Extent = 
               Top = 3
               Left = 514
               Bottom = 376
               Right = 704
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MAS_GLACCOUNT_1"
            Begin Extent = 
               Top = 2
               Left = 770
               Bottom = 261
               Right = 930
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 16
         Width = 284
         Width = 2220
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 900
         Width = 1500
         Width = 885
         Width = 1035
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1185
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_CostState'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_CostState'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[26] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4[30] 2[40] 3) )"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_BillDetail"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 419
               Right = 205
            End
            DisplayFlags = 280
            TopColumn = 50
         End
         Begin Table = "Asrv"
            Begin Extent = 
               Top = 0
               Left = 231
               Bottom = 272
               Right = 413
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "Bsrv"
            Begin Extent = 
               Top = 0
               Left = 472
               Bottom = 274
               Right = 654
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1770
         Width = 1500
         Width = 990
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_ksat_Biggg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_ksat_Biggg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[67] 2[4] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1[56] 3) )"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "MAS_GLACCOUNT_1"
            Begin Extent = 
               Top = 2
               Left = 770
               Bottom = 261
               Right = 930
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "qJob_BillDetail"
            Begin Extent = 
               Top = 0
               Left = 257
               Bottom = 354
               Right = 432
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_SrvSingle"
            Begin Extent = 
               Top = 3
               Left = 514
               Bottom = 376
               Right = 704
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 16
         Width = 284
         Width = 2220
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 900
         Width = 1500
         Width = 885
         Width = 1035
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1185
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_SalseState'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_SalseState'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[51] 2[14] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[94] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -864
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_BillDetail"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 725
               Right = 220
            End
            DisplayFlags = 280
            TopColumn = 22
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvFristStep'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvFristStep'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_BillDetail"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvSecondStep'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvSecondStep'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[5] 2[31] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_BillHeader"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 205
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 72
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvThirdStep'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvThirdStep'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvThirdStep'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ChequeHeader"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 189
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ChequeDetail"
            Begin Extent = 
               Top = 6
               Left = 227
               Bottom = 114
               Right = 378
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 128
               Left = 233
               Bottom = 236
               Right = 417
            End
            DisplayFlags = 280
            TopColumn = 11
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vCheque'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vCheque'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ChequeHeader"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 209
               Right = 189
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 6
               Left = 227
               Bottom = 216
               Right = 411
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vChequeHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vChequeHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[29] 2[39] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_ClearDetail"
            Begin Extent = 
               Top = 2
               Left = 95
               Bottom = 474
               Right = 269
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "qJob_CashControl"
            Begin Extent = 
               Top = 0
               Left = 372
               Bottom = 436
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 10
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 24
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_RefClr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_RefClr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[15] 4[46] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "vJob_Summary"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 194
               Right = 190
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_CodeSum'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_CodeSum'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[15] 4[25] 2[13] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 207
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Count'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Count'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[31] 4[32] 2[19] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_BillingHeader"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 205
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Job_BillingDetail"
            Begin Extent = 
               Top = 16
               Left = 249
               Bottom = 167
               Right = 429
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_SrvSingle"
            Begin Extent = 
               Top = 11
               Left = 488
               Bottom = 126
               Right = 645
            End
            DisplayFlags = 280
            TopColumn = 10
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Invoice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Invoice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[51] 4[38] 2[7] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_Detail"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 207
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_SrvSingle"
            Begin Extent = 
               Top = 4
               Left = 348
               Bottom = 205
               Right = 505
            End
            DisplayFlags = 280
            TopColumn = 9
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_NoInvoice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_NoInvoice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[16] 4[50] 2[9] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "vJob_Summary"
            Begin Extent = 
               Top = 2
               Left = 505
               Bottom = 169
               Right = 657
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "qJob_Order"
            Begin Extent = 
               Top = 0
               Left = 106
               Bottom = 115
               Right = 313
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 110
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Wi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Profit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'dth = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 2580
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Profit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Profit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Summary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Summary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[19] 4[20] 2[9] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vJob_Summary"
            Begin Extent = 
               Top = 6
               Left = 267
               Bottom = 121
               Right = 419
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 114
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Wid' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_TrackingOper'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'th = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_TrackingOper'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_TrackingOper'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[11] 4[36] 2[13] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 4
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1560
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 2610
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Volume'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Volume'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[13] 4[23] 2[11] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 245
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_VolumeByCust'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_VolumeByCust'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[36] 4[31] 2[10] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_TaxInvoice"
            Begin Extent = 
               Top = 0
               Left = 684
               Bottom = 232
               Right = 844
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_BillingHeader"
            Begin Extent = 
               Top = 0
               Left = 439
               Bottom = 115
               Right = 606
            End
            DisplayFlags = 280
            TopColumn = 17
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 62
         End
         Begin Table = "Job_ClearHeader"
            Begin Extent = 
               Top = 170
               Left = 598
               Bottom = 438
               Right = 750
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_AdvHeader"
            Begin Extent = 
               Top = 235
               Left = 383
               Bottom = 503
               Right = 535
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 14' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'40
         Alias = 3555
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[23] 4[39] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "a"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 168
               Right = 190
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 6
               Left = 418
               Bottom = 207
               Right = 609
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "b"
            Begin Extent = 
               Top = 157
               Left = 328
               Bottom = 272
               Right = 480
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI_Advance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI_Advance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[14] 4[24] 2[46] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "vKPI"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vKPI_AdvanceSum"
            Begin Extent = 
               Top = 6
               Left = 257
               Bottom = 125
               Right = 424
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "vJob_Profit"
            Begin Extent = 
               Top = 0
               Left = 498
               Bottom = 119
               Right = 697
            End
            DisplayFlags = 280
            TopColumn = 107
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3690
         Alias = 3405
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI_Summary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI_Summary'
GO
ALTER DATABASE [JOB_WEB] SET  READ_WRITE 
GO
