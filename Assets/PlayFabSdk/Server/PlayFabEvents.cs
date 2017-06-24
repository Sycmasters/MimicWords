#if ENABLE_PLAYFABSERVER_API
using PlayFab.ServerModels;

namespace PlayFab.Events
{
    public partial class PlayFabEvents
    {
        public event PlayFabRequestEvent<AuthenticateSessionTicketRequest> OnServerAuthenticateSessionTicketRequestEvent;
        public event PlayFabResultEvent<AuthenticateSessionTicketResult> OnServerAuthenticateSessionTicketResultEvent;
        public event PlayFabRequestEvent<BanUsersRequest> OnServerBanUsersRequestEvent;
        public event PlayFabResultEvent<BanUsersResult> OnServerBanUsersResultEvent;
        public event PlayFabRequestEvent<GetPlayerProfileRequest> OnServerGetPlayerProfileRequestEvent;
        public event PlayFabResultEvent<GetPlayerProfileResult> OnServerGetPlayerProfileResultEvent;
        public event PlayFabRequestEvent<GetPlayFabIDsFromFacebookIDsRequest> OnServerGetPlayFabIDsFromFacebookIDsRequestEvent;
        public event PlayFabResultEvent<GetPlayFabIDsFromFacebookIDsResult> OnServerGetPlayFabIDsFromFacebookIDsResultEvent;
        public event PlayFabRequestEvent<GetPlayFabIDsFromSteamIDsRequest> OnServerGetPlayFabIDsFromSteamIDsRequestEvent;
        public event PlayFabResultEvent<GetPlayFabIDsFromSteamIDsResult> OnServerGetPlayFabIDsFromSteamIDsResultEvent;
        public event PlayFabRequestEvent<GetUserAccountInfoRequest> OnServerGetUserAccountInfoRequestEvent;
        public event PlayFabResultEvent<GetUserAccountInfoResult> OnServerGetUserAccountInfoResultEvent;
        public event PlayFabRequestEvent<GetUserBansRequest> OnServerGetUserBansRequestEvent;
        public event PlayFabResultEvent<GetUserBansResult> OnServerGetUserBansResultEvent;
        public event PlayFabRequestEvent<RevokeAllBansForUserRequest> OnServerRevokeAllBansForUserRequestEvent;
        public event PlayFabResultEvent<RevokeAllBansForUserResult> OnServerRevokeAllBansForUserResultEvent;
        public event PlayFabRequestEvent<RevokeBansRequest> OnServerRevokeBansRequestEvent;
        public event PlayFabResultEvent<RevokeBansResult> OnServerRevokeBansResultEvent;
        public event PlayFabRequestEvent<SendPushNotificationRequest> OnServerSendPushNotificationRequestEvent;
        public event PlayFabResultEvent<SendPushNotificationResult> OnServerSendPushNotificationResultEvent;
        public event PlayFabRequestEvent<UpdateAvatarUrlRequest> OnServerUpdateAvatarUrlRequestEvent;
        public event PlayFabResultEvent<EmptyResult> OnServerUpdateAvatarUrlResultEvent;
        public event PlayFabRequestEvent<UpdateBansRequest> OnServerUpdateBansRequestEvent;
        public event PlayFabResultEvent<UpdateBansResult> OnServerUpdateBansResultEvent;
        public event PlayFabRequestEvent<DeleteUsersRequest> OnServerDeleteUsersRequestEvent;
        public event PlayFabResultEvent<DeleteUsersResult> OnServerDeleteUsersResultEvent;
        public event PlayFabRequestEvent<GetFriendLeaderboardRequest> OnServerGetFriendLeaderboardRequestEvent;
        public event PlayFabResultEvent<GetLeaderboardResult> OnServerGetFriendLeaderboardResultEvent;
        public event PlayFabRequestEvent<GetLeaderboardRequest> OnServerGetLeaderboardRequestEvent;
        public event PlayFabResultEvent<GetLeaderboardResult> OnServerGetLeaderboardResultEvent;
        public event PlayFabRequestEvent<GetLeaderboardAroundUserRequest> OnServerGetLeaderboardAroundUserRequestEvent;
        public event PlayFabResultEvent<GetLeaderboardAroundUserResult> OnServerGetLeaderboardAroundUserResultEvent;
        public event PlayFabRequestEvent<GetPlayerCombinedInfoRequest> OnServerGetPlayerCombinedInfoRequestEvent;
        public event PlayFabResultEvent<GetPlayerCombinedInfoResult> OnServerGetPlayerCombinedInfoResultEvent;
        public event PlayFabRequestEvent<GetPlayerStatisticsRequest> OnServerGetPlayerStatisticsRequestEvent;
        public event PlayFabResultEvent<GetPlayerStatisticsResult> OnServerGetPlayerStatisticsResultEvent;
        public event PlayFabRequestEvent<GetPlayerStatisticVersionsRequest> OnServerGetPlayerStatisticVersionsRequestEvent;
        public event PlayFabResultEvent<GetPlayerStatisticVersionsResult> OnServerGetPlayerStatisticVersionsResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnServerGetUserDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnServerGetUserDataResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnServerGetUserInternalDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnServerGetUserInternalDataResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnServerGetUserPublisherDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnServerGetUserPublisherDataResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnServerGetUserPublisherInternalDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnServerGetUserPublisherInternalDataResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnServerGetUserPublisherReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnServerGetUserPublisherReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnServerGetUserReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnServerGetUserReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<UpdatePlayerStatisticsRequest> OnServerUpdatePlayerStatisticsRequestEvent;
        public event PlayFabResultEvent<UpdatePlayerStatisticsResult> OnServerUpdatePlayerStatisticsResultEvent;
        public event PlayFabRequestEvent<UpdateUserDataRequest> OnServerUpdateUserDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnServerUpdateUserDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserInternalDataRequest> OnServerUpdateUserInternalDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnServerUpdateUserInternalDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserDataRequest> OnServerUpdateUserPublisherDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnServerUpdateUserPublisherDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserInternalDataRequest> OnServerUpdateUserPublisherInternalDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnServerUpdateUserPublisherInternalDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserDataRequest> OnServerUpdateUserPublisherReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnServerUpdateUserPublisherReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserDataRequest> OnServerUpdateUserReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnServerUpdateUserReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<GetCatalogItemsRequest> OnServerGetCatalogItemsRequestEvent;
        public event PlayFabResultEvent<GetCatalogItemsResult> OnServerGetCatalogItemsResultEvent;
        public event PlayFabRequestEvent<GetPublisherDataRequest> OnServerGetPublisherDataRequestEvent;
        public event PlayFabResultEvent<GetPublisherDataResult> OnServerGetPublisherDataResultEvent;
        public event PlayFabRequestEvent<GetTimeRequest> OnServerGetTimeRequestEvent;
        public event PlayFabResultEvent<GetTimeResult> OnServerGetTimeResultEvent;
        public event PlayFabRequestEvent<GetTitleDataRequest> OnServerGetTitleDataRequestEvent;
        public event PlayFabResultEvent<GetTitleDataResult> OnServerGetTitleDataResultEvent;
        public event PlayFabRequestEvent<GetTitleDataRequest> OnServerGetTitleInternalDataRequestEvent;
        public event PlayFabResultEvent<GetTitleDataResult> OnServerGetTitleInternalDataResultEvent;
        public event PlayFabRequestEvent<GetTitleNewsRequest> OnServerGetTitleNewsRequestEvent;
        public event PlayFabResultEvent<GetTitleNewsResult> OnServerGetTitleNewsResultEvent;
        public event PlayFabRequestEvent<SetPublisherDataRequest> OnServerSetPublisherDataRequestEvent;
        public event PlayFabResultEvent<SetPublisherDataResult> OnServerSetPublisherDataResultEvent;
        public event PlayFabRequestEvent<SetTitleDataRequest> OnServerSetTitleDataRequestEvent;
        public event PlayFabResultEvent<SetTitleDataResult> OnServerSetTitleDataResultEvent;
        public event PlayFabRequestEvent<SetTitleDataRequest> OnServerSetTitleInternalDataRequestEvent;
        public event PlayFabResultEvent<SetTitleDataResult> OnServerSetTitleInternalDataResultEvent;
        public event PlayFabRequestEvent<AddCharacterVirtualCurrencyRequest> OnServerAddCharacterVirtualCurrencyRequestEvent;
        public event PlayFabResultEvent<ModifyCharacterVirtualCurrencyResult> OnServerAddCharacterVirtualCurrencyResultEvent;
        public event PlayFabRequestEvent<AddUserVirtualCurrencyRequest> OnServerAddUserVirtualCurrencyRequestEvent;
        public event PlayFabResultEvent<ModifyUserVirtualCurrencyResult> OnServerAddUserVirtualCurrencyResultEvent;
        public event PlayFabRequestEvent<ConsumeItemRequest> OnServerConsumeItemRequestEvent;
        public event PlayFabResultEvent<ConsumeItemResult> OnServerConsumeItemResultEvent;
        public event PlayFabRequestEvent<EvaluateRandomResultTableRequest> OnServerEvaluateRandomResultTableRequestEvent;
        public event PlayFabResultEvent<EvaluateRandomResultTableResult> OnServerEvaluateRandomResultTableResultEvent;
        public event PlayFabRequestEvent<GetCharacterInventoryRequest> OnServerGetCharacterInventoryRequestEvent;
        public event PlayFabResultEvent<GetCharacterInventoryResult> OnServerGetCharacterInventoryResultEvent;
        public event PlayFabRequestEvent<GetRandomResultTablesRequest> OnServerGetRandomResultTablesRequestEvent;
        public event PlayFabResultEvent<GetRandomResultTablesResult> OnServerGetRandomResultTablesResultEvent;
        public event PlayFabRequestEvent<GetUserInventoryRequest> OnServerGetUserInventoryRequestEvent;
        public event PlayFabResultEvent<GetUserInventoryResult> OnServerGetUserInventoryResultEvent;
        public event PlayFabRequestEvent<GrantItemsToCharacterRequest> OnServerGrantItemsToCharacterRequestEvent;
        public event PlayFabResultEvent<GrantItemsToCharacterResult> OnServerGrantItemsToCharacterResultEvent;
        public event PlayFabRequestEvent<GrantItemsToUserRequest> OnServerGrantItemsToUserRequestEvent;
        public event PlayFabResultEvent<GrantItemsToUserResult> OnServerGrantItemsToUserResultEvent;
        public event PlayFabRequestEvent<GrantItemsToUsersRequest> OnServerGrantItemsToUsersRequestEvent;
        public event PlayFabResultEvent<GrantItemsToUsersResult> OnServerGrantItemsToUsersResultEvent;
        public event PlayFabRequestEvent<ModifyItemUsesRequest> OnServerModifyItemUsesRequestEvent;
        public event PlayFabResultEvent<ModifyItemUsesResult> OnServerModifyItemUsesResultEvent;
        public event PlayFabRequestEvent<MoveItemToCharacterFromCharacterRequest> OnServerMoveItemToCharacterFromCharacterRequestEvent;
        public event PlayFabResultEvent<MoveItemToCharacterFromCharacterResult> OnServerMoveItemToCharacterFromCharacterResultEvent;
        public event PlayFabRequestEvent<MoveItemToCharacterFromUserRequest> OnServerMoveItemToCharacterFromUserRequestEvent;
        public event PlayFabResultEvent<MoveItemToCharacterFromUserResult> OnServerMoveItemToCharacterFromUserResultEvent;
        public event PlayFabRequestEvent<MoveItemToUserFromCharacterRequest> OnServerMoveItemToUserFromCharacterRequestEvent;
        public event PlayFabResultEvent<MoveItemToUserFromCharacterResult> OnServerMoveItemToUserFromCharacterResultEvent;
        public event PlayFabRequestEvent<RedeemCouponRequest> OnServerRedeemCouponRequestEvent;
        public event PlayFabResultEvent<RedeemCouponResult> OnServerRedeemCouponResultEvent;
        public event PlayFabRequestEvent<ReportPlayerServerRequest> OnServerReportPlayerRequestEvent;
        public event PlayFabResultEvent<ReportPlayerServerResult> OnServerReportPlayerResultEvent;
        public event PlayFabRequestEvent<RevokeInventoryItemRequest> OnServerRevokeInventoryItemRequestEvent;
        public event PlayFabResultEvent<RevokeInventoryResult> OnServerRevokeInventoryItemResultEvent;
        public event PlayFabRequestEvent<SubtractCharacterVirtualCurrencyRequest> OnServerSubtractCharacterVirtualCurrencyRequestEvent;
        public event PlayFabResultEvent<ModifyCharacterVirtualCurrencyResult> OnServerSubtractCharacterVirtualCurrencyResultEvent;
        public event PlayFabRequestEvent<SubtractUserVirtualCurrencyRequest> OnServerSubtractUserVirtualCurrencyRequestEvent;
        public event PlayFabResultEvent<ModifyUserVirtualCurrencyResult> OnServerSubtractUserVirtualCurrencyResultEvent;
        public event PlayFabRequestEvent<UnlockContainerInstanceRequest> OnServerUnlockContainerInstanceRequestEvent;
        public event PlayFabResultEvent<UnlockContainerItemResult> OnServerUnlockContainerInstanceResultEvent;
        public event PlayFabRequestEvent<UnlockContainerItemRequest> OnServerUnlockContainerItemRequestEvent;
        public event PlayFabResultEvent<UnlockContainerItemResult> OnServerUnlockContainerItemResultEvent;
        public event PlayFabRequestEvent<UpdateUserInventoryItemDataRequest> OnServerUpdateUserInventoryItemCustomDataRequestEvent;
        public event PlayFabResultEvent<EmptyResult> OnServerUpdateUserInventoryItemCustomDataResultEvent;
        public event PlayFabRequestEvent<AddFriendRequest> OnServerAddFriendRequestEvent;
        public event PlayFabResultEvent<EmptyResult> OnServerAddFriendResultEvent;
        public event PlayFabRequestEvent<GetFriendsListRequest> OnServerGetFriendsListRequestEvent;
        public event PlayFabResultEvent<GetFriendsListResult> OnServerGetFriendsListResultEvent;
        public event PlayFabRequestEvent<RemoveFriendRequest> OnServerRemoveFriendRequestEvent;
        public event PlayFabResultEvent<EmptyResult> OnServerRemoveFriendResultEvent;
        public event PlayFabRequestEvent<SetFriendTagsRequest> OnServerSetFriendTagsRequestEvent;
        public event PlayFabResultEvent<EmptyResult> OnServerSetFriendTagsResultEvent;
        public event PlayFabRequestEvent<DeregisterGameRequest> OnServerDeregisterGameRequestEvent;
        public event PlayFabResultEvent<DeregisterGameResponse> OnServerDeregisterGameResultEvent;
        public event PlayFabRequestEvent<NotifyMatchmakerPlayerLeftRequest> OnServerNotifyMatchmakerPlayerLeftRequestEvent;
        public event PlayFabResultEvent<NotifyMatchmakerPlayerLeftResult> OnServerNotifyMatchmakerPlayerLeftResultEvent;
        public event PlayFabRequestEvent<RedeemMatchmakerTicketRequest> OnServerRedeemMatchmakerTicketRequestEvent;
        public event PlayFabResultEvent<RedeemMatchmakerTicketResult> OnServerRedeemMatchmakerTicketResultEvent;
        public event PlayFabRequestEvent<RefreshGameServerInstanceHeartbeatRequest> OnServerRefreshGameServerInstanceHeartbeatRequestEvent;
        public event PlayFabResultEvent<RefreshGameServerInstanceHeartbeatResult> OnServerRefreshGameServerInstanceHeartbeatResultEvent;
        public event PlayFabRequestEvent<RegisterGameRequest> OnServerRegisterGameRequestEvent;
        public event PlayFabResultEvent<RegisterGameResponse> OnServerRegisterGameResultEvent;
        public event PlayFabRequestEvent<SetGameServerInstanceDataRequest> OnServerSetGameServerInstanceDataRequestEvent;
        public event PlayFabResultEvent<SetGameServerInstanceDataResult> OnServerSetGameServerInstanceDataResultEvent;
        public event PlayFabRequestEvent<SetGameServerInstanceStateRequest> OnServerSetGameServerInstanceStateRequestEvent;
        public event PlayFabResultEvent<SetGameServerInstanceStateResult> OnServerSetGameServerInstanceStateResultEvent;
        public event PlayFabRequestEvent<SetGameServerInstanceTagsRequest> OnServerSetGameServerInstanceTagsRequestEvent;
        public event PlayFabResultEvent<SetGameServerInstanceTagsResult> OnServerSetGameServerInstanceTagsResultEvent;
        public event PlayFabRequestEvent<WriteServerCharacterEventRequest> OnServerWriteCharacterEventRequestEvent;
        public event PlayFabResultEvent<WriteEventResponse> OnServerWriteCharacterEventResultEvent;
        public event PlayFabRequestEvent<WriteServerPlayerEventRequest> OnServerWritePlayerEventRequestEvent;
        public event PlayFabResultEvent<WriteEventResponse> OnServerWritePlayerEventResultEvent;
        public event PlayFabRequestEvent<WriteTitleEventRequest> OnServerWriteTitleEventRequestEvent;
        public event PlayFabResultEvent<WriteEventResponse> OnServerWriteTitleEventResultEvent;
        public event PlayFabRequestEvent<AddSharedGroupMembersRequest> OnServerAddSharedGroupMembersRequestEvent;
        public event PlayFabResultEvent<AddSharedGroupMembersResult> OnServerAddSharedGroupMembersResultEvent;
        public event PlayFabRequestEvent<CreateSharedGroupRequest> OnServerCreateSharedGroupRequestEvent;
        public event PlayFabResultEvent<CreateSharedGroupResult> OnServerCreateSharedGroupResultEvent;
        public event PlayFabRequestEvent<DeleteSharedGroupRequest> OnServerDeleteSharedGroupRequestEvent;
        public event PlayFabResultEvent<EmptyResult> OnServerDeleteSharedGroupResultEvent;
        public event PlayFabRequestEvent<GetSharedGroupDataRequest> OnServerGetSharedGroupDataRequestEvent;
        public event PlayFabResultEvent<GetSharedGroupDataResult> OnServerGetSharedGroupDataResultEvent;
        public event PlayFabRequestEvent<RemoveSharedGroupMembersRequest> OnServerRemoveSharedGroupMembersRequestEvent;
        public event PlayFabResultEvent<RemoveSharedGroupMembersResult> OnServerRemoveSharedGroupMembersResultEvent;
        public event PlayFabRequestEvent<UpdateSharedGroupDataRequest> OnServerUpdateSharedGroupDataRequestEvent;
        public event PlayFabResultEvent<UpdateSharedGroupDataResult> OnServerUpdateSharedGroupDataResultEvent;
        public event PlayFabRequestEvent<ExecuteCloudScriptServerRequest> OnServerExecuteCloudScriptRequestEvent;
        public event PlayFabResultEvent<ExecuteCloudScriptResult> OnServerExecuteCloudScriptResultEvent;
        public event PlayFabRequestEvent<GetContentDownloadUrlRequest> OnServerGetContentDownloadUrlRequestEvent;
        public event PlayFabResultEvent<GetContentDownloadUrlResult> OnServerGetContentDownloadUrlResultEvent;
        public event PlayFabRequestEvent<DeleteCharacterFromUserRequest> OnServerDeleteCharacterFromUserRequestEvent;
        public event PlayFabResultEvent<DeleteCharacterFromUserResult> OnServerDeleteCharacterFromUserResultEvent;
        public event PlayFabRequestEvent<ListUsersCharactersRequest> OnServerGetAllUsersCharactersRequestEvent;
        public event PlayFabResultEvent<ListUsersCharactersResult> OnServerGetAllUsersCharactersResultEvent;
        public event PlayFabRequestEvent<GetCharacterLeaderboardRequest> OnServerGetCharacterLeaderboardRequestEvent;
        public event PlayFabResultEvent<GetCharacterLeaderboardResult> OnServerGetCharacterLeaderboardResultEvent;
        public event PlayFabRequestEvent<GetCharacterStatisticsRequest> OnServerGetCharacterStatisticsRequestEvent;
        public event PlayFabResultEvent<GetCharacterStatisticsResult> OnServerGetCharacterStatisticsResultEvent;
        public event PlayFabRequestEvent<GetLeaderboardAroundCharacterRequest> OnServerGetLeaderboardAroundCharacterRequestEvent;
        public event PlayFabResultEvent<GetLeaderboardAroundCharacterResult> OnServerGetLeaderboardAroundCharacterResultEvent;
        public event PlayFabRequestEvent<GetLeaderboardForUsersCharactersRequest> OnServerGetLeaderboardForUserCharactersRequestEvent;
        public event PlayFabResultEvent<GetLeaderboardForUsersCharactersResult> OnServerGetLeaderboardForUserCharactersResultEvent;
        public event PlayFabRequestEvent<GrantCharacterToUserRequest> OnServerGrantCharacterToUserRequestEvent;
        public event PlayFabResultEvent<GrantCharacterToUserResult> OnServerGrantCharacterToUserResultEvent;
        public event PlayFabRequestEvent<UpdateCharacterStatisticsRequest> OnServerUpdateCharacterStatisticsRequestEvent;
        public event PlayFabResultEvent<UpdateCharacterStatisticsResult> OnServerUpdateCharacterStatisticsResultEvent;
        public event PlayFabRequestEvent<GetCharacterDataRequest> OnServerGetCharacterDataRequestEvent;
        public event PlayFabResultEvent<GetCharacterDataResult> OnServerGetCharacterDataResultEvent;
        public event PlayFabRequestEvent<GetCharacterDataRequest> OnServerGetCharacterInternalDataRequestEvent;
        public event PlayFabResultEvent<GetCharacterDataResult> OnServerGetCharacterInternalDataResultEvent;
        public event PlayFabRequestEvent<GetCharacterDataRequest> OnServerGetCharacterReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<GetCharacterDataResult> OnServerGetCharacterReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<UpdateCharacterDataRequest> OnServerUpdateCharacterDataRequestEvent;
        public event PlayFabResultEvent<UpdateCharacterDataResult> OnServerUpdateCharacterDataResultEvent;
        public event PlayFabRequestEvent<UpdateCharacterDataRequest> OnServerUpdateCharacterInternalDataRequestEvent;
        public event PlayFabResultEvent<UpdateCharacterDataResult> OnServerUpdateCharacterInternalDataResultEvent;
        public event PlayFabRequestEvent<UpdateCharacterDataRequest> OnServerUpdateCharacterReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<UpdateCharacterDataResult> OnServerUpdateCharacterReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<AddPlayerTagRequest> OnServerAddPlayerTagRequestEvent;
        public event PlayFabResultEvent<AddPlayerTagResult> OnServerAddPlayerTagResultEvent;
        public event PlayFabRequestEvent<GetAllActionGroupsRequest> OnServerGetAllActionGroupsRequestEvent;
        public event PlayFabResultEvent<GetAllActionGroupsResult> OnServerGetAllActionGroupsResultEvent;
        public event PlayFabRequestEvent<GetAllSegmentsRequest> OnServerGetAllSegmentsRequestEvent;
        public event PlayFabResultEvent<GetAllSegmentsResult> OnServerGetAllSegmentsResultEvent;
        public event PlayFabRequestEvent<GetPlayersSegmentsRequest> OnServerGetPlayerSegmentsRequestEvent;
        public event PlayFabResultEvent<GetPlayerSegmentsResult> OnServerGetPlayerSegmentsResultEvent;
        public event PlayFabRequestEvent<GetPlayersInSegmentRequest> OnServerGetPlayersInSegmentRequestEvent;
        public event PlayFabResultEvent<GetPlayersInSegmentResult> OnServerGetPlayersInSegmentResultEvent;
        public event PlayFabRequestEvent<GetPlayerTagsRequest> OnServerGetPlayerTagsRequestEvent;
        public event PlayFabResultEvent<GetPlayerTagsResult> OnServerGetPlayerTagsResultEvent;
        public event PlayFabRequestEvent<RemovePlayerTagRequest> OnServerRemovePlayerTagRequestEvent;
        public event PlayFabResultEvent<RemovePlayerTagResult> OnServerRemovePlayerTagResultEvent;
        public event PlayFabRequestEvent<AwardSteamAchievementRequest> OnServerAwardSteamAchievementRequestEvent;
        public event PlayFabResultEvent<AwardSteamAchievementResult> OnServerAwardSteamAchievementResultEvent;
    }
}
#endif
