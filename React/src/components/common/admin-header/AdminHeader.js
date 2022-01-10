import React, { useState } from "react";
import { Navbar,Container,Nav } from 'react-bootstrap';


const AdminHeader = () => {
   const [active, setActive] = useState('default');
    return(
        <>
            <Navbar bg="primary" variant="dark" expand="lg">
                <Container>
                    <Navbar.Toggle aria-controls="basic-navbar-nav" />
                    <Navbar.Collapse id="basic-navbar-nav">
                        <Nav className="me-auto" activeKey={active} onSelect={(selectedKey) => setActive(selectedKey)}>
                            <Nav.Link eventKey="default" href="/edit/managemovies" activeClassName="active">Movies</Nav.Link>
                            <Nav.Link eventKey="link1" href="/edit/manageactors" activeClassName="active">Actors</Nav.Link>
                            <Nav.Link eventKey="link2" href="/edit/managedirectors" activeClassName="active">Directors</Nav.Link>
                        </Nav>
                    </Navbar.Collapse>
                </Container>
            </Navbar>
        </>    
    );
}

export default AdminHeader;