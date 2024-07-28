<script lang="ts">
    import { Router, Link, Route } from "svelte-routing";
    import Home from "./routes/Home.svelte";
    import Backstage from "./routes/Backstage.svelte";
    import Impressum from "./routes/Impressum.svelte";
    import Login from "./routes/manage/Login.svelte";
    import ShortLinks from "./routes/manage/ShortLinks.svelte";
    import Message from "./lib/Message.svelte";

    import "boxicons";
    import ShortLinksEdit from "./routes/manage/ShortLinksEdit.svelte";

    export let url = "";
    export let y = new Date().getFullYear();

</script>


<Router {url}>
    <header class="container">
        <Link class="text-primary" to="/"><h1 class="text-primary">Мюнхен Афиша</h1></Link>
    </header>
    <Message />
    <div class="border-bottom mb-5"></div>
    <!--  <nav>
        <Link to="/">Home</Link>
        <Link to="/backstage">backstage</Link>
      </nav>-->
    <div class="container mb-auto">
        <Route path="/backstage">
            <Backstage />
        </Route>
        <Route path="/impressum">
            <Impressum />
        </Route>
        <Route path="/">
            <Home />
        </Route>
        <Route path="/auth">
            <Login />
        </Route>
        <Route path="/cp/short-links">
            <ShortLinks />
        </Route> 
        <Route path="/cp/short-link">
            <ShortLinksEdit />
        </Route>
    </div>
    <footer class="bg-secondary d-flex justify-content-around p-4 mt-4">
        <div class="text-primary">© { y } Мюнхен Афиша</div>
        <Link class="text-primary" to="/impressum">Impressum</Link>
    </footer>
</Router>