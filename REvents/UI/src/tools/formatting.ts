
export function day(date: Date): string {
    return new Date(date).toLocaleString(navigator.language, { weekday: 'long' });
}

export function date(date: Date): string {
    return new Date(date).toLocaleString(navigator.language, { month: '2-digit', day: '2-digit', year:'numeric' });
}

export function time(date: Date): string {
    return new Date(date).toLocaleString(navigator.language, { hour12: false, hour: '2-digit', minute: '2-digit' });
}

//interface DateTimeFormatOptions {
//    localeMatcher?: "best fit" | "lookup";
//    weekday?: "long" | "short" | "narrow";
//    era?: "long" | "short" | "narrow";
//    year?: "numeric" | "2-digit";
//    month?: "numeric" | "2-digit" | "long" | "short" | "narrow";
//    day?: "numeric" | "2-digit";
//    hour?: "numeric" | "2-digit";
//    minute?: "numeric" | "2-digit";
//    second?: "numeric" | "2-digit";
//    timeZoneName?: "long" | "short";
//    formatMatcher?: "best fit" | "basic";
//    hour12?: boolean;
//    timeZone?: string;
//}