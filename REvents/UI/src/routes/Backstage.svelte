﻿<script lang="ts">
    import { onMount } from 'svelte';
    import { day, date, time } from '../tools/formatting'
    import { mobileAndTabletCheck } from '../tools/utils'
    import Monthes from '../lib/Monthes.svelte'
    import MonthesMobile from '../lib/MonthesMobile.svelte'

    export let data: any = null;
    export let events: [] = null;
    export let mPos = 0;

    export const isMobile = mobileAndTabletCheck();
    console.log(isMobile);
    onMount(async () => {
        const response = await fetch(`/api/events/backstage`);
        data = await response.json();
        events = data.events;
    });
    const scrollTo = (event) => {
        const to = event.detail.to;
        const next = events.find(e => to < new Date(e.date));
        if (next) {
            document.getElementById(dateToId(next.date)).scrollIntoView({ behavior: "smooth", block: "start" });
        }
    };

    const scroll = (event) => {
        console.log(event);
        //c.reduce((v,e)=>e.aH = e.clientHeight + v, 0)
        //c.find(e=>e.aH>x.scrollTop)
        mPos++;
    };

    const dateToId = (d: Date) => 'header_' + date(d);
</script>

<h1>Backstage</h1>
{#if data != null}
<div class="d-flex flex-row">

    <div class="" style="overflow-y: scroll; height: calc(100vh - 300px);" on:scroll="{scroll}" id="parent">
        {#each events as p }
        <div class="">
            <div class="card mb-1">
                <div class="card-header d-flex justify-content-between" id="{dateToId(p.date)}">
                    <div>{ date(p.date) }</div>
                    <div>{ day(p.date) }</div>
                </div>
                <div class="card-body pb-0">
                    {#each p.events as e}
                    <div class="d-flex flex-wrap justify-content-between">
                        <div>
                            <span>{ time(e.date) }</span>
                            { e.title }
                        </div>
                        <div>{ e.details }</div>
                    </div>
                    <div class="d-flex flex-wrap">
                        {#each e.types as t}
                        <span class="badge rounded-pill bg-secondary text-light mr-1 mt-1">{t}</span>
                        {/each}
                    </div>
                    <hr class="mb-0" />
                    {/each}
                </div>
            </div>
        </div>
        {/each}
    </div>

    {#if !isMobile}
    <Monthes on:movedto="{scrollTo}" position="{mPos}" />
    {:else}
    <MonthesMobile on:movedto="{scrollTo}" />
    {/if}
</div>{/if}