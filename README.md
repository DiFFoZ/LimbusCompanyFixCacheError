# Limbus Company Caching Error Fixer

Fixes those errors in logs, that causes UI to freeze.
```
OperationException : Cache is not ready to be accessed.
UnityEngine.Logger:Log(LogType, Object)
UnityEngine.Debug:LogError(Object)
UnityEngine.AddressableAssets.AddressablesImpl:LogException(AsyncOperationHandle, Exception)
UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase`1:set_OperationException(Exception)
UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase`1:Complete(TObject, Boolean, Exception, Boolean)
UnityEngine.AddressableAssets.CleanBundleCacheOperation:CompleteInternal(Boolean, Boolean, String)
UnityEngine.AddressableAssets.CleanBundleCacheOperation:Execute()
UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase`1:InvokeExecute()
UnityEngine.ResourceManagement.AsyncOperations.<>c__DisplayClass57_0:<add_CompletedTypeless>b__0(AsyncOperationHandle`1)
System.Action`1:Invoke(T)
DelegateList`1:Invoke(T)
UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase`1:InvokeCompletionEvent()
UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase`1:Complete(TObject, Boolean, Exception, Boolean)
UnityEngine.ResourceManagement.AsyncOperations.GroupOperation:CompleteIfDependenciesComplete()
UnityEngine.ResourceManagement.AsyncOperations.<>c__DisplayClass57_0:<add_CompletedTypeless>b__0(AsyncOperationHandle`1)
System.Action`1:Invoke(T)
DelegateList`1:Invoke(T)
UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase`1:InvokeCompletionEvent()
UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase`1:Complete(TObject, Boolean, Exception, Boolean)
UnityEngine.ResourceManagement.AsyncOperations.ProviderOperation`1:ProviderCompleted(T, Boolean, Exception)
UnityEngine.AddressableAssets.ResourceProviders.InternalOp:OnCatalogLoaded(ContentCatalogData)
UnityEngine.AddressableAssets.ResourceProviders.InternalOp:CatalogLoadOpCompleteCallback(AsyncOperationHandle`1)
System.Action`1:Invoke(T)
DelegateList`1:Invoke(T)
UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase`1:InvokeCompletionEvent()
UnityEngine.ResourceManagement.ResourceManager:ExecuteDeferredCallbacks()
UnityEngine.ResourceManagement.ResourceManager:Update(Single)

Exception: Attempting to use an invalid operation handle
  at UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle`1[TObject].Release () [0x00000] in <00000000000000000000000000000000>:0 
  at UnityEngine.AddressableAssets.CleanBundleCacheOperation.CompleteInternal (System.Boolean result, System.Boolean success, System.String errorMsg) [0x00000] in <00000000000000000000000000000000>:0 
  at UnityEngine.AddressableAssets.CleanBundleCacheOperation.RemoveCacheEntries () [0x00000] in <00000000000000000000000000000000>:0 
  at UnityEngine.AddressableAssets.CleanBundleCacheOperation.UnityEngine.ResourceManagement.IUpdateReceiver.Update (System.Single unscaledDeltaTime) [0x00000] in <00000000000000000000000000000000>:0 
  at DelegateList`1[T].Invoke (T res) [0x00000] in <00000000000000000000000000000000>:0 
  at UnityEngine.ResourceManagement.ResourceManager.Update (System.Single unscaledDeltaTime) [0x00000] in <00000000000000000000000000000000>:0 
UnityEngine.Logger:LogException(Exception, Object)
UnityEngine.Debug:LogException(Exception)
DelegateList`1:Invoke(T)
UnityEngine.ResourceManagement.ResourceManager:Update(Single)

NullReferenceException: Object reference not set to an instance of an object.
  at UnityEngine.AddressableAssets.CleanBundleCacheOperation.UnityEngine.ResourceManagement.IUpdateReceiver.Update (System.Single unscaledDeltaTime) [0x00000] in <00000000000000000000000000000000>:0 
  at DelegateList`1[T].Invoke (T res) [0x00000] in <00000000000000000000000000000000>:0 
  at UnityEngine.ResourceManagement.ResourceManager.Update (System.Single unscaledDeltaTime) [0x00000] in <00000000000000000000000000000000>:0 
UnityEngine.Logger:LogException(Exception, Object)
UnityEngine.Debug:LogException(Exception)
DelegateList`1:Invoke(T)
UnityEngine.ResourceManagement.ResourceManager:Update(Single)
...
```

# Warning
Use this for your cauntion. This mod may can cause to getting the account ban.
