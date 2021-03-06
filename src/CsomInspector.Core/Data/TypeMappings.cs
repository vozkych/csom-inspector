﻿using System;
using System.Collections.Generic;

namespace CsomInspector.Core
{
	public class TypeMappings
	{
		public TypeMappings()
		{
			_mappings = new Dictionary<Guid, string>();
		}

		private static TypeMappings _current;

		private Dictionary<Guid, String> _mappings;

		public static TypeMappings Current
		{
			get
			{
				if (_current == null)
				{
					_current = CreateMappings();
				}

				return _current;
			}
		}

		public static TypeMappings CreateMappings()
		{
			var mappings = new TypeMappings();
			mappings
				.Add("e7dae9f6-8aa5-4b86-92c8-61941d774c44", "SPAccessRequests")
				.Add("2b6ef6c5-00b4-48ef-bc7c-2db4eb650057", "SPAddFieldOptions")
				.Add("5530f782-6a0d-41ec-bfd9-2cb628fe1557", "SPAppContextSite")
				.Add("d3425bf9-fe82-4957-afda-5fbd21dabb85", "SPAppLicense")
				.Add("47beb529-4c4b-41ba-b717-28d18fbdf258", "SPAppLicenseCollection")
				.Add("a6459162-864d-42cb-942b-c832ec683c0d", "SPAppLicenseType")
				.Add("a19a4c61-d4c0-4100-9d47-a04be33af6f1", "SPAppPrincipal")
				.Add("358f59ee-7e98-4cc0-9f40-a160ccf3879f", "SPAppPrincipalConfiguration_Client")
				.Add("9c0b9f8a-d87b-431d-bc10-d0f0b4afc79c", "SPAppPrincipalCredential")
				.Add("aaf308b2-ebdd-4a5b-be65-01bb0ec8c5be", "SPAppPrincipalCredentialReference_Client")
				.Add("3cc457ae-d404-4747-8b95-c6f86bfd1842", "SPAppPrincipalIdentityProvider")
				.Add("1daee121-93ea-40e6-aad2-15252287f09a", "SPAppPrincipalManager")
				.Add("2f631229-b71e-4ddf-83d6-96d290d0fc57", "SPAppPrincipalName")
				.Add("abd102de-1731-4be2-ae7e-3515371cc5c7", "SPAttachment_Client")
				.Add("f4e86471-7dab-4b47-b061-50a40e27140e", "SPAttachmentCollection_Client")
				.Add("edf6309c-8142-4133-921e-4d6aec35550d", "SPAttachmentCreationInformation")
				.Add("db780e5a-6bc6-41ad-8e64-9dfa761afb6d", "SPBasePermissions_Client")
				.Add("cd94d520-94f8-4bed-84a2-ea49eeda9b93", "SPCalendarType")
				.Add("c717121b-f82f-4afb-a2b7-25f67522120f", "SPChange")
				.Add("04f51ef5-013c-4e05-b23f-a9719e69a49a", "SPChangeAlert")
				.Add("2ba7a459-eeda-42d0-90e2-fad3487ad0d3", "SPChangeCollection")
				.Add("b50ef7a3-7f78-4afc-91ef-616591de9e4d", "SPChangeContentType")
				.Add("8d687151-6601-4ad0-9e94-91448e3e2749", "SPChangeField")
				.Add("59dd36eb-9235-4dad-a8fd-26d3c11a6a18", "SPChangeFile")
				.Add("3b97573d-cee5-446a-853d-57ea0acf8aa4", "SPChangeFolder")
				.Add("8c377687-4e62-4ddb-b244-20a832de16dd", "SPChangeGroup")
				.Add("3e4716ac-a622-4d48-bc14-3fecabd52e21", "SPChangeItem")
				.Add("d3ef3368-ff71-4de1-867c-19693c781587", "SPChangeList")
				.Add("820ed5a1-95f7-493b-88fa-266e9db920af", "SPChangeLogItemQuery")
				.Add("887a7218-1232-4cfc-b78f-88d54e9d8ec7", "SPChangeQuery")
				.Add("81aff0de-302e-4d01-91d5-96192f77bc29", "SPChangeSite")
				.Add("41c5be82-b5bf-4b5a-9712-97111fb87686", "SPChangeToken")
				.Add("dc90936b-e6fd-45dd-b1c6-431d497ecd70", "SPChangeType")
				.Add("9bcb7adb-5a47-426e-886f-3ce841554cd9", "SPChangeUser")
				.Add("865f3490-f526-4452-88e2-6e33357bae50", "SPChangeView")
				.Add("e7fa8647-bde1-474c-93b1-1ef9ce5cf02c", "SPChangeWeb")
				.Add("5806d374-4904-49e9-a73f-3265ee2e06c6", "SPClientRequestVariable")
				.Add("3a64e199-fbe8-4277-960b-9067471cf64b", "SPCompatibilityRange")
				.Add("91b5bd2d-e133-486f-b727-197ce5eb2c0d", "SPContentType")
				.Add("653e9412-6245-4a3f-829b-cfdbf7fd86a5", "SPContentTypeCollection")
				.Add("168f3091-4554-4f14-8866-b20d48e45b54", "SPContentTypeCreationInformation")
				.Add("30e94405-dfd3-472e-b5d7-637ce8e9586c", "SPContentTypeEntityData")
				.Add("da0f1e90-296f-480e-bc27-cefe51eff241", "SPContentTypeId")
				.Add("3747adcd-a3c3-41b9-bfab-4a64dd2f1e0a", "SPContext")
				.Add("df0c42fe-fc26-4d81-a32e-a40090d1acb7", "SPContextWebInformation")
				.Add("a8d3515c-1135-4fff-95a6-4e5e5fff4adc", "SPEventReceiverDefinition")
				.Add("8aef5b03-f05e-46e9-9537-6c3aad574b7a", "SPEventReceiverDefinitionCollection")
				.Add("2c15382f-b6e4-41f6-8616-4cbe0080a5de", "SPEventReceiverDefinitionCreationInformation")
				.Add("5d3a2eae-4870-414e-b9ae-8f1904b28408", "SPExternalAppPrincipalCreationParameters_Client")
				.Add("4e46b28c-e27f-4964-a8d4-fc25658d86d1", "SPFeature")
				.Add("8b9c0015-193d-4062-8e98-8d23c303eedd", "SPFeatureCollection")
				.Add("c4121b04-0f57-4b1d-a145-d25426b16480", "SPField")
				.Add("f9ee4627-2914-46cd-806a-4921f96a0c72", "SPFieldCalculated")
				.Add("3387286b-36e3-4199-bdca-f20048ce8328", "SPFieldCalculatedErrorValue")
				.Add("a0b73943-fabc-47d3-b2c8-ec41b1216b1d", "SPFieldChoice")
				.Add("d449d756-e113-4d27-a5e7-609cbc3eba7e", "SPFieldCollection")
				.Add("379b8994-f0e7-4c74-a1e6-185eb8600c3c", "SPFieldComputed")
				.Add("46c21c03-8e93-4e5a-bf90-228366397c9a", "SPFieldCreationInformation")
				.Add("e03ca5f6-5f18-47f3-8ab4-74caba56ee1e", "SPFieldCurrency")
				.Add("4f9dc9b4-d900-40eb-94b9-008abbfb22e1", "SPFieldDateTime")
				.Add("1e760655-b990-4f6f-8319-add93e96a28b", "SPFieldEntityData")
				.Add("d5a367f2-3b74-4984-ab50-9a700883c90b", "SPFieldGeolocation")
				.Add("97650aff-7e7b-44be-ac6e-d559f7f897a2", "SPFieldGeolocationValue")
				.Add("768b27aa-a4e0-4cfb-9956-1f7f0e93fb42", "SPFieldGuid")
				.Add("e2d99203-868f-4211-ac76-f6bca0ff94ee", "SPFieldLink")
				.Add("6d87e76a-b8a8-4634-8170-082b1d454bfd", "SPFieldLinkCollection")
				.Add("63fb2c92-8f65-4bbb-a658-b6cd294403f4", "SPFieldLinkCreationInformation")
				.Add("60ef85b1-1d32-49a1-8d99-c6f66f84fb0a", "SPFieldLinkEntityData")
				.Add("ee47ff61-3260-43a9-be22-829a1fa85b44", "SPFieldLookup")
				.Add("f1d34cc0-9b50-4a78-be78-d5facfcccfb7", "SPFieldLookupValue")
				.Add("284c160f-3783-4344-a471-80e032719f26", "SPFieldMultiChoice")
				.Add("9ae17ecc-11a6-4433-8b51-7ecb865ffe05", "SPFieldMultiLineText")
				.Add("e32d2a19-d2a8-428c-b056-ea71ede547ce", "SPFieldNumber")
				.Add("66d84fdd-bdb2-4e21-bed0-67f3eab33de4", "SPFieldRatingScale")
				.Add("9b88fe8e-47cd-4ddc-9d66-0d12d70dde28", "SPFieldRatingScaleQuestionAnswer")
				.Add("542fa9df-ac22-4fdb-8ba3-dab6060c2de4", "SPFieldStringValues")
				.Add("47cba3a7-3327-4fa1-ac10-73a7a182fe05", "SPFieldText")
				.Add("5760d11e-6e91-4eb1-aef5-272502aedf52", "SPFieldType")
				.Add("b1ae9217-e0b0-4e34-9604-bd2462647ee9", "SPFieldUrl")
				.Add("fa8b44af-7b43-43f2-904a-bd319497011e", "SPFieldUrlValue")
				.Add("ebd2fb89-e8a2-46c4-b317-9b2347121765", "SPFieldUser")
				.Add("8a8096e8-e1d2-46f7-9851-6c47c5da92bb", "SPFieldUserSelectionMode")
				.Add("c956ab54-16bd-4c18-89d2-996f57282a6f", "SPFieldUserValue")
				.Add("df28be1e-74b5-4b21-b73a-2bbac0a23d8a", "SPFile")
				.Add("5a1b05ac-9a61-4594-939d-9650cc8abc6c", "SPFile+SPCheckOutType")
				.Add("d367b17c-170b-4691-a1e3-8bccf7686ce4", "SPFileCollection")
				.Add("f5c8173c-cae6-4469-a7af-3879ca3c617c", "SPFileCreationInformation")
				.Add("0d15651c-56c0-4c6a-8c86-555d0187e6f9", "SPFileLevel")
				.Add("c3de0784-43e6-4f12-bd0c-f0d9a34ebf93", "SPFileSaveBinaryInformation")
				.Add("96e4bc1b-e67f-4967-9327-36b79e20aebc", "SPFileVersion")
				.Add("3826e282-67a6-4861-88fb-474e8aac897b", "SPFileVersionCollection")
				.Add("dbe8175a-505d-4eff-bec4-6c809709808b", "SPFolder")
				.Add("b6b425aa-9e17-4205-a4aa-b82c2c3f884d", "SPFolderCollection")
				.Add("0ffbd1db-e28a-42aa-a6ba-ccf4f2626a6b", "SPFolderEntityData")
				.Add("50aaca3c-fa54-47d2-b946-a2839ee956a9", "SPForm")
				.Add("078611ea-ce4d-45c0-9b7a-d4b1b46cc327", "SPFormCollection")
				.Add("e54ad5f1-ce4e-453b-b7f7-aea6556c9c40", "SPGroup")
				.Add("0b9f0e6c-2c15-425e-b0b2-961f78bf1ecf", "SPGroupCollection")
				.Add("9fd1540e-59e6-47fa-9a00-5173c9c35785", "SPGroupCreationInformation")
				.Add("0a72c1d0-013f-4659-bb0f-af08f1ead17a", "SPGroupEntityData")
				.Add("dc0556de-b544-4702-b2dc-9886ac31b25f", "SPInformationRightsManagementSettings")
				.Add("eae9f1b5-1ae9-417b-9a8b-04a1b4c05a4b", "SPLanguage")
				.Add("d89f0b18-614e-4b4a-bac0-fd6142b55448", "SPList")
				.Add("1e78b736-61f0-441c-a785-10fc25387c8d", "SPListCollection")
				.Add("e247b7fc-095e-4ea4-a4c9-c5d373723d8c", "SPListCreationInformation")
				.Add("06bfe4a5-1516-4b55-a6d7-ecbe3ff7a3c8", "SPListDataSource")
				.Add("356fe248-721a-4adf-af96-20822bc5476e", "SPListDataValidationException")
				.Add("6e0bc783-53a2-4506-827f-135040524794", "SPListDataValidationException+SPFailure")
				.Add("c2bb2cd4-16ac-485b-8dbd-10c8f856af27", "SPListEntityData")
				.Add("53cc48c0-1777-47b7-99ca-729390f06602", "SPListItem")
				.Add("1722df25-a4d3-44bb-a1c6-04dbb90e9d91", "SPListItemCollection")
				.Add("922354eb-c56a-4d88-ad59-67496854efe1", "SPListItemCollectionPosition")
				.Add("54cdbee5-0897-44ac-829f-411557fa11be", "SPListItemCreationInformation")
				.Add("ff83e272-f05f-4215-93e2-2c6df20ec8c7", "SPListItemEntityCollection")
				.Add("03745a5a-2400-440e-92d6-dad4afee30a6", "SPListItemFormUpdateValue")
				.Add("d772ecd1-daa3-4cb1-9ea1-feea1e383fb2", "SPListTemplate")
				.Add("a5cbd08d-0816-4c32-86f5-0b2bf81286bb", "SPListTemplate+QuickLaunchOptions")
				.Add("23748d10-16a1-4946-a38b-98fdec0e0ec8", "SPListTemplateCollection")
				.Add("e7dae9f6-8ca5-4286-92c8-61941d774c44", "SPObjectSharingInformation")
				.Add("f7b7fe66-58a7-4843-882d-99af0d97992b", "SPObjectSharingInformationUser")
				.Add("8a76e712-17a1-4a40-b2df-cca7c060d78f", "SPPrincipal")
				.Add("3973524d-2d5a-4683-aa39-38a2acc6e63c", "SPPropertyValues")
				.Add("1489add2-5d3a-4de8-9445-49259462dceb", "SPPushNotificationSubscriber")
				.Add("99676b16-b4c9-429a-b3d9-de883c42c4d5", "SPPushNotificationSubscriberCollection")
				.Add("3d248d7b-fc86-40a3-aa97-02a75d69fb8a", "SPQuery")
				.Add("5ebf462e-9e9a-440c-992b-abbb3916563d", "SPRecycleBinItem")
				.Add("9bfb60cf-1aca-484c-a845-5f2d4ef20865", "SPRecycleBinItemCollection")
				.Add("84c424a9-a1d6-46ba-8398-c46257ecd25b", "SPRegionalSettings")
				.Add("a91deb1a-2f24-4ac5-a1a6-3b1e530c307f", "SPRelatedField")
				.Add("4703193f-e3ed-445b-8612-7c6218e0eb5a", "SPRelatedFieldCollection")
				.Add("45fbcb1b-f734-4a96-86fe-836835c605f0", "SPRelatedFieldExtendedData")
				.Add("32ed187c-003c-413f-9799-1a2822ade931", "SPRelatedFieldExtendedDataCollection")
				.Add("07da03be-4d19-48f3-9c5f-7c67b134a93b", "SPRoleAssignment")
				.Add("2690207a-e174-4d49-b2ca-cff663225dc1", "SPRoleAssignmentCollection")
				.Add("aa7ecb4a-9c7e-4ad9-bd20-58a2775e5ad7", "SPRoleDefinition")
				.Add("07bf1941-6953-4761-b114-58374b4aaf57", "SPRoleDefinitionBindingCollection")
				.Add("964b9ab0-d026-4487-99d1-e06450963cc9", "SPRoleDefinitionCollection")
				.Add("59eddf82-1018-4677-8067-69e16efd3495", "SPRoleDefinitionCreationInformation")
				.Add("0fe30e07-e34c-4e7f-b268-181000618a50", "SPRoleDefinitionEntityData")
				.Add("1b1bf348-994e-44fd-823f-0748f5ad94c8", "SPSecurableObject")
				.Add("e1bb82e8-0d1e-4e52-b90c-684802ab4ef6", "SPSite")
				.Add("a012e5fa-a28f-4232-9561-c4033f61c889", "SPSiteUpgradeInfo")
				.Add("d7da1187-8020-42ec-97f4-823ac965ac75", "SPSiteUrl")
				.Add("e3a4d63c-876b-4e24-a972-7664437146fe", "SPSubwebQuery")
				.Add("a27c3f63-3162-44dd-915f-fcaf888e8a8b", "SPTemplateFileType")
				.Add("1e0a65dd-0c5f-4d2c-ab41-a74312709124", "SPThemeInfo")
				.Add("5519d02c-ce37-4b91-b61d-a1cefe0fc85e", "SPTimeZone")
				.Add("117cbf47-7e74-4165-b26b-c24180ab2095", "SPTimeZoneCollection")
				.Add("09e18222-7e4d-488b-811d-6ef43f31d17f", "SPTimeZoneInformation")
				.Add("7a5cdee8-6380-4dbd-93f6-1e2e625ec05b", "SPUrlFieldFormatType")
				.Add("7ec28504-35f9-4fcf-a09f-401024417292", "SPUsageInfo_Client")
				.Add("ae70d2a4-ec46-4ed9-9b1e-9d0245754463", "SPUser")
				.Add("e090781e-8899-4672-9b3d-a78f49fad19d", "SPUserCollection")
				.Add("6ecd8af6-bed3-4a74-be76-1ec981b350e1", "SPUserCreationInformation")
				.Add("232f8709-5dfd-44cf-a35b-7d8538c9336e", "SPUserCustomAction")
				.Add("70d1cb2d-d304-4d96-9b54-74b3f400fa28", "SPUserCustomActionCollection")
				.Add("e05a84c0-6fc5-4ae7-be02-f5ac421a5bf6", "SPUserCustomActionEntityData")
				.Add("a8f3dda1-bc41-46fa-a5e5-683853a83d5a", "SPUserEntityData")
				.Add("c5c3ae1a-63b6-4f25-a887-54b0b20a28e2", "SPUserIdInfo")
				.Add("2399f45d-1784-4965-9a5f-a3415790a0d0", "SPView")
				.Add("03c5d7a9-9541-4482-9919-ca0cccf565a0", "SPViewCollection")
				.Add("a3547807-7266-42f3-b055-afa6e840e458", "SPViewCreationInformation")
				.Add("af975f76-8a94-4e6d-8325-bd1e20b7c301", "SPViewFieldCollection")
				.Add("aba82fb7-b9b3-4b03-9d2a-0d82f3199037", "SPViewScope")
				.Add("a489add2-5d3a-4de8-9445-49259462dceb", "SPWeb")
				.Add("c197d59e-d070-43bf-ad5e-10d6152e38a6", "SPWebCollection")
				.Add("8f9e9fbe-189e-492f-884f-98f9ef9cc4d6", "SPWebCreationInformation")
				.Add("5143cf01-79b3-425c-96b2-6e8b34a45d03", "SPWebInfoCreationInformation")
				.Add("f847686b-8e42-401c-88e4-b5ed4261a788", "SPWebInformation")
				.Add("fddc4ee9-dc2e-444e-9d02-664c255da6f1", "SPWebInformationCollection")
				.Add("656a77c4-1634-415c-bf85-c6c0cb286e0e", "SPWebProxy")
				.Add("71aa825d-bc12-422d-a177-d2e63fe68cd9", "SPWebRequestInfo")
				.Add("73b6054a-aa40-41e4-a34f-5a6f898e6d4f", "SPWebResponseInfo")
				.Add("2be10268-4be1-4b5a-850d-d06b137a9c40", "SPWebTemplate")
				.Add("15c2ecda-d49e-4fda-97c8-c538a203dfb5", "SPWebTemplateCollection")
				.Add("27b11de3-188c-43b6-a3ac-e7123e134db7", "SPXmlSchemaFieldCreationInformation")
				.Add("7d5e72a8-e4ca-4813-84c4-a479614927d0", "Microsoft.BusinessData.Runtime.EntityEventType_Client")
				.Add("36c08dbd-02e6-493e-99f5-df3f18342f85", "Microsoft.BusinessData.Runtime.IdentityMetadata")
				.Add("87d0a4ee-8341-4848-8078-5135a1357a9d", "Microsoft.BusinessData.Runtime.NotificationCallback_Client")
				.Add("69aa7dd9-23a0-4e20-9464-0749fc0e6406", "Microsoft.BusinessData.Runtime.Subscription_Client")
				.Add("3ba0823b-9b49-433b-a8a6-65a5139f06ec", "Microsoft.SharePoint.Administration.SiteHealth.SPSiteHealthResult")
				.Add("9a7aa548-96ab-4616-9f62-929d8007dac6", "Microsoft.SharePoint.Administration.SiteHealth.SPSiteHealthStatusType")
				.Add("9b6a775c-ee99-4df4-b251-3e004216d5b0", "Microsoft.SharePoint.Administration.SiteHealth.SPSiteHealthSummary")
				.Add("47228df5-e073-47ca-97a8-a0537b77a1df", "Microsoft.SharePoint.Administration.SPAnalyticsUsageEntry")
				.Add("d75aafc0-cbe3-4930-9637-bb32dd276c8f", "Microsoft.SharePoint.Administration.SPAnalyticsUsageService")
				.Add("7b3e0c67-45c1-423c-af60-240bd774adc0", "Microsoft.SharePoint.Administration.SPApp")
				.Add("8d36b2b8-5b9a-49a8-892b-5e9539faf4e8", "Microsoft.SharePoint.Administration.SPAppBdcCatalog")
				.Add("79cdee9f-257e-423b-9e94-e6404659f7ea", "Microsoft.SharePoint.Administration.SPAppCatalog")
				.Add("211a55df-058b-4917-ac93-2b5e08b1a9fd", "Microsoft.SharePoint.Administration.SPAppInstance")
				.Add("e1ee83cd-b0a5-4f57-a10c-5bcc11eb1c69", "Microsoft.SharePoint.Administration.SPAppInstanceErrorDetails")
				.Add("6a9108c5-4387-45c6-916a-37531883ca00", "Microsoft.SharePoint.Administration.SPAppInstanceErrorSource")
				.Add("d9af9943-b4f3-45c0-8471-5368c1c72e7e", "Microsoft.SharePoint.Administration.SPAppInstanceErrorType")
				.Add("587a34b9-8227-472e-9821-074aa2e53b60", "Microsoft.SharePoint.Administration.SPAppInstanceStatus")
				.Add("7c07dc97-a102-4e36-be68-c8cb9d250e40", "Microsoft.SharePoint.Administration.SPUrlZone")
				.Add("6dfa6eb7-93af-4625-95ea-508b84be1751", "Microsoft.SharePoint.Administration.UsageEntry")
				.Add("19e49ab8-90d1-44e1-b186-face114707f5", "Microsoft.SharePoint.AlternateUrl")
				.Add("ac9358c6-e9b1-4514-bf6e-106acbfb19ce", "Microsoft.SharePoint.ApplicationPages.ClientPickerQuery.ClientPeoplePickerQueryParameters")
				.Add("de2db963-8bab-4fb4-8a58-611aebc5254b", "Microsoft.SharePoint.ApplicationPages.ClientPickerQuery.ClientPeoplePickerWebServiceInterface")
				.Add("8a000bc7-5d42-4c47-af0b-3dd25b28d26f", "Microsoft.SharePoint.ApplicationPages.PickerQuery.PeoplePickerWebServiceInterface")
				.Add("7b23e667-073d-42e2-b519-2ff52345735a", "Microsoft.SharePoint.BusinessData.Infrastructure.EntityInstanceIdEncoder")
				.Add("b5d4dfa9-e948-4068-a32b-012eea5a1a61", "Microsoft.SharePoint.BusinessData.Infrastructure.ExternalSubscriptionStore")
				.Add("493fb354-e4a4-4577-b7f4-64bb868c128e", "Microsoft.SharePoint.BusinessData.MetadataModel.ClientOM.Entity")
				.Add("ea36af83-3d6a-4ae3-9eb1-4ed8e85eb176", "Microsoft.SharePoint.BusinessData.MetadataModel.ClientOM.Filter")
				.Add("86b6671b-e6e1-4f99-aa9d-d7a3ffbd6c16", "Microsoft.SharePoint.BusinessData.MetadataModel.ClientOM.Identifier")
				.Add("84eff1c0-d351-441f-a57f-f73a0785ccec", "Microsoft.SharePoint.BusinessData.MetadataModel.ClientOM.LobSystem")
				.Add("a59e617a-fed3-4c3f-8b2c-bb11edbf7827", "Microsoft.SharePoint.BusinessData.MetadataModel.ClientOM.LobSystemInstance")
				.Add("ea36af83-3d6a-4ae3-9eb1-4ed8e85eb179", "Microsoft.SharePoint.BusinessData.MetadataModel.ClientOM.MethodExecutionResult")
				.Add("48264c2b-6775-458b-88de-0c2a11938a03", "Microsoft.SharePoint.BusinessData.MetadataModel.ClientOM.ReturnParameterCollection")
				.Add("d981a4b4-5fbd-4c46-9101-5c5e67d4ab3b", "Microsoft.SharePoint.BusinessData.MetadataModel.ClientOM.TypeDescriptor")
				.Add("973b9891-3bef-4117-9e6f-90bdd6746d03", "Microsoft.SharePoint.BusinessData.MetadataModel.Collections.AbstractEntityInstanceCollection")
				.Add("53746712-30f8-4626-8bc5-b1a421452652", "Microsoft.SharePoint.BusinessData.MetadataModel.Collections.FieldCollection")
				.Add("508617ea-e4bd-4ec7-817c-b8335c6384a2", "Microsoft.SharePoint.BusinessData.MetadataModel.Collections.FilterCollection")
				.Add("0bf0d5b7-df64-4520-a1e1-76bc7517ee24", "Microsoft.SharePoint.BusinessData.MetadataModel.Collections.IdentifierCollection")
				.Add("3688d19c-d248-48cd-a46e-5f6719073953", "Microsoft.SharePoint.BusinessData.MetadataModel.Collections.LobSystemInstanceCollection")
				.Add("e33cca95-e780-4a9e-8704-fee069a29e02", "Microsoft.SharePoint.BusinessData.MetadataModel.Collections.TypeDescriptorCollection")
				.Add("2ea29bd5-5a5e-407c-a956-ba7babc6dcc7", "Microsoft.SharePoint.BusinessData.MetadataModel.Field")
				.Add("971264eb-8186-4b1d-9fb0-f3f9d2bdfb66", "Microsoft.SharePoint.BusinessData.MetadataModel.View")
				.Add("c75b5d2d-1e0c-41e2-89d1-a3b6016ac9ce", "Microsoft.SharePoint.BusinessData.Runtime.AbstractEntityInstance")
				.Add("48eac671-7e97-4f4c-8ca9-ee36263151f0", "Microsoft.SharePoint.BusinessData.Runtime.AbstractEntityInstanceMetadata")
				.Add("5bc2b16a-0bee-449a-9ef0-8a504ca2ad22", "Microsoft.SharePoint.BusinessData.Runtime.FieldValueDictionary")
				.Add("c59af889-5b65-47f1-bcbf-48616638c535", "Microsoft.SharePoint.Client.PersonalizationScopeMetadata")
				.Add("612a6bd9-6c99-43c9-813a-8d7e19702118", "Microsoft.SharePoint.Client.WebPartMetadata")
				.Add("b85a901b-328e-4378-922f-4f9ae35b36e1", "Microsoft.SharePoint.Navigation.EditableAspMenuNode")
				.Add("b85a901b-328e-4378-922f-4f9ae35b36e2", "Microsoft.SharePoint.Navigation.EditableAspMenuNodeType")
				.Add("b85a901b-328e-4378-922f-4f9ae35b36e0", "Microsoft.SharePoint.Navigation.EditableAspMenuState")
				.Add("8fe28b7a-6ebf-4f28-b564-5f0729301fac", "Microsoft.SharePoint.Navigation.REST.NavigationServiceRest")
				.Add("d6aa87a7-71b3-4bbe-bca7-00ab1bd7d37f", "Microsoft.SharePoint.Navigation.SPNavigation")
				.Add("cd5d6053-7ffd-41ac-bf36-7b856320a122", "Microsoft.SharePoint.Navigation.SPNavigationNode")
				.Add("2d818ed7-8fef-4a1c-bceb-a9404dfa482f", "Microsoft.SharePoint.Navigation.SPNavigationNodeCollection")
				.Add("7aaaa605-79a9-4fda-ae1e-db952e5083e0", "Microsoft.SharePoint.Navigation.SPNavigationNodeCreationInformation")
				.Add("bbadad58-037c-4d0d-8f81-e6090cae80df", "Microsoft.SharePoint.Navigation.SPNavigationNodeEntityData")
				.Add("627c69f5-12e8-46bc-9052-bd5e46e155d3", "Microsoft.SharePoint.RelatedItem")
				.Add("23af17db-2585-4d17-82a7-aa9e3fba099d", "Microsoft.SharePoint.RelatedItemManager")
				.Add("adfa7b3e-a27c-4288-9b6c-a8ea51bf082d", "Microsoft.SharePoint.ServerSettings")
				.Add("303c5101-90d6-4cd0-a49b-ce0f71a45d69", "Microsoft.SharePoint.Sharing.Role")
				.Add("10c23c0e-cead-4f15-9deb-a0f1d7507495", "Microsoft.SharePoint.Sharing.SPDocumentSharingManager")
				.Add("74485063-e2b5-424b-950c-4b62e816e31f", "Microsoft.SharePoint.Sharing.UserRoleAssignment")
				.Add("782142b7-1bb8-495f-8a60-9940982de38e", "Microsoft.SharePoint.Sharing.UserSharingResult")
				.Add("fab1608d-fdfb-4c8c-bb0a-9b9cc3618a15", "Microsoft.SharePoint.Utilities.EmailProperties")
				.Add("c88e4d2e-768d-4065-9da4-d2880e08733e", "Microsoft.SharePoint.Utilities.SPPrincipalInfo")
				.Add("fb45d8db-3caf-4062-b9e7-6b0b6c6c4d7d", "Microsoft.SharePoint.Utilities.SPPrincipalSource")
				.Add("c74ae150-6b15-4584-8d21-190f8560e84c", "Microsoft.SharePoint.Utilities.SPPrincipalType")
				.Add("16f43e7e-bf35-475d-b677-9dc61e549339", "Microsoft.SharePoint.Utilities.SPUtility")
				.Add("9e154aab-8847-4cf9-8bfa-eb8c1ec47926", "Microsoft.SharePoint.Utilities.SPWikiPageCreationInformation")
				.Add("ac641ade-62df-49c9-af8e-abda6278e920", "Microsoft.SharePoint.WebPartPages.SPLimitedWebPartManager")
				.Add("44bf1024-6127-432a-8e3d-fb317fb4541e", "Microsoft.SharePoint.WebPartPages.SPWebPartDefinition")
				.Add("01c986b2-57a6-49fb-b8f1-df159f5b2349", "Microsoft.SharePoint.WebPartPages.SPWebPartDefinitionCollection")
				.Add("9786d53b-4147-4e57-9d94-1d9f335d42b3", "Microsoft.SharePoint.WebPartPages.TileData")
				.Add("5b590642-3966-4f67-b937-c1db8528a1d3", "Microsoft.SharePoint.Workflow.SPWorkflowAssociation")
				.Add("4e1196ea-ce71-4aa9-b3c0-3f8da05deec9", "Microsoft.SharePoint.Workflow.SPWorkflowAssociationCollection")
				.Add("3c812f4f-8465-41cb-b298-bd33b2604a51", "Microsoft.SharePoint.Workflow.SPWorkflowAssociationCreationInformation")
				.Add("36de6dbb-60d6-4131-b47f-e895798e1e93", "Microsoft.SharePoint.Workflow.SPWorkflowTemplate")
				.Add("f64cc3d2-888a-43cc-b579-ef32f83338a4", "Microsoft.SharePoint.Workflow.SPWorkflowTemplateCollection");

			mappings
				.Add("981cbc68-9edc-4f8d-872f-71146fcbb84f", "Microsoft.SharePoint.Taxonomy.TaxonomySession")
				.Add("cf560d69-0fdb-4489-a216-b6b47adf8ef8", "Microsoft.Office.Server.UserProfiles.PeopleManager")
				.Add("8d2ac302-db2f-46fe-9015-872b35f15098", "Microsoft.SharePoint.Search.Query.SearchExecutor")
				.Add("80173281-fffd-47b6-9a49-312e06ff8428", "Microsoft.SharePoint.Search.Query.KeywordQuery");

			return mappings;
		}

		public String Get(Guid guid)
		{
			if (_mappings.ContainsKey(guid))
			{
				return _mappings[guid];
			}

			return guid.ToString("B");
		}

		private TypeMappings Add(Guid guid, String name)
		{
			_mappings.Add(guid, name);

			return this;
		}

		private TypeMappings Add(String guid, String name)
		{
			_mappings.Add(Guid.Parse(guid), name);

			return this;
		}
	}
}