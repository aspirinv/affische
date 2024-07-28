<script lang="ts">
	import { onMount } from "svelte";
	import { get, post } from "../../tools/utils";
	import { date } from "../../tools/formatting";
    import { navigate } from "svelte-routing";

	onMount(async () => {
	});

	interface ShortLinkHeader {
		title: string;
		validTo: string;
		url: string;
	}

    class ShortLinkHeaderVm implements ShortLinkHeader  {
        constructor(){
            this.title= "";
            this.validTo= new Date(new Date().setFullYear(new Date().getFullYear() + 1)).toISOString().substr(0, 10); 
            this.url= "";
            this.generatedTitle= false;
        }

        title: string;
        validTo: string;
        url: string;
	    generatedTitle: boolean;
    }

    let model: ShortLinkHeaderVm = new ShortLinkHeaderVm();

    const back = ()=>{
        navigate("/cp/short-links");
    };

    const save = async ()=>{
        let response = await post<string, ShortLinkHeader>("/api/ShortLinks", model);
        console.log(response);
        if(response !== null){
            console.log("navigating");
            navigate("/cp/short-links");
        }
    };

    const urlUpdate = (e: any)=>{
        if(!model.title || model.generatedTitle){
            const url = new URL(e.target.value);
            model.title = url.host.replace(/\.[^.]*$/, "").replace(/^www\./,"") + ": " + url.pathname.replace(/(^\/|\/$)/g,"").replace(/\//g,"_");
            model.generatedTitle = true;
        }
    };

    const titleUpdate = (e: any)=>{
        model.generatedTitle = false;
    };
</script>


<div>
    <div>
        <label class="form-label" for="url">URL:</label>
        <input class="form-control" type="text" id="url" name="url" on:input={urlUpdate} bind:value={model.url} autofocus />
    </div>
    <div>
        <label class="form-label" for="title">Title:</label>
        <input class="form-control" type="text" id="title" name="title" bind:value={model.title} on:input={titleUpdate} />
    </div>
    <div>
        <label class="form-label" for="validTo">Valid To:</label>
        <input class="form-control" type="date" id="validTo" name="validTo" bind:value={model.validTo} />
    </div>
    <div class="btn-group mt-2 d-flex">
        <button class="btn btn-primary" on:click={save}>Save</button>
        <button class="btn btn-outline-danger" on:click={back}>Cancel</button>
    </div>
</div>