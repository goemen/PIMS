using Mapster;
using Entity = Pims.Dal.Entities;
using Model = Pims.Api.Areas.Project.Models.Dispose;

namespace Pims.Api.Areas.Project.Mapping.Dispose
{
    public class DisposalProjectMetadataMap : IRegister
    {
        #region Methods
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Entity.Models.DisposalProjectMetadata, Model.ProjectModel>()
                .Map(dest => dest.InitialNotificationSentOn, src => src.InitialNotificationSentOn)
                .Map(dest => dest.ThirtyDayNotificationSentOn, src => src.ThirtyDayNotificationSentOn)
                .Map(dest => dest.SixtyDayNotificationSentOn, src => src.SixtyDayNotificationSentOn)
                .Map(dest => dest.NinetyDayNotificationSentOn, src => src.NinetyDayNotificationSentOn)
                .Map(dest => dest.OnHoldNotificationSentOn, src => src.OnHoldNotificationSentOn)
                .Map(dest => dest.ClearanceNotificationSentOn, src => src.ClearanceNotificationSentOn)
                .Map(dest => dest.TransferredWithinGreOn, src => src.TransferredWithinGreOn)
                .Map(dest => dest.RequestForSplReceivedOn, src => src.RequestForSplReceivedOn)
                .Map(dest => dest.ApprovedForSplOn, src => src.ApprovedForSplOn)
                .Map(dest => dest.MarketedOn, src => src.MarketedOn)
                .Map(dest => dest.OfferAcceptedOn, src => src.OfferAcceptedOn)
                .Map(dest => dest.DisposedOn, src => src.DisposedOn)
                .Map(dest => dest.AssessedOn, src => src.AssessedOn)
                .Map(dest => dest.AdjustedOn, src => src.AdjustedOn)
                .Map(dest => dest.PreliminaryFormSignedOn, src => src.PreliminaryFormSignedOn)
                .Map(dest => dest.FinalFormSignedOn, src => src.FinalFormSignedOn)
                .Map(dest => dest.PriorYearAdjustmentOn, src => src.PriorYearAdjustmentOn)
                .Map(dest => dest.ExemptionRequested, src => src.ExemptionRequested)
                .Map(dest => dest.SalesCost, src => src.SalesCost)
                .Map(dest => dest.NetProceeds, src => src.NetProceeds)
                .Map(dest => dest.ProgramCost, src => src.ProgramCost)
                .Map(dest => dest.GainLoss, src => src.GainLoss)
                .Map(dest => dest.SppCapitalization, src => src.SppCapitalization)
                .Map(dest => dest.GainBeforeSpl, src => src.GainBeforeSpl)
                .Map(dest => dest.OcgFinancialStatement, src => src.OcgFinancialStatement)
                .Map(dest => dest.OfferAmount, src => src.OfferAmount)
                .Map(dest => dest.SaleWithLeaseInPlace, src => src.SaleWithLeaseInPlace)
                .Map(dest => dest.PriorYearAdjustment, src => src.PriorYearAdjustment)
                .Map(dest => dest.PriorYearAdjustmentAmount, src => src.PriorYearAdjustmentAmount)
                .Map(dest => dest.InterestComponent, src => src.InterestComponent)
                .Map(dest => dest.Realtor, src => src.Realtor)
                .Map(dest => dest.RealtorRate, src => src.RealtorRate)
                .Map(dest => dest.RealtorCommission, src => src.RealtorCommission)
                .Map(dest => dest.PlannedFutureUse, src => src.PlannedFutureUse)
                .Map(dest => dest.PreliminaryFormSignedBy, src => src.PreliminaryFormSignedBy)
                .Map(dest => dest.FinalFormSignedBy, src => src.FinalFormSignedBy);

            config.NewConfig<Model.ProjectModel, Entity.Models.DisposalProjectMetadata>()
                .Map(dest => dest.Purchaser, src => src.Purchaser)
                .Map(dest => dest.InitialNotificationSentOn, src => src.InitialNotificationSentOn)
                .Map(dest => dest.ThirtyDayNotificationSentOn, src => src.ThirtyDayNotificationSentOn)
                .Map(dest => dest.SixtyDayNotificationSentOn, src => src.SixtyDayNotificationSentOn)
                .Map(dest => dest.NinetyDayNotificationSentOn, src => src.NinetyDayNotificationSentOn)
                .Map(dest => dest.OnHoldNotificationSentOn, src => src.OnHoldNotificationSentOn)
                .Map(dest => dest.ClearanceNotificationSentOn, src => src.ClearanceNotificationSentOn)
                .Map(dest => dest.TransferredWithinGreOn, src => src.TransferredWithinGreOn)
                .Map(dest => dest.RequestForSplReceivedOn, src => src.RequestForSplReceivedOn)
                .Map(dest => dest.ApprovedForSplOn, src => src.ApprovedForSplOn)
                .Map(dest => dest.MarketedOn, src => src.MarketedOn)
                .Map(dest => dest.OfferAcceptedOn, src => src.OfferAcceptedOn)
                .Map(dest => dest.AssessedOn, src => src.AssessedOn)
                .Map(dest => dest.AdjustedOn, src => src.AdjustedOn)
                .Map(dest => dest.PreliminaryFormSignedOn, src => src.PreliminaryFormSignedOn)
                .Map(dest => dest.FinalFormSignedOn, src => src.FinalFormSignedOn)
                .Map(dest => dest.PriorYearAdjustmentOn, src => src.PriorYearAdjustmentOn)
                .Map(dest => dest.ExemptionRequested, src => src.ExemptionRequested)
                .Map(dest => dest.DisposedOn, src => src.DisposedOn)
                .Map(dest => dest.SalesCost, src => src.SalesCost)
                .Map(dest => dest.NetProceeds, src => src.NetProceeds)
                .Map(dest => dest.ProgramCost, src => src.ProgramCost)
                .Map(dest => dest.GainLoss, src => src.GainLoss)
                .Map(dest => dest.SppCapitalization, src => src.SppCapitalization)
                .Map(dest => dest.GainBeforeSpl, src => src.GainBeforeSpl)
                .Map(dest => dest.OcgFinancialStatement, src => src.OcgFinancialStatement)
                .Map(dest => dest.OfferAmount, src => src.OfferAmount)
                .Map(dest => dest.SaleWithLeaseInPlace, src => src.SaleWithLeaseInPlace)
                .Map(dest => dest.PriorYearAdjustment, src => src.PriorYearAdjustment)
                .Map(dest => dest.PriorYearAdjustmentAmount, src => src.PriorYearAdjustmentAmount)
                .Map(dest => dest.InterestComponent, src => src.InterestComponent)
                .Map(dest => dest.Realtor, src => src.Realtor)
                .Map(dest => dest.RealtorRate, src => src.RealtorRate)
                .Map(dest => dest.RealtorCommission, src => src.RealtorCommission)
                .Map(dest => dest.PlannedFutureUse, src => src.PlannedFutureUse)
                .Map(dest => dest.PreliminaryFormSignedBy, src => src.PreliminaryFormSignedBy)
                .Map(dest => dest.FinalFormSignedBy, src => src.FinalFormSignedBy);
        }
        #endregion
    }
}
