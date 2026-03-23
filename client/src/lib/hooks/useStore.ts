import { useContext } from "react";
import { StoreContext } from "../stores/Store.ts";

export function useStore() {
    return useContext(StoreContext);
}