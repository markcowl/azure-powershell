# Ganerated Module Extensions
## Register-AzModule
### Events
### Pipeline
## Az.Accounts Implementation
### Tracing
Az.Accounts uses the event mechanism to write messages to the debug stream.  Whenever an event that should be traced for debugging occurs, A 'Debug' event is raised.  The geenrated cmdlet runtime will automatically write these events Using ICommandruntime.WriteDebug.

### Telemetry Headers
Az.Accounts adds the standard service telemetry headers for user-agent (```AzurePowerShell/Az1.0```) and for command parameters
### Client-side Telemetry
Az.Accounts adds an event handler for cmdlet execution events - this hand;er uses the existing TelemtryHelper to write messages using ApplicationInsights
### URL Rewriting
Az.Accounts implements a Callback for the Send event to rewrite URLs based on the user's selected environment. This works as follows:
- URL is normalized
- URL is matched against Endpoint properties of the AzureCloud environment - if there is a match, that endpoint is used; otherwise the ARM endpoint is used
- URL is parsed into parts and the host and base URI section are replaeced by the selected endpoint in the customer's selected cloud
- New URL is returned as art of the UrlCreated callback.
### Authentication
Az.Accounts implements a callback for the Send event to add an Authorization header, based on the targeted endpoint and the user's selected environment:
- Requiest URI is normalized
- Request URI is matched against Endpoint properties of the AzureCloud environment - if there is a match, that endpoint is used; otherwise the ARM endpoint is used
- Each endpoint is associated with a token audience value frm the environment, and the associacted token audience for the endpoint above is selected
- Token is acquired using the token audience above and the currently selected context
- Authorization header is added to the outgoing request using ```Bearer <token>```

### Unimplemented
