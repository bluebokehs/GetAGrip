#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <stdint.h>

#include "codegen/il2cpp-codegen.h"
#include "il2cpp-object-internals.h"


// System.Void
struct Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017;



IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object


// System.ValueType
struct  ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF  : public RuntimeObject
{
public:

public:
};

// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_marshaled_com
{
};

// System.IntPtr
struct  IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};


// System.Void
struct  Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017__padding[1];
	};

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

extern "C" void DEFAULT_CALL ReversePInvokeWrapper_OSSpecificSynchronizationContext_InvocationEntry_m056BCE43FF155AAE872FF7E565F8F72A50D26147(intptr_t ___arg0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_AppleStoreImpl_MessageCallback_mDE43054189C8A5C0B7DB3F4757D2C1AABA4320A0(char* ___subject0, char* ___payload1, char* ___receipt2, char* ___transactionId3);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_FacebookStoreImpl_MessageCallback_m5BC6D65390C3AFC0DA2D451344D9738715D685B7(char* ___subject0, char* ___payload1, char* ___receipt2, char* ___transactionId3);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_TizenStoreImpl_MessageCallback_mDF9CE38D9695439D13532876D786508FD7150C98(char* ___subject0, char* ___payload1, char* ___receipt2, char* ___transactionId3);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidShow_m783A9B87185088290B4E9183A75FBE907C0C56D7(char* ___placementId0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidHide_m04A29537A16300AC2C9F1A0FFA433349CCBE4E22(char* ___placementId0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosBanner_UnityAdsBannerClick_mF510608A0DC2171E1D36E30F2D60580063C6AA25(char* ___placementId0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidError_mFFE893FEC561CB169C8BAE53230FE751F2844B95(char* ___message0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidUnload_m84DD55E1E9C470C1C586B27DC8E638C89B19A72E(char* ___placementId0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidLoad_mE5714DE3FDC6677B21E02BD522FC8BF4A5A15CCE(char* ___placementId0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosPlatform_UnityAdsReady_m6B88F5D804D0C40789972336230CCC6A7A6F220B(char* ___placementId0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosPlatform_UnityAdsDidError_mF07820A97DBB6776A22666257373DD9D6A34D08E(int64_t ___rawError0, char* ___message1);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosPlatform_UnityAdsDidStart_m86C841D4F663D9585A902A782DA5861F758B0488(char* ___placementId0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosPlatform_UnityAdsDidFinish_m04ABC3CDDD6F6A57817EB5382E9B4E5B91653070(char* ___placementId0, int64_t ___rawShowResult1);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_PurchasingPlatform_UnityAdsDidInitiatePurchasingCommand_m250E2CC6BE56571A7987EE76F912FCCC35D27098(char* ___eventString0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_PurchasingPlatform_UnityAdsPurchasingGetProductCatalog_m8D0C645DE944291FA5E19A79589AF4D0676F0C54();
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_PurchasingPlatform_UnityAdsPurchasingGetPurchasingVersion_mACDB5966BBF36282EA08F39A20AA7CB3B97C47C7();
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_PurchasingPlatform_UnityAdsPurchasingInitialize_m3FDFA0E5AC9BEE961158C92CC996B0D8F7883B83();


extern const Il2CppMethodPointer g_ReversePInvokeWrapperPointers[];
const Il2CppMethodPointer g_ReversePInvokeWrapperPointers[18] = 
{
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_OSSpecificSynchronizationContext_InvocationEntry_m056BCE43FF155AAE872FF7E565F8F72A50D26147),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_AppleStoreImpl_MessageCallback_mDE43054189C8A5C0B7DB3F4757D2C1AABA4320A0),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_FacebookStoreImpl_MessageCallback_m5BC6D65390C3AFC0DA2D451344D9738715D685B7),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_TizenStoreImpl_MessageCallback_mDF9CE38D9695439D13532876D786508FD7150C98),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidShow_m783A9B87185088290B4E9183A75FBE907C0C56D7),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidHide_m04A29537A16300AC2C9F1A0FFA433349CCBE4E22),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosBanner_UnityAdsBannerClick_mF510608A0DC2171E1D36E30F2D60580063C6AA25),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidError_mFFE893FEC561CB169C8BAE53230FE751F2844B95),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidUnload_m84DD55E1E9C470C1C586B27DC8E638C89B19A72E),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidLoad_mE5714DE3FDC6677B21E02BD522FC8BF4A5A15CCE),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosPlatform_UnityAdsReady_m6B88F5D804D0C40789972336230CCC6A7A6F220B),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosPlatform_UnityAdsDidError_mF07820A97DBB6776A22666257373DD9D6A34D08E),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosPlatform_UnityAdsDidStart_m86C841D4F663D9585A902A782DA5861F758B0488),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosPlatform_UnityAdsDidFinish_m04ABC3CDDD6F6A57817EB5382E9B4E5B91653070),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_PurchasingPlatform_UnityAdsDidInitiatePurchasingCommand_m250E2CC6BE56571A7987EE76F912FCCC35D27098),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_PurchasingPlatform_UnityAdsPurchasingGetProductCatalog_m8D0C645DE944291FA5E19A79589AF4D0676F0C54),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_PurchasingPlatform_UnityAdsPurchasingGetPurchasingVersion_mACDB5966BBF36282EA08F39A20AA7CB3B97C47C7),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_PurchasingPlatform_UnityAdsPurchasingInitialize_m3FDFA0E5AC9BEE961158C92CC996B0D8F7883B83),
};
