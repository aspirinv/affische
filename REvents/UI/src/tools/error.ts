export function listenOnApiError(listener: (e: CustomEvent<applicationError>) => void) {
    onApiError.addEventListener("ApiFailure", listener as EventListener);
}
export const onApiError = new EventTarget();

export interface applicationError {
    code: string;
    title: string;
    message: string;
}